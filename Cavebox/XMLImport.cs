/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Xml;

namespace Cavebox
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
				
				SQLiteConnection db = Model.db;
				
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
								Model.Insert(table, columns, values);
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
			finally
			{
				
			}
		}
	}
}
