/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/19/2018
 * Time: 11:24 PM
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


namespace Library
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		clsMagazine maga = new clsMagazine();
		clsNews newspa = new clsNews();
		clsBook book = new clsBook();
		List<clsBook> Book = new List<clsBook>();
		List<clsMagazine> Magazine = new List<clsMagazine>();
		List<clsNews> News = new List<clsNews>();
		//===================================== creat all the list which is used.
		BindingList<clsBook> booklist;
		BindingList<clsNews> newslist;
		BindingList<clsMagazine> magazlist;
		BindingSource source;
		BindingSource source1;
		BindingSource source2;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			booklist = new BindingList<clsBook>(Book);
			source = new BindingSource(booklist,null);
			newslist = new BindingList<clsNews>(News);
			source1 = new BindingSource(newslist, null);
			magazlist = new BindingList<clsMagazine>(Magazine);
			source2 = new BindingSource(magazlist, null);
		}
		
		void RdbMagazineCheckedChanged(object sender, EventArgs e)
		{
			if(rdbMagazine.Checked == true)
			{
				txtNumber.Visible = true;
				txtMonth.Visible = true;
				txtDate.Visible  = false;
				txtPoet.Visible = false;
				txtPage.Visible = false;
							
			}
		}
		
		void RdbBookCheckedChanged(object sender, EventArgs e)
		{
			if(rdbBook.Checked == true)
			{
				txtNumber.Visible = false;
				txtMonth.Visible = false;
				txtDate.Visible  = false;
				txtPoet.Visible = true;
				txtPage.Visible = true;
							
			}
		}
		
		void RdbNewspaperCheckedChanged(object sender, EventArgs e)
		{
			if(rdbNewspaper.Checked == true)
			{
				txtNumber.Visible = false;
				txtMonth.Visible = false;
				txtDate.Visible  = true;
				txtPoet.Visible = false;
				txtPage.Visible = false;
							
			}
		}
		public void ClearData()
		{
			this.txtId.Text = "";
			this.txtDate.Text = "";
			this.txtName.Text = "";
			this.txtPage.Text = "";
			this.txtNumber.Text = "";
			this.txtPoet.Text = "";
			this.txtQuatity.Text = "";
			this.txtMonth.Text = "";
		}
		
		void TxtNumberTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtNumber.Text);
				if(n < 0 )
				{
					MessageBox.Show("Please input a valid number.", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtNumber.Text = "";
				}
			}catch
			{
				
				txtNumber.Text = "";
			}
		}
		
		void TxtYearTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtMonth.Text);
				if(n < 1 || n > 12)
				{
					MessageBox.Show("Please input a valid number.", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtMonth.Text = "";
				}
			}catch
			{
				txtMonth.Text = "";
			}
		}
		
		void TxtPageTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtPage.Text);
				if(n < 0)
				{
					MessageBox.Show("Please input a valid number.", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtPage.Text = "";
				}
			}catch
			{
				
				txtPage.Text = "";
			}
		}
		
		void TxtDateTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtDate.Text);
				if(n < 1 || n > 31)
				{
					MessageBox.Show("Please input a valid number.", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtDate.Text = "";
				}
			}catch
			{
				
				txtDate.Text = "";
			}
		}
		
		void TxtNameTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtIdTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtId.Text);
				if(n.ToString().Length > 5)
				{
					MessageBox.Show("Please input a valid number.", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtId.Text = "";
				}
			}catch
			{
				txtId.Text = "";
			}
		}
		
		void TxtQuatityTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtQuatity.Text);
				if(n < 0)
				{
					MessageBox.Show("Please input a valid number.", "Declare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtQuatity.Text = "";
				}
			}catch
			{
				txtQuatity.Text = "";
			}
		}
		
		void BtnClearClick(object sender, EventArgs e)
		{
			ClearData();
		}
		public void ShowData(clsBook cbook)
		{
			txtName.Text = cbook.Name;
			txtPage.Text = cbook.Page.ToString();
			txtQuatity.Text = cbook.edit.ToString();
			txtPoet.Text = cbook.Poet;
			txtId.Text = cbook.id.ToString();
		}
		public void ShowData1(clsNews cnews)
		{
			txtName.Text = cnews.Name;
			txtQuatity.Text = cnews.edit.ToString();
			txtMonth.Text = cnews.Date.ToString();
			txtId.Text = cnews.id.ToString();
		}
		public void ShowData2(clsMagazine cmaga)
		{
			txtName.Text = cmaga.Name;
			txtPage.Text = cmaga.Month.ToString();
			txtQuatity.Text = cmaga.edit.ToString();
			txtNumber.Text = cmaga.Num.ToString();
			txtId.Text = cmaga.id.ToString();
		}
		void DataGrid1CurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				var row = source[dgshow.CurrentRowIndex];
				if(row != null)
				{
					var current = (clsBook)row;
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
					var current1 = (clsNews)row1;
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
					var current2 = (clsMagazine)row2;
					ShowData2(current2);
				}
			}catch
			{
				
			}
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			try
			{
				clsBook current = (clsBook)source[dgshow.CurrentRowIndex];
				source.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
			try
			{
				clsNews current1 = (clsNews)source1[dgshow.CurrentRowIndex];
				source1.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
			try
			{
				clsMagazine current2 = (clsMagazine)source2[dgshow.CurrentRowIndex];
				source2.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
			if (txtQuatity.Text == "" || txtId.Text == "" || txtName.Text == "")
			{
				ClearData();
			}
			else
			{
				int scan = 0;
				
				if (rdbBook.Checked == true)
				{
					scan = 1;
				}
				if (rdbNewspaper.Checked == true)
				{
					scan = 2;
				}
				if (rdbMagazine.Checked == true)
				{
					scan = 3;
				}
				//========= scan radio button ========//
				if (scan == 1 )
				{
					if(txtPoet.Text == "" || txtPage.Text =="")
						ClearData();
					else
					{
						dgshow.DataSource = source;
						book.id = int.Parse(txtId.Text);
						book.edit = int.Parse(txtQuatity.Text);
						book.Name = txtName.Text;
						book.Page = int.Parse(txtPage.Text);
						book.Poet = txtPoet.Text;
						source.Add(book);
						book = new clsBook();
						ClearData();
						dgshow.Refresh();
					}
				}
				if (scan == 2 )
				{
					if(txtNumber.Text == "" || txtMonth.Text == "")
						ClearData();
					else
					{
						dgshow.DataSource = source1;
						newspa.Name = txtName.Text; 
						newspa.id = int.Parse(txtId.Text);
						newspa.edit = int.Parse(txtQuatity.Text);
						newspa.Date = int.Parse(txtDate.Text);
						source1.Add(newspa);
						newspa = new clsNews();
						ClearData();
						dgshow.Refresh();
					}
				}
				if (scan == 3)
				{
					if(txtDate.Text == "")
						ClearData();
					else
					{
						dgshow.DataSource = source2;
						maga.Name = txtName.Text; 
						maga.id = int.Parse(txtId.Text);
						maga.edit = int.Parse(txtQuatity.Text);
						maga.Month = int.Parse(txtMonth.Text);
						maga.Num = int.Parse(txtNumber.Text);
						source2.Add(maga);
						maga = new clsMagazine();
						ClearData();
						dgshow.Refresh();
					}
				}
			}
		}
		
		void BtnEditClick(object sender, EventArgs e)
		{
			int scan = 0;
			if(rdbBook.Checked == true)
				scan = 1;
			if (rdbNewspaper.Checked == true)
				scan = 2;		
			if(rdbMagazine.Checked == true)
				scan = 3;
			
			if (txtQuatity.Text == "" || txtId.Text == "" || txtName.Text == "")
			{
				ClearData();
			}
			else
			{
				if(scan == 1)
				{
					if(txtPoet.Text == "" || txtPage.Text =="")
							ClearData();
					else
					{
						dgshow.DataSource = source;
						book.id = int.Parse(txtId.Text);
						book.edit = int.Parse(txtQuatity.Text);
						book.Name = txtName.Text;
						book.Page = int.Parse(txtPage.Text);
						book.Poet = txtPoet.Text;
						source[dgshow.CurrentRowIndex] = book;
						
					}
				}
				if(scan == 2)
				{
					if(txtNumber.Text == "" || txtMonth.Text == "")
						ClearData();
					else
					{
						dgshow.DataSource = source1;
						newspa.Name = txtName.Text; 
						newspa.id = int.Parse(txtId.Text);
						newspa.edit = int.Parse(txtQuatity.Text);
						newspa.Date = int.Parse(txtDate.Text);
						ClearData();
						dgshow.Refresh();
						source1[dgshow.CurrentRowIndex] = newspa;
					}
				}
				if (scan == 3)
				{
					if(txtDate.Text == "")
						ClearData();
					else
					{
						dgshow.DataSource = source2;
						maga.Name = txtName.Text; 
						maga.id = int.Parse(txtId.Text);
						maga.edit = int.Parse(txtQuatity.Text);
						maga.Month = int.Parse(txtMonth.Text);
						maga.Num = int.Parse(txtNumber.Text);
						ClearData();
						dgshow.Refresh();
						source2[dgshow.CurrentRowIndex] = maga;
					}
				}
			}
		}
		
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
	
		}
		
		void RdbSearchBCheckedChanged(object sender, EventArgs e)
		{
			if(rdbSearchB.Checked == true)
			{
				dgshow.DataSource = source;
			}
			if(rdbSearchM.Checked == true)
			{
				dgshow.DataSource = source2;
			}
			if(rdbSearchN.Checked == true)
			{
				dgshow.DataSource = source1;
			}
		}
	}
}
