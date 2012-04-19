/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
namespace Cakebox_Archive
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
			this.selectDiscs = new System.Windows.Forms.GroupBox();
			this.selectDiscsToMove = new System.Windows.Forms.CheckedListBox();
			this.selectCakebox = new System.Windows.Forms.ComboBox();
			this.toggleButton = new System.Windows.Forms.Button();
			this.moveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.selectDiscs.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectDiscs
			// 
			resources.ApplyResources(this.selectDiscs, "selectDiscs");
			this.selectDiscs.Controls.Add(this.selectDiscsToMove);
			this.selectDiscs.Name = "selectDiscs";
			this.selectDiscs.TabStop = false;
			// 
			// selectDiscsToMove
			// 
			this.selectDiscsToMove.CheckOnClick = true;
			resources.ApplyResources(this.selectDiscsToMove, "selectDiscsToMove");
			this.selectDiscsToMove.FormattingEnabled = true;
			this.selectDiscsToMove.Name = "selectDiscsToMove";
			this.selectDiscsToMove.SelectedIndexChanged += new System.EventHandler(this.enableMoveButton);
			// 
			// selectCakebox
			// 
			resources.ApplyResources(this.selectCakebox, "selectCakebox");
			this.selectCakebox.DisplayMember = "Value";
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
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.closeForm);
			// 
			// MassMove
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.moveButton);
			this.Controls.Add(this.toggleButton);
			this.Controls.Add(this.selectCakebox);
			this.Controls.Add(this.selectDiscs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "MassMove";
			this.ShowInTaskbar = false;
			this.selectDiscs.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button moveButton;
		private System.Windows.Forms.Button toggleButton;
		private System.Windows.Forms.ComboBox selectCakebox;
		private System.Windows.Forms.CheckedListBox selectDiscsToMove;
		private System.Windows.Forms.GroupBox selectDiscs;
	}
}
