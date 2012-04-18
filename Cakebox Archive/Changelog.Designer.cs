/*
 * Created by SharpDevelop.
 * User: Tefra
 * Date: 16/4/2012
 * Time: 8:50 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cakebox_Archive
{
	partial class Changelog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changelog));
			this.changelogTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// changelogTextBox
			// 
			this.changelogTextBox.BackColor = System.Drawing.SystemColors.Window;
			resources.ApplyResources(this.changelogTextBox, "changelogTextBox");
			this.changelogTextBox.Name = "changelogTextBox";
			this.changelogTextBox.ReadOnly = true;
			this.changelogTextBox.TextChanged += new System.EventHandler(this.ChangelogTextBoxTextChanged);
			// 
			// Changelog
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.changelogTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Changelog";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RichTextBox changelogTextBox;
	}
}
