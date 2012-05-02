/**
 * @version	$Id: Index.cs 80 2012-04-27 22:22:39Z Tefra $
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Windows.Forms;

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
		/// <summary>
		/// Constructor initializing Control, Property name and Setting name
		/// </summary>
		/// <param name="item"></param>
		/// <param name="property"></param>
		/// <param name="setting"></param>
		public ControlBinding(Control ctrl, string property, string setting)
		{
			Ctrl = ctrl;
			Property= property;
			Setting = setting;
		}
				
		/// <summary>
		/// Magic get set for Control
		/// </summary>
		public Control Ctrl {get; set;}

		/// <summary>
		/// Magic get set for Setting
		/// </summary>
		public string Setting {get; set;}

		/// <summary>
		/// Magic get set for Property
		/// </summary>
		public string Property {get; set;}
		
		/// <summary>
		/// Set the control property value from the application setting
		/// </summary>
		public void ReadValue()
		{
			Ctrl.GetType().GetProperty(Property).SetValue(Ctrl, Properties.Settings.Default[Setting], null);
		}

		/// <summary>
		/// Reads the current value of the control property and writes it to the application setting
		/// </summary>
		public void WriteValue()
		{
			Properties.Settings.Default[Setting] = Ctrl.GetType().GetProperty(Property).GetValue(Ctrl, null);
		}
	}
}
