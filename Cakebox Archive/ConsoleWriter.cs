/*
 * Created by SharpDevelop.
 * User: Tefra
 * Date: 17/4/2012
 * Time: 1:44 πμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Cakebox_Archive
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
			WriteLine(str);
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