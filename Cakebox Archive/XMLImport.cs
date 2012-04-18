/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Xml;

namespace Cakebox_Archive
{
	/// <summary>
	/// Description of XMLImport.
	/// </summary>
	public class XMLImport
	{
		public XMLImport(string file)
		{
			try
			{
				string table = null;
				List<string> columns = null;
				List<string> values = null;
				
				SQLiteConnection db = Model.Instance.db;
				SQLiteTransaction transaction = db.BeginTransaction();
				using (XmlReader reader = new XmlTextReader(file))
				{
					while (reader.Read())
					{
						if(reader.NodeType == XmlNodeType.Element)
						{
							if(reader.Name == "table")
							{
								table = reader.GetAttribute("name");
								columns = new List<string>();
								values = new List<string>();
							}
							else if(reader.Name == "column")
							{
								columns.Add(reader.GetAttribute("name"));
								values.Add(reader.ReadString());
							}
						}
						else if(reader.NodeType == XmlNodeType.EndElement)
						{
							if(reader.Name == "table")
							{
								SQLiteCommand cm = db.CreateCommand();
								cm.CommandText = String.Format("INSERT INTO {0} ({1}) VALUES (@{2})", table, String.Join(", ", columns), String.Join(", @", columns));
								
								for(int i = 0; i < columns.Count; i++)
								{
									cm.Parameters.Add(new SQLiteParameter("@"+columns[i], values[i]));
								}
								cm.ExecuteNonQuery();
								cm.Dispose();
							}
						}
					}
				}
				transaction.Commit();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
