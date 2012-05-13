/**
 * @version	$Id$
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
			this.selectDiscsGroupBox = new System.Windows.Forms.GroupBox();
			this.selectDiscs = new System.Windows.Forms.CheckedListBox();
			this.selectCakebox = new System.Windows.Forms.ComboBox();
			this.moveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.checkAll = new System.Windows.Forms.CheckBox();
			this.selectDiscsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectDiscsGroupBox
			// 
			this.selectDiscsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.selectDiscsGroupBox.Controls.Add(this.selectDiscs);
			this.selectDiscsGroupBox.Location = new System.Drawing.Point(12, 12);
			this.selectDiscsGroupBox.Name = "selectDiscsGroupBox";
			this.selectDiscsGroupBox.Size = new System.Drawing.Size(290, 266);
			this.selectDiscsGroupBox.TabIndex = 0;
			this.selectDiscsGroupBox.TabStop = false;
			this.selectDiscsGroupBox.Text = "Select Discs";
			// 
			// selectDiscs
			// 
			this.selectDiscs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.selectDiscs.CheckOnClick = true;
			this.selectDiscs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.selectDiscs.FormattingEnabled = true;
			this.selectDiscs.Location = new System.Drawing.Point(3, 16);
			this.selectDiscs.Name = "selectDiscs";
			this.selectDiscs.Size = new System.Drawing.Size(284, 247);
			this.selectDiscs.TabIndex = 0;
			this.selectDiscs.SelectedIndexChanged += new System.EventHandler(this.enableMoveButton);
			// 
			// selectCakebox
			// 
			this.selectCakebox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.selectCakebox.DisplayMember = "Value";
			this.selectCakebox.DropDownHeight = 150;
			this.selectCakebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectCakebox.IntegralHeight = false;
			this.selectCakebox.Location = new System.Drawing.Point(12, 284);
			this.selectCakebox.Name = "selectCakebox";
			this.selectCakebox.Size = new System.Drawing.Size(290, 21);
			this.selectCakebox.TabIndex = 1;
			this.selectCakebox.ValueMember = "Key";
			this.selectCakebox.SelectedIndexChanged += new System.EventHandler(this.enableMoveButton);
			// 
			// moveButton
			// 
			this.moveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.moveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.moveButton.Location = new System.Drawing.Point(146, 311);
			this.moveButton.Name = "moveButton";
			this.moveButton.Size = new System.Drawing.Size(75, 23);
			this.moveButton.TabIndex = 3;
			this.moveButton.Text = "Move";
			this.moveButton.Click += new System.EventHandler(this.MoveButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(227, 311);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += new System.EventHandler(this.closeForm);
			// 
			// checkAll
			// 
			this.checkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkAll.AutoSize = true;
			this.checkAll.Location = new System.Drawing.Point(12, 314);
			this.checkAll.Name = "checkAll";
			this.checkAll.Size = new System.Drawing.Size(71, 17);
			this.checkAll.TabIndex = 5;
			this.checkAll.Tag = "Uncheck All";
			this.checkAll.Text = "Check All";
			this.checkAll.Click += new System.EventHandler(this.ToggleButtonClick);
			// 
			// MassMove
			// 
			this.AcceptButton = this.moveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(314, 346);
			this.Controls.Add(this.checkAll);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.moveButton);
			this.Controls.Add(this.selectCakebox);
			this.Controls.Add(this.selectDiscsGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MassMove";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mass Move";
			this.selectDiscsGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox checkAll;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button moveButton;
		private System.Windows.Forms.ComboBox selectCakebox;
		private System.Windows.Forms.CheckedListBox selectDiscs;
		private System.Windows.Forms.GroupBox selectDiscsGroupBox;
	}
}
