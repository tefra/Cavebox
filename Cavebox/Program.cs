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
		static Mutex mutex;

		/// <summary>
		/// Check for single application instance and open the main form
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			if (Program.IsAlreadyRunning())
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
		/// Check if the application is already running or not based on the executable full path
		/// The check ensures specific exe single instance. It will not block multiple installations to run at the same time
		/// </summary>
		/// <returns>True if the application is already running False otherwise</returns>
		public static bool IsAlreadyRunning()
		{
			string loc = GetMD5Hash(Application.ExecutablePath);
			try
			{
				Mutex.OpenExisting(loc);
			}
			catch
			{
				mutex = new Mutex(true, loc);
				return false;
			}
			return true;
		}
		
		/// <summary>
		/// Generate 32chars md5 hash from string
		/// @http://blog.brezovsky.net/en-text-2.html
		/// </summary>
		/// <param name="input">string to hash</param>
		/// <returns>Hashed string</returns>
		public static string GetMD5Hash(string input)
		{
			System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
			byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
			bs = x.ComputeHash(bs);
			System.Text.StringBuilder s = new System.Text.StringBuilder();
			foreach (byte b in bs)
			{
				s.Append(b.ToString("x2").ToLower());
			}
			return s.ToString();
		}
	}
}