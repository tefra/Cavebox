/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Threading;
using System.Windows.Forms;

namespace Cakebox_Archive
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			if (!Program.isSingleton())
			{
				MessageBox.Show("Cakebox Archive is already running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			}
		}
		
		static Mutex _m;

		static bool isSingleton()
		{
			try
			{
				Mutex.OpenExisting("Cakebox Archive");
			}
			catch
			{
				Program._m = new Mutex(true, "Cakebox Archive");
				return true;
			}
			return false;
		}
	}
}