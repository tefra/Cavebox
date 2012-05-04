/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;

using System.ComponentModel;

using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Cavebox.Properties;

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
		Settings _Settings;
		
		/// <summary>
		/// Constructor initializing Control, Property name and Setting name
		/// </summary>
		/// <param name="ctrl">The control instance</param>
		/// <param name="property">The control's property title</param>
		/// <param name="key">The settings key</param>
		public ControlBinding(Control ctrl, string property, string key)
		{
			Ctrl = ctrl;
			Property = ctrl.GetType().GetProperty(property);
			Key = key;
			_Settings = Properties.Settings.Default;
		}
		
		/// <summary>
		/// Magic get set for Control
		/// </summary>
		public Control Ctrl { get; set; }

		/// <summary>
		/// Magic get set for Settings Key
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Magic get set for Property
		/// </summary>
		public PropertyInfo Property { get; set; }
		
		/// <summary>
		/// Sets the control property value from the application setting
		/// </summary>
		public void ReadValue()
		{
			Property.SetValue(Ctrl, _Settings[Key], null);
		}

		/// <summary>
		/// Reads the current value of the control property and writes it to the application setting
		/// </summary>
		public void WriteValue()
		{
			_Settings[Key] = Property.GetValue(Ctrl, null);
		}
		
		/// <summary>
		/// Sets the control property value from the application settings defaul value
		/// </summary>
		public void ResetValue()
		{
			Property.SetValue(Ctrl, GetDefaultValue(), null);
		}

		/// <summary>
		/// Get the default setting value.
		/// Two major issues here first the default value is always a string and secondly
		/// the Convert.ChangeType doesn't work for string to point or size... duhhh
		/// </summary>
		public object GetDefaultValue()
		{
			Type t = _Settings[Key].GetType();
			if(t == typeof(System.Drawing.Size))
			{
				return new Size(ParsePoint(_Settings.Properties[Key].DefaultValue.ToString()));
			}
			else if(t == typeof(System.Drawing.Point))
			{
				return ParsePoint(_Settings.Properties[Key].DefaultValue.ToString());
			}
			else
			{
				return Convert.ChangeType(_Settings.Properties[Key].DefaultValue, _Settings[Key].GetType());
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