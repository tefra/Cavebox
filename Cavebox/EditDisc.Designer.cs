/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
namespace Cavebox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDisc));
			this.discLabelLabel = new System.Windows.Forms.Label();
			this.discCakeboxLabel = new System.Windows.Forms.Label();
			this.discLabel = new System.Windows.Forms.TextBox();
			this.discCakebox = new System.Windows.Forms.ComboBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// discLabelLabel
			// 
			resources.ApplyResources(this.discLabelLabel, "discLabelLabel");
			this.discLabelLabel.Name = "discLabelLabel";
			// 
			// discCakeboxLabel
			// 
			resources.ApplyResources(this.discCakeboxLabel, "discCakeboxLabel");
			this.discCakeboxLabel.Name = "discCakeboxLabel";
			// 
			// discLabel
			// 
			resources.ApplyResources(this.discLabel, "discLabel");
			this.discLabel.Name = "discLabel";
			this.discLabel.TextChanged += new System.EventHandler(this.enableSaveButton);
			// 
			// discCakebox
			// 
			this.discCakebox.DisplayMember = "Value";
			this.discCakebox.DropDownHeight = 150;
			this.discCakebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.discCakebox.FormattingEnabled = true;
			resources.ApplyResources(this.discCakebox, "discCakebox");
			this.discCakebox.Name = "discCakebox";
			this.discCakebox.ValueMember = "Id";
			this.discCakebox.SelectedValueChanged += new System.EventHandler(this.enableSaveButton);
			// 
			// saveButton
			// 
			resources.ApplyResources(this.saveButton, "saveButton");
			this.saveButton.Name = "saveButton";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveDisc);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this.cancelButton, "cancelButton");
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CloseForm);
			// 
			// EditDisc
			// 
			this.AcceptButton = this.saveButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.discCakebox);
			this.Controls.Add(this.discLabel);
			this.Controls.Add(this.discCakeboxLabel);
			this.Controls.Add(this.discLabelLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EditDisc";
			this.ShowInTaskbar = false;
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ComboBox discCakebox;
		private System.Windows.Forms.TextBox discLabel;
		private System.Windows.Forms.Label discCakeboxLabel;
		private System.Windows.Forms.Label discLabelLabel;
	}
}
