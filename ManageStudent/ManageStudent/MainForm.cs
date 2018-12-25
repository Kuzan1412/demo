/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/25/2018
 * Time: 6:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Web.Script.Serialization;
using System.IO;
namespace ManageStudent
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsA a = new clsA();
		clsB b = new clsB();
		clsC c = new clsC();
		List<clsA> A = new List<clsA>();
		List<clsB> B = new List<clsB>();
		List<clsC> C = new List<clsC>();
		
		BindingList<clsA> alist;
		BindingList<clsB> blist;
		BindingList<clsC> clist;
		BindingSource source;
		BindingSource source1;
		BindingSource source2;
		public MainForm()
		{
			
			InitializeComponent();
			alist = new BindingList<clsA>(A);
			source1 = new BindingSource(alist,null);
			blist = new BindingList<clsB>(B);
			source = new BindingSource(blist, null);
			clist = new BindingList<clsC>(C);
			source2 = new BindingSource(clist, null);
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void TxtNameTextChanged(object sender, EventArgs e)
		{
			string nname = txtName.Text;
			if(nname.Length > 30)
			{
				MessageBox.Show("Max length id = 30; Thanks");
				txtName.Text = "";
			}
		}
		
		void TxtIdTextChanged(object sender, EventArgs e)
		{
			int nid;
			try
			{
				nid = int.Parse(txtId.Text);
				if (nid < 0 || nid.ToString().Length > 5)
				{
					MessageBox.Show("Max length id = 5; Thanks");
					txtId.Text = "";
				}
				
			}catch
			{
				txtId.Text ="";
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
		
		void TxtPriorityTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtPriority.Text);
				if (n < 0 || n > 5)
				{
					txtPriority.Text = "";
				}
				
			}catch
			{
				txtPriority.Text ="";
			}
		}
		
		void RdbACheckedChanged(object sender, EventArgs e)
		{
			if(rdbA.Checked == true)
			{
				txtPhysicalB.Visible = false;
				txtGeoraphy.Visible = false;
				txtHistory.Visible = false;
				txtLiterature.Visible = false;
				txtBiology.Visible = false;
				txtChemistryB.Visible = false;
				txtMath.Visible = true;
				txtPhysicalA.Visible = true;
				txtChemistryA.Visible = true;
			}
		}
		
		void RdbBCheckedChanged(object sender, EventArgs e)
		{
			if(rdbB.Checked == true)
			{
				txtPhysicalA.Visible = false;
				txtGeoraphy.Visible = false;
				txtHistory.Visible = false;
				txtLiterature.Visible = false;
				txtMath.Visible = false;
				txtChemistryA.Visible = false;
				txtPhysicalB.Visible = true;
				txtBiology.Visible = true;
				txtChemistryB.Visible = true;
			}
		}
		
		void RdbCCheckedChanged(object sender, EventArgs e)
		{
			if(rdbC.Checked == true)
			{
				txtPhysicalB.Visible = false;
				txtPhysicalA.Visible = false;
				txtMath.Visible = false;
				txtChemistryA.Visible = false;
				txtBiology.Visible = false;
				txtChemistryB.Visible = false;
				txtHistory.Visible = true;
				txtGeoraphy.Visible = true;
				txtLiterature.Visible = true;
			}
		}
		public void ClearData()
		{
			this.txtPhysicalB.Text = "";
			this.txtPhysicalA.Text = "";
			this.txtMath.Text = "";
			this.txtChemistryA.Text = "";
			this.txtBiology.Text = "";
			this.txtChemistryB.Text = "";
			this.txtHistory.Text = "";
			this.txtGeoraphy.Text = "";
			this.txtLiterature.Text = "";
			this.txtName.Text = "";
			this.txtId.Text = "";
			this.txtPriority.Text = "";
			this.txtAddress.Text = "";
		}
		
		
		void BtnAddClick(object sender, EventArgs e)
		{
			for(int i = 0; i < A.Count; i++)
			{
				if(txtId.Text == A[i].Id.ToString())
					{
						MessageBox.Show("This id has used! // Please input valid ID. Thanks");
						ClearData();
					}
			}
			for(int i = 0; i < B.Count; i++)
			{
				if(txtId.Text == B[i].Id.ToString())
				{
					MessageBox.Show("This id has used! // Please input valid ID. Thanks");
					ClearData();
				}
			}
			for(int i = 0; i < C.Count; i++)
			{
				if(txtId.Text == C[i].Id.ToString())
				{
					MessageBox.Show("This id has used! // Please input valid ID. Thanks");
					ClearData();
				}
			}
			if (txtAddress.Text == "" || txtPriority.Text == "" || txtName.Text == "" || txtId.Text == "" || txtId.Text.Length != 5)
			{
				ClearData();
			}
			else
			{
				int scan = 0;
				
				if (rdbA.Checked == true)
				{
					scan = 1;
					
				}
				if (rdbB.Checked == true)
				{
					scan = 2;
					
				}
				if (rdbC.Checked == true)
				{
					scan = 3;
					
				}
				
				if (scan == 1 )
				{
					if(txtMath.Text == "" || txtPhysicalA.Text == "" || txtPhysicalA.Text == "")
					{
						ClearData();
					}
					else
					{
						dgshow.DataSource = source1;
						a.Name = txtName.Text; 
						a.Id = int.Parse(txtId.Text);
						a.Address = txtAddress.Text;
						a.Priority = int.Parse(txtPriority.Text);
						a.Markc = double.Parse(txtChemistryA.Text);
						a.Markm = double.Parse(txtMath.Text);
						a.Markp = double.Parse(txtPhysicalA.Text);	
						source1.Add(a);
						a = new clsA();
						ClearData();
						dgshow.Refresh();
					}
				}
				if (scan == 2 )
				{
					if(txtBiology.Text == "" || txtPhysicalB.Text == "" || txtChemistryB.Text == "")
					{
						ClearData();
					}
					else
					{
						dgshow.DataSource = source;
						b.Name = txtName.Text; 
						b.Id = int.Parse(txtId.Text);
						b.Address = txtAddress.Text;
						b.Priority = int.Parse(txtPriority.Text);
						b.Markb = double.Parse(txtBiology.Text);
						b.Markc = double.Parse(txtChemistryB.Text);
						b.Markp = double.Parse(txtPhysicalB.Text);	
						source.Add(b);
						b = new clsB();
						ClearData();
						dgshow.Refresh();
					}
				}
				if (scan == 3 )
				{
					if(txtHistory.Text == "" || txtGeoraphy.Text == "" || txtLiterature.Text == "")
					{
						ClearData();
					}
					else
					{
						dgshow.DataSource = source1;
						c.Name = txtName.Text; 
						c.Id = int.Parse(txtId.Text);
						c.Address = txtAddress.Text;
						c.Priority = int.Parse(txtPriority.Text);
						c.Markh = double.Parse(txtHistory.Text);
						c.Markg = double.Parse(txtGeoraphy.Text);
						c.Markl = double.Parse(txtLiterature.Text);	
						source2.Add(c);
						c = new clsC();
						ClearData();
						dgshow.Refresh();
					}
				}
			}
		
		}
		public void ShowData1(clsA blocka)
		{
			txtName.Text = blocka.Name;
			txtAddress.Text = blocka.Address;
			txtId.Text = blocka.Id.ToString();
			txtPriority.Text = blocka.Priority.ToString();
			txtMath.Text = blocka.Markm.ToString();
			txtPhysicalA.Text = blocka.Markp.ToString();
			txtChemistryA.Text = blocka.Markc.ToString();
		}
		public void ShowData2(clsC blockc)
		{
			txtName.Text = blockc.Name;
			txtAddress.Text = blockc.Address;
			txtId.Text = blockc.Id.ToString();
			txtPriority.Text = blockc.Priority.ToString();
			txtLiterature.Text = blockc.Markl.ToString();
			txtHistory.Text = blockc.Markh.ToString();
			txtGeoraphy.Text = blockc.Markg.ToString();
		}
		public void ShowData(clsB blockb)
		{
			txtName.Text = blockb.Name;
			txtAddress.Text = blockb.Address;
			txtId.Text = blockb.Id.ToString();
			txtPriority.Text = blockb.Priority.ToString();
			txtPhysicalB.Text = blockb.Markp.ToString();
			txtChemistryB.Text = blockb.Markc.ToString();
			txtBiology.Text = blockb.Markb.ToString();
		}
		void DgshowCurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				var row = source[dgshow.CurrentRowIndex];
				if(row != null)
				{
					var current = (clsB)row;
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
					var current1 = (clsA)row1;
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
					var current2 = (clsC)row2;
					ShowData2(current2);
				}
			}catch
			{
				
			}
		}
		
		void TxtMathTextChanged(object sender, EventArgs e)
		{
			double n;
			try
			{
				n = double.Parse(txtMath.Text);
				if (n < 0 || n > 10)
				{
					txtMath.Text = "";
				}
			}catch
			{
				txtMath.Text = "";
			}
		}
		
		void TxtPhysicalATextChanged(object sender, EventArgs e)
		{
			double n;
			try
			{
				n = double.Parse(txtPhysicalA.Text);
				if (n < 0 || n > 10)
				{
					txtPhysicalA.Text = "";
				}
			}catch
			{
				txtPhysicalA.Text = "";
			}
		}
		
		void TxtChemistryATextChanged(object sender, EventArgs e)
		{
			double n;
			try
			{
				n = double.Parse(txtChemistryA.Text);
				if (n < 0 || n > 10)
				{
					txtChemistryA.Text = "";
				}
			}catch
			{
				txtChemistryA.Text = "";
			}
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			try
			{
				clsB current = (clsB)source[dgshow.CurrentRowIndex];
				source.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
			try
			{
				clsA current1 = (clsA)source1[dgshow.CurrentRowIndex];
				source1.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
			try
			{
				clsC current2 = (clsC)source2[dgshow.CurrentRowIndex];
				source2.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
			
		}
		
		void BtnSearchClick(object sender, EventArgs e)
		{
			
			if(A.Count != 0 || B.Count != 0 || C.Count != 0)
			{
				for(int i = 0; i < A.Count; i++)
				{
					if(txtSearch.Text == A[i].Id.ToString())
						dgshow.DataSource= source1;
						
				}
				for(int i = 0; i < B.Count; i++)
				{
					if(txtSearch.Text == B[i].Id.ToString())
						dgshow.DataSource= source;
						
				}
				for(int i = 0; i < C.Count; i++)
				{
					if(txtSearch.Text == C[i].Id.ToString())
						dgshow.DataSource= source2;
						
				}
			}
		}
		
		void TxtBiologyTextChanged(object sender, EventArgs e)
		{
			double n;
			try
			{
				n = double.Parse(txtBiology.Text);
				if (n < 0 || n > 10)
				{
					txtBiology.Text = "";
				}
			}catch
			{
				txtBiology.Text = "";
			}
		}
		
		void TxtChemistryBTextChanged(object sender, EventArgs e)
		{
			double n;
			try
			{
				n = double.Parse(txtChemistryB.Text);
				if (n < 0 || n > 10)
				{
					txtChemistryB.Text = "";
				}
			}catch
			{
				txtChemistryB.Text = "";
			}
		}
		
		void TxtPhysicalBTextChanged(object sender, EventArgs e)
		{
			double n;
			try
			{
				n = double.Parse(txtPhysicalB.Text);
				if (n < 0 || n > 10)
				{
					txtPhysicalB.Text = "";
				}
			}catch
			{
				txtPhysicalB.Text = "";
			}
		}
		
		void TxtGeoraphyTextChanged(object sender, EventArgs e)
		{
			double n;
			try
			{
				n = double.Parse(txtGeoraphy.Text);
				if (n < 0 || n > 10)
				{
					txtGeoraphy.Text = "";
				}
			}catch
			{
				txtGeoraphy.Text = "";
			}
		}
		
		void TxtHistoryTextChanged(object sender, EventArgs e)
		{
			double n;
			try
			{
				n = double.Parse(txtHistory.Text);
				if (n < 0 || n > 10)
				{
					txtHistory.Text = "";
				}
			}catch
			{
				txtHistory.Text = "";
			}
		}
		
		void TxtLiteratureTextChanged(object sender, EventArgs e)
		{
			double n;
			try
			{
				n = double.Parse(txtLiterature.Text);
				if (n < 0 || n > 10)
				{
					txtLiterature.Text = "";
				}
			}catch
			{
				txtLiterature.Text = "";
			}
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Json Files|*.json|All Files|*.*";
			if(rdbA.Checked == true)
			{
				if(save.ShowDialog() == DialogResult.OK)
				{
					string sFileName = save.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					var json = serializer.Serialize(alist);
					StreamWriter writer ;
					writer = new StreamWriter(sFileName);
					writer.Write(json);
					writer.Close();
					MessageBox.Show("Saved !");
				}
			}
			if(rdbB.Checked == true)
			{
				if(save.ShowDialog() == DialogResult.OK)
				{
					string sFileName = save.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					var json = serializer.Serialize(blist);
					StreamWriter writer ;
					writer = new StreamWriter(sFileName);
					writer.Write(json);
					writer.Close();
					MessageBox.Show("Saved !");
				}
			}
			if(rdbC.Checked == true)
			{
				if(save.ShowDialog() == DialogResult.OK)
				{
					string sFileName = save.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					var json = serializer.Serialize(clist);
					StreamWriter writer ;
					writer = new StreamWriter(sFileName);
					writer.Write(json);
					writer.Close();
					MessageBox.Show("Saved !");
				}
			}
		}
		
		void BtnLoadClick(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Json Files|*.json|All Files|*.*";
			if(rdbA.Checked == true)
			{
				if(open.ShowDialog() == DialogResult.OK)
				{
					string sFileName = open.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					StreamReader reader = new StreamReader(sFileName);
					string json = reader.ReadToEnd();
					reader.Close();
					var deserializeObject = serializer.Deserialize<List<clsA>>(json);
					source.Clear();
					foreach (var element in deserializeObject) {
						source.Add(element);
					}
					MessageBox.Show("Load OK !");
				}
			}
			if(rdbB.Checked == true)
			{
				if(open.ShowDialog() == DialogResult.OK)
				{
					string sFileName = open.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					StreamReader reader = new StreamReader(sFileName);
					string json = reader.ReadToEnd();
					reader.Close();
					var deserializeObject = serializer.Deserialize<List<clsB>>(json);
					source.Clear();
					foreach (var element in deserializeObject) {
						source.Add(element);
					}
					MessageBox.Show("Load OK !");
				}
			}
			if(rdbC.Checked == true)
			{
				if(open.ShowDialog() == DialogResult.OK)
				{
					string sFileName = open.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					StreamReader reader = new StreamReader(sFileName);
					string json = reader.ReadToEnd();
					reader.Close();
					var deserializeObject = serializer.Deserialize<List<clsC>>(json);
					source.Clear();
					foreach (var element in deserializeObject) {
						source.Add(element);
					}
					MessageBox.Show("Load OK !");
				}
			}
		}
	}
}
