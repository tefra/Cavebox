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
		/// Insert description after a ToolStripLabel original text ex. Files: 26.756
		/// </summary>
		/// <param name="ctrl">The ToolStripLabel</param>
		/// <param name="num">The integer description</param>
		public static void InsertDesc(this System.Windows.Forms.ToolStripLabel ctrl, int num)
		{
			string title = ctrl.Text.Split(':')[0].Trim();
			title += (num > 0) ? ": " + String.Format("{0:n0}", num) : null;
			ctrl.Text = title;
		}

		/// <summary>
		///  Insert description after a GroupBox original text ex. Files: 26.756
		/// </summary>
		/// <param name="ctrl">The GroupBox</param>
		/// <param name="num">The integer description</param>
		public static void InsertDesc(this System.Windows.Forms.GroupBox ctrl, int num)
		{
			string title = ctrl.Text.Split(':')[0].Trim();
			title += (num > 0) ? ": " + String.Format("{0:n0}", num) : null;
			ctrl.Text = title;
		}
		
		/// <summary>
		///  Insert description after a ToolStripLabel original text ex Label: Description
		/// </summary>
		/// <param name="ctrl">The ToolStripLabel</param>
		/// <param name="str">The string description</param>
		public static void InsertDesc(this System.Windows.Forms.ToolStripLabel ctrl, string str)
		{
			ctrl.Text = ctrl.Text.Split(':')[0].Trim() + ": " + str;
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
		
		private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		/// <summary>
		/// Convert datetime to unix timestamp
		/// </summary>
		/// <param name="dt">The datetime you need to convert</param>
		public static long ToUnix(this DateTime dt)
		{
			return (long) (dt - Jan1st1970).TotalSeconds;
		}
		
		/// <summary>
		/// Format a unix timestamp to a readable string
		/// </summary>
		/// <param name="unix">Unix timestamp</param>
		/// <param name="format">String format</param>
		public static string Date(this int seconds, string format = "dd/MM/yyyy HH:mm:ss")
		{
			return Jan1st1970.AddSeconds(seconds).ToLocalTime().ToString(format);
		}
	}
}