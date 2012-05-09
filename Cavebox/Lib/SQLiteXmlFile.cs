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
	/// Load/Save sql records from/to xml file
	/// </summary>
	static class SQLiteXmlFile
	{
		/// <summary>
		/// Read table data and insert it.
		/// </summary>
		/// <param name="file">Filename of the xml backup</param>
		/// <returns>The number of records imported</returns>
		public static int Load(string file)
		{
			int records = 0;
			try
			{
				string table = null;
				Dictionary<string, string> data = new Dictionary<string, string>();
				using(SQLiteTransaction transaction = Model.db.BeginTransaction())
				{
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
								records++;
								Model.Insert(table, data);
							}
						}
					}
					transaction.Commit();
				}
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
			return records;
		}
		
		/// <summary>
		/// Open xmlwriter and write db tables cakebox and disc
		///   <table name="cakebox">
		///     <column name="id">1</column>
		///     <column name="label">Movies #01</column>
		///   </table>
		/// </summary>
		/// <param name="file">filename where to open write and save backup</param>
		public static void Save(string file)
		{
			string[] tables = {"cakebox", "disc"};
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.NewLineChars = "\n";
			using (XmlWriter xml = XmlWriter.Create(file, settings))
			{
				xml.WriteStartDocument();
				xml.WriteStartElement("DATA");
				foreach(string table in tables)
				{
					try
					{
						SQLiteCommand c = Model.CreateCommand("SELECT * FROM " + table + " WHERE 1");
						SQLiteDataReader r = c.ExecuteReader();
						while(r.Read())
						{
							xml.WriteStartElement("table");
							xml.WriteAttributeString("name", table);
							for(int i = 0; i < r.FieldCount; i++)
							{
								xml.WriteStartElement("column");
								xml.WriteAttributeString("name", r.GetName(i));
								xml.WriteString(r.GetValue(i).ToString());
								xml.WriteEndElement();
							}
							xml.WriteEndElement();
						}
						r.Close();
						c.Dispose();
					}
					catch(SQLiteException e)
					{
						Console.WriteLine(e.Message);
					}
				}
				xml.WriteEndElement();
				xml.WriteEndDocument();
				xml.Close();
			}
		}
	}
}