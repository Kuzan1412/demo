/*
 * Created by SharpDevelop.
 * User: user
 * Date: 1/3/2019
 * Time: 8:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;


namespace Hotel
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsPeople people = new clsPeople();
		List<clsPeople> peolist = new List<clsPeople>();
		BindingList<clsPeople> bpeolist = new BindingList<clsPeople>();
		BindingSource source;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bpeolist = new BindingList<clsPeople>(peolist);
			source = new BindingSource(bpeolist, null);
			dgshow.DataSource = source;
		}
		
		
		public void ClearData()
		{
			this.txtTime.Text = "";
			this.txtName.Text = "";
			this.txtID.Text = "";
			this.txtDob.Text = "";
			this.txtCost.Text = "";
			this.txtAge.Text = "";
			txtAge.Visible = false;
			txtCost.Visible =false;
			rdbM.Checked = false;
			rdbLarge.Checked = false;
			rdbS.Checked = false;
		}
		void TxtNameTextChanged(object sender, EventArgs e)
		{
			if (txtName.Text.Length > 30)
			{
				MessageBox.Show("Please input 30 character in Your'name.", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
						
		}
		
		void TxtAgeTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtDobTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtDob.Text);
			
				if(txtDob.Text != "")
				{
					txtAge.Visible = true;
					txtAge.Text = (DateTime.Now.Year - int.Parse(txtDob.Text)).ToString();
				}
				if (txtDob.Text == "" || n > DateTime.Now.Year)
				{
					//txtDob.Text = "";
					txtAge.Visible = false;
				}
			}catch
			{
				txtDob.Text = "";
			}
		}
		
		void TxtIDTextChanged(object sender, EventArgs e)
		{
			
			int n;
			try
			{
				n = int.Parse(txtID.Text);
			}catch
			{
				txtID.Text = "";
			}
		}
		
		void TxtTimeTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtTime.Text);
				if(n < 0)
				{
					txtTime.Text = "";
				}
			}catch
			{
				txtTime.Text = "";
			}
		}
		
		void BtnAcceptClick(object sender, EventArgs e)
		{
			int l = txtCost.Text.Length - 1;
			for (int i = 0; i < peolist.Count; i++)
			{
				if(txtID.Text == peolist[i].ID.ToString())
				{
					ClearData();
					MessageBox.Show("That ID has used.");
				}
			}
			if(txtAge.Text == "" || txtCost.Text == "" || txtDob.Text == "" || txtID.Text == "" || txtName.Text == "" || txtTime.Text == "" || txtID.Text.Length != 5)
			{
				ClearData();
			}
			else
			{
				
			
				people.Name = txtName.Text;
				people.ID = int.Parse(txtID.Text);
				people.Age = int.Parse(txtAge.Text);
				people.Stay = int.Parse(txtTime.Text);
				people.Date = int.Parse(txtDob.Text);
				people.Cost = int.Parse(txtCost.Text.Remove(l,1));
				source.Add(people);
				people = new clsPeople();
				
				ClearData();
				dgshow.Refresh();
			}
		}
		public void Caculator(string a, string b)
		{
			int time = int.Parse(a);
			int cost = time * int.Parse(b);
			txtCost.Text = cost.ToString() + "$";
		}
		void RdbSCheckedChanged(object sender, EventArgs e)
		{
			
			if (rdbS.Checked == true && txtTime.Text != "")
			{
				people.Type = "Small";
				txtCost.Visible = true;
				Caculator(txtTime.Text, "30");
				
			}
			
		}
		
		void RdbMCheckedChanged(object sender, EventArgs e)
		{
			if (rdbM.Checked == true  && txtTime.Text != "")
			{
				people.Type = "Medium";
				txtCost.Visible = true;
				Caculator(txtTime.Text, "50");
				
			}
		}
		
		void RdbLargeCheckedChanged(object sender, EventArgs e)
		{
			if(rdbLarge.Checked == true  && txtTime.Text != "")
			{
				people.Type = "Large";
				txtCost.Visible = true;
				Caculator(txtTime.Text, "70");
				
			}
		}
		
		void BtnEditClick(object sender, EventArgs e)
		{
			people.Name = txtName.Text;
			people.ID = int.Parse(txtID.Text);
			//people.Age = int.Parse(txtAge.Text);
			people.Stay = int.Parse(txtTime.Text);
			people.Date = int.Parse(txtDob.Text);
			//people.Cost = int.Parse(txtCost.Text);
			source[dgshow.CurrentRowIndex] = people;
			
			people = new clsPeople();
			ClearData();
			dgshow.Refresh();
		}
		
		void DgshowNavigate(object sender, NavigateEventArgs ne)
		{
			
		}
		void ShowData(clsPeople peo)
		{
			txtID.Text = peo.ID.ToString();
			txtDob.Text = peo.Date.ToString();
			txtName.Text = peo.Name;
			txtCost.Text = peo.Cost.ToString() + "$";
			txtAge.Text = peo.Age.ToString();
			txtTime.Text = peo.Stay.ToString();
			if(peo.Type == "Medium")
			{
				rdbM.Checked = true;
			}
			if (peo.Type == "Large")
			{
				rdbLarge.Checked = true;
			}
			if(peo.Type == "Small")
			{
				rdbS.Checked = true;
			}
		}
		void DgshowCurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				var row = source[dgshow.CurrentRowIndex];
				if(row != null)
				{
					var currentThiSinh = (clsPeople)row;
					ShowData(currentThiSinh);
				}
			}catch
			{
				
			}
		}
	}
}
