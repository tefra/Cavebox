/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Threading;
using System.Windows.Forms;

using Cavebox.Forms;

namespace Cavebox.Lib
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		[STAThread]
		private static void Main(string[] args)
		{
			if (!Program.isSingleton())
			{
				MessageBox.Show("Cavebox is already running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Main());
			}
		}
		
		static Mutex _m;

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		static bool isSingleton()
		{
			try
			{
				Mutex.OpenExisting("Cavebox");
			}
			catch
			{
				Program._m = new Mutex(true, "Cavebox");
				return true;
			}
			return false;
		}
	}
}