/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Drawing;
using System.IO;

namespace Cavebox
{
	/// <summary>
	/// Description of ConcoleWriter.
	/// </summary>
	public class ConsoleWriter : TextWriter
	{
		private string format = "hh:mm:ss";
		private System.Windows.Forms.RichTextBox console;
		
		public ConsoleWriter(System.Windows.Forms.RichTextBox textBox)
		{
			console = textBox;
		}
		
		public override void Write(string str)
		{
			console.AppendText(str + "\n");
		}

		public override void WriteLine(string str)
		{
			console.AppendText("[" + DateTime.Now.ToString(format) + "] " + str + "\n");
		}
		
		public override System.Text.Encoding Encoding
		{
			get { return System.Text.Encoding.ASCII; }
		}
	}
}