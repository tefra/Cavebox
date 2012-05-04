/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cavebox.Forms
{
	/// <summary>
	/// Show application changelog
	/// </summary>
	public partial class Changelog : Form
	{
		/// <summary>
		/// Initialize components and attempt to load the changelog.txt
		/// </summary>
		public Changelog()
		{
			InitializeComponent();
			try
			{
				changelogTextBox.Text = System.IO.File.ReadAllText("changelog.txt");
			}
			catch
			{
				changelogTextBox.Text = Cavebox.Lib.Lang.GetString("_readmeMissing");
			}
		}
	}
}
