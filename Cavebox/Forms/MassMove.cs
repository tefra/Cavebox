/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cavebox.Lib;

namespace Cavebox.Forms
{
	/// <summary>
	/// Mass move discs from one cakebox to another
	/// </summary>
	public partial class MassMove : Form
	{
		Boolean checkFlag = false;
		int source;
		
		/// <summary>
		/// Initialize components and their values
		/// </summary>
		/// <param name="source">Source Cakebox id number</param>
		/// <param name="cakeboxes">Discs Identity List</param>
		/// <param name="cakeboxes">Cakeboxes Identity List</param>
		public MassMove(int source, object discs, object cakeboxes)
		{
			InitializeComponent();
			selectDiscs.DataSource = discs;
			selectCakebox.DataSource = cakeboxes;
			selectCakebox.SelectedValue = this.source = source;
		}
		
		/// <summary>
		/// Displose form
		/// </summary>
		private void closeForm(object sender, EventArgs e)
		{
			Dispose();
		}
		
		/// <summary>
		/// Move selected discs to selected cakebox
		/// </summary>
		private void MoveButtonClick(object sender, EventArgs e)
		{
			int target = selectCakebox.SelectedValue.ToInt();
			if(target != source && selectDiscs.CheckedItems.Count > 0)
			{
				this.UseWaitCursor = true;
				Console.WriteLine(Lang.GetString("_movingDiscs", selectCakebox.SelectedItem));
				List<int> discs = new List<int>();
				foreach(object itemChecked in selectDiscs.CheckedItems)
				{
					Identity item = (Identity) itemChecked;
					discs.Add(item.Key);
					Console.Write(item.Value + "\n");
				}
				Model.MoveDiscs(target, discs);
				closeForm(sender, e);
			}
		}
		
		/// <summary>
		/// Enable the move button when we have something to move
		/// </summary>
		private void enableMoveButton(object sender, EventArgs e)
		{
			moveButton.Enabled = (selectDiscs.CheckedItems.Count > 0 && selectCakebox.SelectedValue.ToInt() != source);
		}
				
		/// <summary>
		/// Select/Deselect all items
		/// </summary>
		private void ToggleButtonClick(object sender, EventArgs e)
		{
			checkFlag = !checkFlag;
			for(int i = 0; i < selectDiscs.Items.Count; i++)
			{
				selectDiscs.SetItemChecked(i, checkFlag);
			}
			string tmp = checkAll.Text;
			checkAll.Text = checkAll.Tag.ToString();
			checkAll.Tag = tmp;
			enableMoveButton(sender, e);
		}
	}
}