/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Data.SQLite;
using System.Xml;

namespace Cavebox.Lib
{
	/// <summary>
	/// Description of XMLExport.
	/// </summary>
	public class XMLExport
	{
		/// <summary>
		/// Open xmlwriter and write db tables cakebox and disc
		/// </summary>
		/// <param name="file"></param>
		public XMLExport(string file)
		{
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			using (XmlWriter writer = XmlWriter.Create(file, settings))
			{
				writer.WriteStartDocument();
				writer.WriteStartElement("DATA");
				writeTable("cakebox", writer);
				writeTable("disc", writer);
				writer.WriteEndElement();
				writer.WriteEndDocument();
				writer.Close();
			}
		}
		
		/// <summary>
		/// Write table data with xmlwriter
		/// </summary>
		/// <param name="table"></param>
		/// <param name="writer"></param>
		public void writeTable(string table, XmlWriter writer)
		{
			try
			{
				SQLiteCommand cm = Model.db.CreateCommand();
				cm.CommandText = "SELECT * FROM "+table+" WHERE 1";
				SQLiteDataReader row = cm.ExecuteReader();
				while(row.Read())
				{
					writer.WriteStartElement("table");
					writer.WriteAttributeString("name", table);
					for(int i = 0; i < row.FieldCount; i++)
					{
						writer.WriteStartElement("column");
						writer.WriteAttributeString("name", row.GetName(i));
						writer.WriteString(row.GetValue(i).ToString());
						writer.WriteEndElement();
					}
					writer.WriteEndElement();
				}
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
