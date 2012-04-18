/*
 * Created by SharpDevelop.
 * User: Tefra
 * Date: 16/4/2012
 * Time: 9:05 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cakebox_Archive
{
	partial class EditCakebox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCakebox));
			this.cakeboxLabel = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cakeboxLabel
			// 
			resources.ApplyResources(this.cakeboxLabel, "cakeboxLabel");
			this.cakeboxLabel.Name = "cakeboxLabel";
			// 
			// saveButton
			// 
			resources.ApplyResources(this.saveButton, "saveButton");
			this.saveButton.Name = "saveButton";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveCakebox);
			// 
			// Cancel
			// 
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this.Cancel, "Cancel");
			this.Cancel.Name = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.closeForm);
			// 
			// EditCakebox
			// 
			this.AcceptButton = this.saveButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this.Cancel;
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.cakeboxLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EditCakebox";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox cakeboxLabel;
	}
}
