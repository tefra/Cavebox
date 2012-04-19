/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cavebox
{
	/// <summary>
	/// Description of MassMove.
	/// </summary>
	public partial class MassMove : Form
	{
		MainForm app;
		Boolean checkFlag = false;
		int source;
		
		public MassMove(MainForm form, int cid)
		{
			InitializeComponent();
			app = form;
			source = cid;
			selectDiscs.DisplayMember = "Value";
			selectDiscs.ValueMember = "Id";
			selectDiscs.DataSource = app.discsListBox.DataSource;
			selectCakebox.DataSource = app.newDiscCakebox.DataSource;
			selectCakebox.SelectedValue = source;
		}
		
		private int getTargetCakeboxId()
		{
			return Convert.ToInt32(selectCakebox.SelectedValue.ToString());
		}
		
		private void ToggleButtonClick(object sender, EventArgs e)
		{
			checkFlag = !checkFlag;
			for(int i = 0; i < selectDiscs.Items.Count; i++)
			{
				selectDiscs.SetItemChecked(i, checkFlag);
			}
			enableMoveButton(sender, e);
		}
		
		private void closeForm(object sender, EventArgs e)
		{
			Dispose();
		}
		
		private void MoveButtonClick(object sender, EventArgs e)
		{
			int target = getTargetCakeboxId();
			if(target != source && selectDiscs.CheckedItems.Count > 0)
			{
				Console.WriteLine("Moving discs to: " + selectCakebox.SelectedText);
				List<int> discs = new List<int>();
				foreach(object itemChecked in selectDiscs.CheckedItems)
				{
					Index item = (Index) itemChecked;
					discs.Add(item.Id);
					Console.WriteLine(item.Value);
				}
				Model.Instance.moveDiscs(target, discs);
				app.showCakeboxes();
				closeForm(sender, e);
			}
		}
		
		private void enableMoveButton(object sender, EventArgs e)
		{
			moveButton.Enabled = (selectDiscs.CheckedItems.Count > 0 && getTargetCakeboxId() != source);
		}
	}
}
