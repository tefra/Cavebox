/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
namespace Cavebox.Forms
{
	partial class EditDisc
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
			this.discLabelLabel = new System.Windows.Forms.Label();
			this.selectCakeboxLabel = new System.Windows.Forms.Label();
			this.discLabel = new System.Windows.Forms.TextBox();
			this.selectCakebox = new System.Windows.Forms.ComboBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// discLabelLabel
			// 
			this.discLabelLabel.Location = new System.Drawing.Point(12, 14);
			this.discLabelLabel.Name = "discLabelLabel";
			this.discLabelLabel.Size = new System.Drawing.Size(52, 23);
			this.discLabelLabel.TabIndex = 0;
			this.discLabelLabel.Text = "Label:";
			// 
			// selectCakeboxLabel
			// 
			this.selectCakeboxLabel.Location = new System.Drawing.Point(12, 40);
			this.selectCakeboxLabel.Name = "selectCakeboxLabel";
			this.selectCakeboxLabel.Size = new System.Drawing.Size(52, 23);
			this.selectCakeboxLabel.TabIndex = 1;
			this.selectCakeboxLabel.Text = "Cakebox:";
			// 
			// discLabel
			// 
			this.discLabel.Location = new System.Drawing.Point(70, 11);
			this.discLabel.Name = "discLabel";
			this.discLabel.Size = new System.Drawing.Size(302, 20);
			this.discLabel.TabIndex = 2;
			this.discLabel.TextChanged += new System.EventHandler(this.EnableSaveButton);
			// 
			// selectCakebox
			// 
			this.selectCakebox.DisplayMember = "Value";
			this.selectCakebox.DropDownHeight = 150;
			this.selectCakebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectCakebox.IntegralHeight = false;
			this.selectCakebox.Location = new System.Drawing.Point(70, 37);
			this.selectCakebox.Name = "selectCakebox";
			this.selectCakebox.Size = new System.Drawing.Size(302, 21);
			this.selectCakebox.TabIndex = 3;
			this.selectCakebox.ValueMember = "Key";
			this.selectCakebox.SelectedValueChanged += new System.EventHandler(this.EnableSaveButton);
			// 
			// saveButton
			// 
			this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.saveButton.Enabled = false;
			this.saveButton.Location = new System.Drawing.Point(216, 64);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "Save";
			this.saveButton.Click += new System.EventHandler(this.SaveDisc);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(297, 64);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Cancel";
			// 
			// EditDisc
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(384, 93);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.selectCakebox);
			this.Controls.Add(this.discLabel);
			this.Controls.Add(this.selectCakeboxLabel);
			this.Controls.Add(this.discLabelLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditDisc";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Disc";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label discLabelLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ComboBox selectCakebox;
		private System.Windows.Forms.TextBox discLabel;
		private System.Windows.Forms.Label selectCakeboxLabel;
	}
}
