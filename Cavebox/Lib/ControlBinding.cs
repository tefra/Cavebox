/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Drawing;
using System.Reflection;

namespace Cavebox.Lib
{
	/// <summary>
	/// Custom control property binding with predefined Datasource
	/// the Application Settings. I could use the .Net Ctrl.DataBindings.Add(new Binding())
	/// but for some reason the splitContainer splitter distance didn't work when changing
	/// the value from the code instead of the UI. (see Reset Window method)
	/// </summary>
	public class ControlBinding
	{
		Cavebox.Properties.Settings Options = Properties.Settings.Default;
		
		/// <summary>
		/// Constructor initializing Control, Property name and Setting name
		/// </summary>
		/// <param name="ctrl">The object instance</param>
		/// <param name="property">The control's property title</param>
		/// <param name="key">The settings key</param>
		public ControlBinding(object obj, string property, string key)
		{
			Obj = obj;
			Property = obj.GetType().GetProperty(property);
			Key = key;
		}
		
		/// <summary>
		/// Magic get set for Control/Object
		/// </summary>
		public object Obj { get; set; }

		/// <summary>
		/// Magic get set for Settings Key
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Magic get set for Property
		/// </summary>
		public PropertyInfo Property { get; set; }
		
		/// <summary>
		/// Sets the object property value from the application setting
		/// </summary>
		public void ReadValue()
		{
			Property.SetValue(Obj, Options[Key], null);
		}

		/// <summary>
		/// Reads the current value of the object property and writes it to the application setting
		/// </summary>
		public void WriteValue()
		{
			Options[Key] = Property.GetValue(Obj, null);
		}
		
		/// <summary>
		/// Sets the object property value from the application settings defaul value
		/// </summary>
		public void ResetValue()
		{
			Property.SetValue(Obj, GetDefaultValue(), null);
		}

		/// <summary>
		/// Get the default setting value.
		/// Two major issues here first the default value is always a string and secondly
		/// the Convert.ChangeType doesn't work for string to point or size... duhhh
		/// </summary>
		public object GetDefaultValue()
		{
			Type t = Options[Key].GetType();
			if(t == typeof(System.Drawing.Size))
			{
				return new Size(ParsePoint(Options.Properties[Key].DefaultValue.ToString()));
			}
			else if(t == typeof(System.Drawing.Point))
			{
				return ParsePoint(Options.Properties[Key].DefaultValue.ToString());
			}
			else
			{
				return Convert.ChangeType(Options.Properties[Key].DefaultValue, Options[Key].GetType());
			}
		}
		
		/// <summary>
		/// Convert string to point
		/// </summary>
		/// <param name="text">Text representation of a point "520, 145"</param>
		private static Point ParsePoint(string text)
		{
			string[] parts = text.Split(',');
			return new Point(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]));
		}
	}
}