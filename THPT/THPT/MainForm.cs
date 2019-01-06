/*
 * Created by SharpDevelop.
 * User: user
 * Date: 1/6/2019
 * Time: 3:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Linq;


namespace THPT
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsDocument document = new clsDocument();
		
		List<clsDocument> doclist = new List<clsDocument>();
		BindingList<clsDocument> bdoclist = new BindingList<clsDocument>();
		List<clsStudent> stulist = new List<clsStudent>();
		BindingList<clsStudent> bstulist = new BindingList<clsStudent>();
		BindingSource source;
		BindingSource source1;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bdoclist = new BindingList<clsDocument>(doclist);
			bstulist = new BindingList<clsStudent>(stulist);
			source = new BindingSource(bdoclist, null);
			source1 = new BindingSource(bstulist, null);
			dgshow.DataSource = source;
			dgDocument.DataSource = source1;
		}
		public void ClearData()
		{
			
			this.txtAge.Text = "";
			this.txtClass.Text = "";
			this.txtDob.Text = "";
			this.txtK.Text = "";
			this.txtName.Text = "";
			this.txtAge.Visible = false;
			this.cbAdd.Text = "";
		}
		
		
		void DgshowCurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				var row = source[dgshow.CurrentRowIndex];
				if(row != null)
				{
					var currentThiSinh = (clsDocument)row;
					ShowData(currentThiSinh);
				}
			}catch
			{
				
			}
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
			if(cbAdd.Text == "London" || cbAdd.Text == "Leeds" || cbAdd.Text == "Cardiff" || cbAdd.Text == "Manchester" || cbAdd.Text == "Bristol")
			{
				
			}
			else{
				ClearData();
			}
			if(txtName.Text == ""|| cbAdd.Text == "" || txtAge.Text == "" || txtClass.Text == "" || txtDob.Text == "" || txtK.Text == "")
			{
				ClearData();
			}
			else
			{
				if(rdbI.Checked == true)
				{
					document.Term = "I";
				}
				if(rdbII.Checked == true)
				{
					document.Term = "II";
				}
				if(rdbTemp.Checked == true)
				{
					document.Term = "Temp";
				}
				
				document.Student.Name = txtName.Text;
				document.Student.Year = int.Parse(txtDob.Text);
			//	document.Student.Add = txtAddress.Text;
				document.Student.Age = int.Parse(txtAge.Text);
				document.K = int.Parse(txtK.Text);
				document.Class = txtClass.Text;
				source1.Add(document.Student);
				source.Add(document);
				document = new clsDocument();
				ClearData();
				dgshow.Refresh();
			}
		}
		public void ShowData(clsDocument docu)
		{
			txtK.Text = docu.K.ToString();
			txtAge.Text = docu.Student.Age.ToString();
			txtClass.Text =docu.Class;
			txtDob.Text = docu.Student.Year.ToString();
			txtName.Text = docu.Student.Name;
			cbAdd.Text = docu.Student.Add;
		}
		void TxtAddressTextChanged(object sender, EventArgs e)
		{
			
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
				if(n > DateTime.Now.Year)
				{
					txtDob.Text = "";
					txtAge.Visible = false;
				}
				else
				{
					txtAge.Visible = true;
					txtAge.Text = (DateTime.Now.Year - n).ToString();
				}
			}catch
			{
				txtDob.Text = "";
				txtAge.Visible = false;
			}
		}
		
		void TxtNameTextChanged(object sender, EventArgs e)
		{
			string n = txtName.Text;
			if (n.Length >30)
			{
				MessageBox.Show("Please input not 30character");
				txtName.Text = "";
			}
		}
		
		void TxtClassTextChanged(object sender, EventArgs e)
		{
		
		}
		
		void TxtKTextChanged(object sender, EventArgs e)
		{
			int n;
			try{
				n = int.Parse(txtK.Text);
				
			}catch
			{
				txtK.Text = "";
			}
		}
		
		public void SetData(string a)
		{
			document.Student.Add = a;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			cbAdd.Items.Add("London");
			cbAdd.Items.Add("Leeds");
			cbAdd.Items.Add("Cardiff");
			cbAdd.Items.Add("Bristol");
			cbAdd.Items.Add("Manchester");
		}
		
		void CbAddTextChanged(object sender, EventArgs e)
		{
			string a = cbAdd.Text;
			SetData(a);
		}
		
		void CbAddSelectedIndexChanged(object sender, EventArgs e)
		{
			string a = cbAdd.Text;
			SetData(a);
		}
		
		void BtnSearchClick(object sender, EventArgs e)
		{
			int count =0; 
			for(int i = 0; i < stulist.Count; i++)
			{
				if(stulist[i].Year == 1985 && stulist[i].Add == "London")
					count++;
			}
			txtCount.Text = count.ToString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			List<clsStudent> born = new List<clsStudent>();
			
			foreach(var element in stulist)
			{
				if (element.Year == 1985)
				{
					born.Add(element);
				}
			}
			BindingList<clsStudent> bblist = new BindingList<clsStudent>();
			bblist = new BindingList<clsStudent>(born);
		
			source = new BindingSource(bblist, null);
			dgDocument.DataSource = source;
		}
		
		void DgDocumentCurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				var row = source[dgDocument.CurrentRowIndex];
				if(row != null)
				{
					var currentThiSinh = (clsDocument)row;
					ShowData(currentThiSinh);
				}
			}catch
			{
				
			}
		}
	}
}
