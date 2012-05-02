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
		/// Constructor
		/// </summary>
		/// <param name="textBox">The RichTextBox which will be our visual console</param>
		public ConsoleWriter(System.Windows.Forms.RichTextBox textBox)
		{
			
			console = textBox;
		}
		
		/// <summary>
		/// Append a text line to the console
		/// </summary>
		/// <param name="str"></param>
		public override void Write(string str)
		{
			console.AppendText(str);
		}

		/// <summary>
		/// Append a text line plus add new line to the console with the timestamp the 
		/// </summary>
		/// <param name="str">The message to append to console</param>
		public override void WriteLine(string str)
		{
			console.AppendText("[" + DateTime.Now.ToString(format) + "] " + str + "\n");
		}
		
		/// <summary>
		/// Get an encoding for the UTF-8 format
		/// </summary>
		public override System.Text.Encoding Encoding
		{
			get { return System.Text.Encoding.UTF8; }
		}
	}
}