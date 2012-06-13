/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
namespace Cavebox.Forms
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
			this.cakeboxLabel = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.cakeboxLabelLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cakeboxLabel
			// 
			this.cakeboxLabel.Location = new System.Drawing.Point(54, 12);
			this.cakeboxLabel.Name = "cakeboxLabel";
			this.cakeboxLabel.Size = new System.Drawing.Size(318, 20);
			this.cakeboxLabel.TabIndex = 0;
			this.cakeboxLabel.TextChanged += new System.EventHandler(this.CakeboxLabelTextChanged);
			// 
			// saveButton
			// 
			this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.saveButton.Enabled = false;
			this.saveButton.Location = new System.Drawing.Point(216, 38);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "Save";
			this.saveButton.Click += new System.EventHandler(this.SaveCakebox);
			// 
			// Cancel
			// 
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(297, 38);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 3;
			this.Cancel.Text = "Cancel";
			// 
			// cakeboxLabelLabel
			// 
			this.cakeboxLabelLabel.Location = new System.Drawing.Point(12, 15);
			this.cakeboxLabelLabel.Name = "cakeboxLabelLabel";
			this.cakeboxLabelLabel.Size = new System.Drawing.Size(36, 23);
			this.cakeboxLabelLabel.TabIndex = 4;
			this.cakeboxLabelLabel.Text = "Label:";
			// 
			// EditCakebox
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(384, 67);
			this.Controls.Add(this.cakeboxLabelLabel);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.cakeboxLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditCakebox";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label cakeboxLabelLabel;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox cakeboxLabel;
	}
}
