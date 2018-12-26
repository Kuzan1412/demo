/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/26/2018
 * Time: 9:32 AM
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
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;

namespace Town
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsHuman human = new clsHuman();
		clsTown town = new clsTown();
		List<clsHuman> hulist = new List<clsHuman>();
		List<clsTown> townlist = new List<clsTown>();
		BindingList<clsHuman> bhulist;
		BindingSource source;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bhulist = new BindingList<clsHuman>(hulist);
			source = new BindingSource(bhulist, null);
			dgshow.DataSource = source;
			
		}
		public bool IsAdrress(string a)
		{
			Regex regex = new Regex(@"[0-9]/[A-Za-z]");
			return regex.IsMatch(a);
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			if(bhulist.Count != 0)
			{
				for(int i = 0; i < bhulist.Count; i++)
				{
					if (txtHome.Text == bhulist[i].Home.ToString())
					{
						ClearData();
						MessageBox.Show("This Address has existed!// Please check!");
					}
				}
			}
			int count = 0;
			int n = int.Parse(txtNow.Text);
			if (txtAge.Text == "" || txtDob.Text == "" || txtName.Text =="" || txtMajor.Text == "" || IsAdrress(txtHome.Text) == false)
			{
				ClearData();
			}
			else 
			{
				txtNow.Text = txtMember.Text;
				human.Home = txtHome.Text;
				human.Member = int.Parse(txtMember.Text);
				human.Age = int.Parse(txtAge.Text);
				human.Name = txtName.Text;
				human.Year = int.Parse(txtDob.Text);
				human.Major = txtMajor.Text;
				source.Add(human);
				count++;
				human = new clsHuman();
				ClearData();
				dgshow.Refresh();
				if (count != n)
				{	txtMember.Visible = false;
					txtHome.Visible = false;
					gbInformation.Visible = true;
				}
				else
				{
					txtMember.Visible = true;
					txtHome.Visible = true;
				}
			}
			
		}
		public void ClearData()
		{
			this.txtAge.Text = "";
			this.txtDob.Text = "";
			this.txtHome.Text = "";
			this.txtMajor.Text = "";
			this.txtName.Text = "";
			this.txtMember.Text = "";
		}
		void TxtHomeTextChanged(object sender, System.EventArgs e)
		{
			
		
		}
		
		void TxtMemberTextChanged(object sender, System.EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtMember.Text);
				
				if(n < 1)
				{
					txtMember.Text = "";
				}
				
			}catch
			{
				txtMember.Text = "";
			}
			if(txtMember.Text != "")
			{
				txtNow.Text = txtMember.Text;
				gbInformation.Visible = true;
			}
			if(txtMember.Text == "")
				gbInformation.Visible = false;
		}
		
		void TxtDobTextChanged(object sender, System.EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtDob.Text);
				if(n < 0)
				{
					txtDob.Text = "";
				}
			}catch
			{
				txtDob.Text = "";
			}
		}
		
		void TxtAgeTextChanged(object sender, System.EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtAge.Text);
				if(n < 0)
				{
					txtAge.Text = "";
				}
			}catch
			{
				txtAge.Text = "";
			}
		}
		
		void DgshowCurrentCellChanged(object sender, System.EventArgs e)
		{
			try
			{
				var row = source[dgshow.CurrentRowIndex];
				if(row != null)
				{
					var current = (clsHuman)row;
					ShowData(current);
				}	
			}catch
			{
				
			}
		}
	
		
		void TxtNowTextChanged(object sender, EventArgs e)
		{
			txtNow.Text = txtMember.Text;
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			try
			{
				clsHuman current = (clsHuman)source[dgshow.CurrentRowIndex];
				source.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
		}
		public void ShowData(clsHuman chuman)
		{
			txtName.Text = chuman.Name;
			txtMember.Text = chuman.Member.ToString();
			txtMajor.Text = chuman.Major;
			txtHome.Text = chuman.Home;
			txtAge.Text = chuman.Age.ToString();
			txtDob.Text = chuman.Year.ToString();
		}
		void BtnEditClick(object sender, EventArgs e)
		{
			human.Home = txtHome.Text;
			human.Member = int.Parse(txtMember.Text);
			human.Age = int.Parse(txtAge.Text);
			human.Name = txtName.Text;
			human.Year = int.Parse(txtDob.Text);
			human.Major = txtMajor.Text;
			source[dgshow.CurrentRowIndex] = human;
			human = new clsHuman();
			ClearData();
			dgshow.Refresh();
		}
		
		void BtnLoadClick(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Json Files|*.json|All Files|*.*";
			if(open.ShowDialog() == DialogResult.OK)
			{
				string sFileName = open.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				StreamReader reader = new StreamReader(sFileName);
				string json = reader.ReadToEnd();
				reader.Close();
				var deserializeObject = serializer.Deserialize<List<clsHuman>>(json);
				source.Clear();
				foreach (var element in deserializeObject) {
					source.Add(element);
				}
				MessageBox.Show("Load OK !");
			}
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Json Files|*.json|All Files|*.*";
			if(save.ShowDialog() == DialogResult.OK)
			{
				string sFileName = save.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				var json = serializer.Serialize(hulist);
				StreamWriter writer ;
				writer = new StreamWriter(sFileName);
				writer.Write(json);
				writer.Close();
				MessageBox.Show("Saved !");
			}
		}
	}
}
