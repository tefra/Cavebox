/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
namespace Cavebox.Forms
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
			this.changelogTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// changelogTextBox
			// 
			this.changelogTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.changelogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.changelogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.changelogTextBox.Location = new System.Drawing.Point(0, 0);
			this.changelogTextBox.Name = "changelogTextBox";
			this.changelogTextBox.ReadOnly = true;
			this.changelogTextBox.Size = new System.Drawing.Size(394, 276);
			this.changelogTextBox.TabIndex = 0;
			this.changelogTextBox.Text = "";
			this.changelogTextBox.WordWrap = false;
			// 
			// Changelog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 276);
			this.Controls.Add(this.changelogTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Changelog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Changelog";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RichTextBox changelogTextBox;
	}
}
