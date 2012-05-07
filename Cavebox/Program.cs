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
	internal sealed class Program
	{
		static Mutex _m;

		/// <summary>
		/// Check for single application instance and open the main form
		/// </summary>
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

		/// <summary>
		/// Check if the application is already running or not based on a named mutext
		/// pretty sure this isn't the safest way, but hey this isn't AFIS ;p
		/// </summary>
		/// <returns>True if the application is not already running False otherwise</returns>
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