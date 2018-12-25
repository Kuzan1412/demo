/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/25/2018
 * Time: 8:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOPpoint
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label20Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			try
			{
				int n = int.Parse(txtAx.Text);
			}catch
			{
				txtAx.Text = "";
			}
		}
		
		void TxtAyTextChanged(object sender, EventArgs e)
		{
			try
			{
				int n = int.Parse(txtAy.Text);
			}catch
			{
				txtAy.Text = "";
			}
		}
		
		void TxtBxTextChanged(object sender, EventArgs e)
		{
			try
			{
				int n = int.Parse(txtBx.Text);
			}catch
			{
				txtBx.Text = "";
			}
		}
		
		void TxtByTextChanged(object sender, EventArgs e)
		{
			try
			{
				int n = int.Parse(txtBy.Text);
			}catch
			{
				txtBy.Text = "";
			}
		}
		
		void TxtCxTextChanged(object sender, EventArgs e)
		{
			try
			{
				int n = int.Parse(txtCx.Text);
			}catch
			{
				txtCx.Text = "";
			}
		}
		
		void TxtCyTextChanged(object sender, EventArgs e)
		{
			try
			{
				int n = int.Parse(txtCy.Text);
			}catch
			{
				txtCy.Text = "";
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			clsPoint a = new clsPoint();
			clsPoint b = new clsPoint();
			clsPoint c = new clsPoint();
			a.ix = int.Parse(txtAx.Text);
			a.iy = int.Parse(txtAy.Text);
			b.iy = int.Parse(txtBy.Text);
			b.ix = int.Parse(txtBx.Text);
			c.ix = int.Parse(txtCx.Text);
			c.iy = int.Parse(txtCy.Text);
			double AB, AC, BC, p;
			AB = Math.Sqrt(Math.Pow(b.ix - a.ix, 2) + Math.Pow(b.iy - a.iy, 2));
			AC = Math.Sqrt(Math.Pow(c.ix - a.ix, 2) + Math.Pow(c.iy - a.iy, 2));
			BC = Math.Sqrt(Math.Pow(c.ix - b.ix, 2) + Math.Pow(c.iy - b.iy, 2));
			txtBC.Text = BC.ToString();
			txtAB.Text = AB.ToString();
			txtAC.Text = AC.ToString();
			p =  (AB+AC+BC)/2;
			txtPerimeter.Text = (AB+AC+BC).ToString();
			txtArea.Text = Math.Sqrt(p*(p-AB)*(p-AC)*(p-BC)).ToString();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public void ClearData()
		{
			this.txtAx.Text = "";
			this.txtAy.Text = "";
			this.txtBx.Text = "";
			this.txtBy.Text = "";
			this.txtCx.Text = "";
			this.txtCy.Text = "";
		}
		void BtnClearClick(object sender, EventArgs e)
		{
			ClearData();
		}
	}
}
