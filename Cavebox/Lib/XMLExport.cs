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
	/// Create a new xml file and write database table records.
	/// </summary>
	public class XMLExport
	{
		/// <summary>
		/// Open xmlwriter and write db tables cakebox and disc
		/// </summary>
		/// <param name="file">filename where to open write and save backup</param>
		public XMLExport(string file)
		{
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.NewLineChars = "\n";
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
		/// Write table data with xmlwriter, example:
		///   <table name="cakebox">
		///     <column name="id">1</column>
		///     <column name="label">Movies #01</column>
		///   </table>
		/// </summary>
		/// <param name="table">The table name</param>
		/// <param name="writer">XmlWriter initialized istance</param>
		public void writeTable(string table, XmlWriter writer)
		{
			try
			{
				SQLiteCommand c = Model.CreateCommand("SELECT * FROM " + table + " WHERE 1");
				SQLiteDataReader r = c.ExecuteReader();
				while(r.Read())
				{
					writer.WriteStartElement("table");
					writer.WriteAttributeString("name", table);
					for(int i = 0; i < r.FieldCount; i++)
					{
						writer.WriteStartElement("column");
						writer.WriteAttributeString("name", r.GetName(i));
						writer.WriteString(r.GetValue(i).ToString());
						writer.WriteEndElement();
					}
					writer.WriteEndElement();
				}
				r.Close();
				c.Dispose();
			}
			catch(SQLiteException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}