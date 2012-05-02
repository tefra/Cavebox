/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Drawing;
using System.IO;

namespace Cavebox.Lib
{
	/// <summary>
	/// Write console input to a richtextbox, nothing fancy here
	/// </summary>
	public class ConsoleWriter : TextWriter
	{
		private string format = "hh:mm:ss";
		private System.Windows.Forms.RichTextBox console;
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="textBox"></param>
		public ConsoleWriter(System.Windows.Forms.RichTextBox textBox)
		{
			console = textBox;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str"></param>
		public override void Write(string str)
		{
			console.AppendText(str);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="str"></param>
		public override void WriteLine(string str)
		{
			console.AppendText("[" + DateTime.Now.ToString(format) + "] " + str + "\n");
		}
		
		/// <summary>
		/// 
		/// </summary>
		public override System.Text.Encoding Encoding
		{
			get { return System.Text.Encoding.ASCII; }
		}
	}
}