/**
 * @version	$Id: MassMoveForm.Designer.cs 57 2012-04-20 18:19:01Z Tefra $
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
namespace Cavebox.Forms
{
	partial class MassMove
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MassMove));
			this.selectDiscsGroupBox = new System.Windows.Forms.GroupBox();
			this.selectDiscs = new System.Windows.Forms.CheckedListBox();
			this.selectCakebox = new System.Windows.Forms.ComboBox();
			this.toggleButton = new System.Windows.Forms.Button();
			this.moveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.selectDiscsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectDiscsGroupBox
			// 
			resources.ApplyResources(this.selectDiscsGroupBox, "selectDiscsGroupBox");
			this.selectDiscsGroupBox.Controls.Add(this.selectDiscs);
			this.selectDiscsGroupBox.Name = "selectDiscsGroupBox";
			this.selectDiscsGroupBox.TabStop = false;
			// 
			// selectDiscs
			// 
			this.selectDiscs.CheckOnClick = true;
			resources.ApplyResources(this.selectDiscs, "selectDiscs");
			this.selectDiscs.FormattingEnabled = true;
			this.selectDiscs.Name = "selectDiscs";
			this.selectDiscs.SelectedIndexChanged += new System.EventHandler(this.enableMoveButton);
			// 
			// selectCakebox
			// 
			resources.ApplyResources(this.selectCakebox, "selectCakebox");
			this.selectCakebox.DisplayMember = "Value";
			this.selectCakebox.DropDownHeight = 150;
			this.selectCakebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectCakebox.FormattingEnabled = true;
			this.selectCakebox.Name = "selectCakebox";
			this.selectCakebox.ValueMember = "Id";
			this.selectCakebox.SelectedIndexChanged += new System.EventHandler(this.enableMoveButton);
			// 
			// toggleButton
			// 
			resources.ApplyResources(this.toggleButton, "toggleButton");
			this.toggleButton.Name = "toggleButton";
			this.toggleButton.UseVisualStyleBackColor = true;
			this.toggleButton.Click += new System.EventHandler(this.ToggleButtonClick);
			// 
			// moveButton
			// 
			resources.ApplyResources(this.moveButton, "moveButton");
			this.moveButton.Name = "moveButton";
			this.moveButton.UseVisualStyleBackColor = true;
			this.moveButton.Click += new System.EventHandler(this.MoveButtonClick);
			// 
			// cancelButton
			// 
			resources.ApplyResources(this.cancelButton, "cancelButton");
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.closeForm);
			// 
			// MassMove
			// 
			this.AcceptButton = this.moveButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.moveButton);
			this.Controls.Add(this.toggleButton);
			this.Controls.Add(this.selectCakebox);
			this.Controls.Add(this.selectDiscsGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "MassMove";
			this.ShowInTaskbar = false;
			this.selectDiscsGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button moveButton;
		private System.Windows.Forms.Button toggleButton;
		private System.Windows.Forms.ComboBox selectCakebox;
		private System.Windows.Forms.CheckedListBox selectDiscs;
		private System.Windows.Forms.GroupBox selectDiscsGroupBox;
	}
}
