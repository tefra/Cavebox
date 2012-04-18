/*
 * Created by SharpDevelop.
 * User: Tefra
 * Date: 17/4/2012
 * Time: 3:48 πμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Xml;

namespace Cakebox_Archive
{
	/// <summary>
	/// Description of XMLImport.
	/// </summary>
	public class XMLImport
	{
		string _table = null;
		List<string> _columns = null;
		List<string> _values = null;
		
		private void insert()
		{
			Model model = Model.Instance;
			model.insert(_table, _columns, _values);
		}
		
		public XMLImport(string file)
		{
			using (XmlReader reader = new XmlTextReader(file))
			{
				while (reader.Read())
				{
					switch(reader.NodeType)
					{
						case XmlNodeType.Element:
							if(reader.Name == "table")
							{
								_table = reader.GetAttribute("name");
								_columns = new List<string>();
								_values = new List<string>();
							}
							else if(reader.Name == "column")
							{
								_columns.Add(reader.GetAttribute("name"));
								_values.Add(reader.ReadString());
							}
						break;
							
						case XmlNodeType.EndElement:
							if(reader.Name == "table")
							{
								insert();
							}
						break;
					}
				}
			}
		}
	}
}
