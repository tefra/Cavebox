/*
 * Created by SharpDevelop.
 * User: Tefra
 * Date: 18/4/2012
 * Time: 1:37 πμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SQLite;
using System.Xml;

namespace Cakebox_Archive
{
	/// <summary>
	/// Description of XMLExport.
	/// </summary>
	public class XMLExport
	{
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
		
		public void writeTable(string table, XmlWriter writer)
		{
			SQLiteCommand cm = Model.Instance.db.CreateCommand();
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
	}
}
