/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Xml;

namespace Cavebox.Lib
{
	/// <summary>
	/// Load the xml file the XMLExport created and attempt to import the data
	/// </summary>
	public class XMLImport
	{
		public Dictionary<string, int> imported = new Dictionary<string, int>();
		
		/// <summary>
		/// Read table data and insert it. Expect an exception in case
		/// of bad schmema or missing table structures.
		/// </summary>
		/// <param name="file">Filename of the xml backup</param>
		public XMLImport(string file)
		{
			try
			{
				string table = null;
				Dictionary<string, string> data = new Dictionary<string, string>();

				SQLiteTransaction transaction = Model.db.BeginTransaction();
				using (XmlReader reader = new XmlTextReader(file))
				{
					while (reader.Read())
					{
						if(reader.NodeType == XmlNodeType.Element)
						{
							if(reader.Name == "table")
							{
								table = reader.GetAttribute("name");
								data = new Dictionary<string, string>();
							}
							else if(reader.Name == "column")
							{
								data.Add(reader.GetAttribute("name"), reader.ReadString());
							}
						}
						else if(reader.NodeType == XmlNodeType.EndElement && reader.Name == "table")
						{
							imported[table] = imported.ContainsKey(table) ? imported[table] + 1 : 1;
							Model.Insert(table, data);
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