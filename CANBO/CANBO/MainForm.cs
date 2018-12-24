/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/10/2018
 * Time: 10:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.IO;

namespace CANBO
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsCANBO cb = new clsCANBO();
		clsEngineer en = new clsEngineer();
		clsWaiter wai = new clsWaiter();
		clsWoker work = new clsWoker();
		List<clsWoker> worker = new List<clsWoker>();
		List<clsWaiter> waiter = new List<clsWaiter>();
		List<clsEngineer> engine = new List<clsEngineer>();
		List<clsCANBO> canbo = new List<clsCANBO>();
		BindingList<clsEngineer> enlist;
		BindingList<clsWoker> worklist;
		BindingList<clsWaiter> wailist;
		BindingSource source;
		BindingSource source1;
		BindingSource source2;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			enlist = new BindingList<clsEngineer>(engine);
			source1 = new BindingSource(enlist,null);
			worklist = new BindingList<clsWoker>(worker);
			source = new BindingSource(worklist, null);
			wailist = new BindingList<clsWaiter>(waiter);
			source2 = new BindingSource(wailist, null);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		public void ClearData()
		{
			this.txtName.Text = "";
			this.txtMisson.Text = "";
			this.txtMajor.Text = "";
			this.txtAddress.Text = "";
			this.txtDob.Text = "";
			this.txtLv.Text = "";
		}
		void TxtNameTextChanged(object sender, EventArgs e)
		{
			string nname = txtName.Text;
			if (nname.Length > 30)
			{
				txtName.Text = "";
			}
		}
		
		void TxtAddressTextChanged(object sender, EventArgs e)
		{
			string nadd = txtAddress.Text;
			if (nadd.Length > 50)
			{
				txtAddress.Text = "";
			}
		}
		
		void TxtDobTextChanged(object sender, EventArgs e)
		{
			
			int nyear;
			try
			{
				nyear = int.Parse(txtDob.Text);
				if (nyear > 2010)
				{
					txtDob.Text = "";
				}
			}
			catch
			{
				txtDob.Text = "";
			}
			
		}
		void TxtMissonTextChanged(object sender, EventArgs e)
		{
			string nmiss = txtMisson.Text;
			if (nmiss.Length > 5)
			{
				txtMisson.Text = "";
			}
		}
		
		void TxtMajorTextChanged(object sender, EventArgs e)
		{
			string nmajor = txtMajor.Text;
			if (nmajor.Length > 30)
			{
				txtMajor.Text = "";
			}
		}
		
		void TxtLvTextChanged(object sender, EventArgs e)
		{
			string nlv = txtLv.Text; 
			if (nlv.Length > 30)
			{
				txtLv.Text = "";
			}
		}
		
		void ClearClick(object sender, EventArgs e)
		{
			ClearData();
		}
		
		
		void BtnAddClick(object sender, EventArgs e)
		{
		
			
			if (txtAddress.Text == "" || txtDob.Text == "" || txtName.Text == "" || int.Parse(txtDob.Text) < 1950)
			{
				ClearData();
			}
			else
			{
				int check = 0, scan = 0;
				
				if (rdbEngine.Checked == true)
				{
					scan = 1;
					txtLv.Text = "";
					txtMisson.Text = "";
				}
				if (rdbWaiter.Checked == true)
				{
					scan = 2;
					txtMajor.Text = "";
					txtLv.Text = "";
				}
				if (rdbWorker.Checked == true)
				{
					scan = 3;
					txtMajor.Text = "";
					txtMisson.Text = "";
				}
				if (rdbGirl.Checked == true)
				{
					check = 1;
				}
				if (rdbBoy.Checked == true)
				{
					check = 0;
				}
				
				if (scan == 1 )
				{
					dgshow.DataSource = source1;
					en.nname = txtName.Text; 
					en.naddress = txtAddress.Text;
					en.nmajor = txtMajor.Text;
					en.ndob = int.Parse(txtDob.Text);
					if (check == 1)
					{
						en.nsex = "Girl";
					}
					else
					{
						en.nsex = "Boys";
					}
					source1.Add(en);
					en = new clsEngineer();
					ClearData();
					dgshow.Refresh();
				}
				if (scan == 3 )
				{
					dgshow.DataSource = source;
					work.nname = txtName.Text; 
					work.ndob = int.Parse(txtDob.Text);
					work.naddress = txtAddress.Text;
					work.nlv = txtLv.Text;
					if (check == 1)
					{
						work.nsex = "Girl";
					}
					else
					{
						work.nsex = "Boys";
					}
					source.Add(work);
					work = new clsWoker();
					ClearData();
					dgshow.Refresh();
				}
				if (scan == 2 )
				{
					dgshow.DataSource = source2;
					wai.nname = txtName.Text; 
					wai.naddress = txtAddress.Text;
					wai.nwork = txtMisson.Text;
					wai.ndob = int.Parse(txtDob.Text);
					if (check == 1)
					{
						wai.nsex = "Girl";
					}
					else
					{
						wai.nsex = "Boys";
					}
					source2.Add(wai);
					wai = new clsWaiter();
					ClearData();
					dgshow.Refresh();
				}
			}
		}
		public void ShowData(clsWoker work)
		{
			txtName.Text = work.nname;
			txtAddress.Text = work.naddress;
			txtDob.Text = work.ndob.ToString();
			txtLv.Text = work.nlv;
		}
		public void ShowData1(clsEngineer engin)
		{
			txtName.Text = engin.nname;
			txtAddress.Text = engin.naddress;
			txtDob.Text = engin.ndob.ToString();
			txtMajor.Text = engin.nmajor;
		}
		public void ShowData2(clsWaiter wait)
		{
			txtName.Text = wait.nname;
			txtAddress.Text = wait.naddress;
			txtDob.Text = wait.ndob.ToString();
			txtMisson.Text = wait.nwork;
		}
		void DgshowCurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				var row = source[dgshow.CurrentRowIndex];
				if(row != null)
				{
					var current = (clsWoker)row;
					ShowData(current);
				}	
			}catch
			{
				
			}
			try
			{
				var row1 = source1[dgshow.CurrentRowIndex];
				if(row1 != null)
				{
					var current1 = (clsEngineer)row1;
					ShowData1(current1);
				}
			}catch
			{
				
			}
			try
			{
				var row2 = source2[dgshow.CurrentRowIndex];
				if(row2 != null)
				{
					var current2 = (clsWaiter)row2;
					ShowData2(current2);
				}
			}catch
			{
				
			}
		}
		
		void BtnEditClick(object sender, EventArgs e)
		{
			int check = 0, scan = 0;
			if(rdbWorker.Checked == true)
				scan = 1;
			if (rdbWaiter.Checked == true)
			{
				scan = 2;		
			}
			if(rdbEngine.Checked == true)
					scan = 3;
			
			if(txtName.Text == "" || txtDob.Text == "" || txtAddress.Text == "" || scan > 4 || scan <0)
			{
				ClearData();
			}
			else
			{
				if (rdbGirl.Checked == true)
				{
					check = 1;
				}
				if (rdbBoy.Checked == true)
				{
					check = 0;
				}
				work.nname = txtName.Text; 
				work.ndob = int.Parse(txtDob.Text);
				work.naddress = txtAddress.Text;
				work.nlv = txtLv.Text;
				if (check == 1)
				{
					work.nsex = "Girl";
				}
				else
				{
					work.nsex = "Boys";
				}
				source[dgshow.CurrentRowIndex] = work;
				ClearData();
			}
			
			//source.Add(thisinh);
			
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			try
			{
				clsWoker current = (clsWoker)source[dgshow.CurrentRowIndex];
				source.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
			try
			{
				clsEngineer current1 = (clsEngineer)source1[dgshow.CurrentRowIndex];
				source1.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
			try
			{
				clsWaiter current2 = (clsWaiter)source2[dgshow.CurrentRowIndex];
				source2.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
			
		}
	}
}
