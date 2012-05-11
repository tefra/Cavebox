/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;

namespace Cavebox.Lib
{
	/// <summary>
	/// General extension methods used throughout the project
	/// </summary>
	static class Util
	{
		/// <summary>
		/// Update a ToolStripLabel with a number ex. Files: 26.756
		/// </summary>
		/// <param name="ctrl">The ToolStripLabel that needs update</param>
		/// <param name="num">The total number</param>
		public static void InsertTitle(this System.Windows.Forms.ToolStripLabel ctrl, int num)
		{
			string title = ctrl.Text.Split(':')[0].Trim();
			title += (num > 0) ? ": " + String.Format("{0:n0}", num) : null;
			ctrl.Text = title;
		}
		

		/// <summary>
		/// Update a GroupBox with a number ex. Files: 26.756
		/// </summary>
		/// <param name="ctrl">The GroupBox that needs update</param>
		/// <param name="num">The total number</param>
		public static void InsertTitle(this System.Windows.Forms.GroupBox ctrl, int num)
		{
			string title = ctrl.Text.Split(':')[0].Trim();
			title += (num > 0) ? ": " + String.Format("{0:n0}", num) : null;
			ctrl.Text = title;
		}
		
		/// <summary>
		/// Update a ToolStripLabel with some string ex Label: Description
		/// </summary>
		/// <param name="ctrl">The GroupBox that needs update</param>
		/// <param name="str">The str</param>
		public static void InsertTitle(this System.Windows.Forms.ToolStripLabel ctrl, string str)
		{
			ctrl.Text = ctrl.Text.Split(':')[0].Trim() + ": " + str;
		}
		
		/// <summary>
		/// Format a unix timestamp to readable datetime
		/// </summary>
		/// <param name="unix">Unix timestamp</param>
		/// <param name="format">String format</param>
		public static string Date(this int unix, string format = "dd/MM/yyyy HH:mm:ss")
		{
			return new DateTime(1970, 1, 1).AddSeconds(unix).ToLocalTime().ToString(format);
		}
		
		/// <summary>
		/// Get the ListBox selected value converted to integer
		/// </summary>
		/// <param name="source">The source Listbox</param>
		public static int SelectedIntValue(this System.Windows.Forms.ListBox source)
		{
			return Convert.ToInt32(source.SelectedValue);
		}
		
		/// <summary>
		/// Get the ComboBox selected value converted to integer
		/// </summary>
		/// <param name="source">The source ComboBox</param>
		public static int SelectedIntValue(this System.Windows.Forms.ComboBox source)
		{
			return Convert.ToInt32(source.SelectedValue);
		}
	}
}