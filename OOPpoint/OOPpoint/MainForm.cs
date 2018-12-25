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
		public void Draw(clsPoint a, clsPoint b, clsPoint c)
		{
		using (Graphics g = panel1.CreateGraphics())
		{
			 g.DrawLine(new Pen(Color.Black, 5), new Point(a.ix, a.iy), new Point(b.ix, b.iy));
			 g.DrawLine(new Pen(Color.Black, 5), new Point(c.ix, c.iy), new Point(b.ix, b.iy));
			 g.DrawLine(new Pen(Color.Black, 5), new Point(c.ix, c.iy), new Point(a.ix, a.iy));
		}}
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
		public void Space(clsPoint xA, clsPoint xB, clsPoint xC)
		{
			
			txtBC.Text = clsRectangle.Space(xB, xC).ToString();
			txtAB.Text = clsRectangle.Space(xA, xB).ToString();
			txtAC.Text = clsRectangle.Space(xA, xC).ToString();
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
			Refresh();
			if(txtAx.Text == "" || txtAy.Text == "" || txtBx.Text == "" || txtBy.Text == "" || txtCx.Text == "" || txtCy.Text == "")
			{
				ClearData();
			}
			else
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
				Space(a, b, c);
				txtPerimeter.Text = clsRectangle.perimeter(a, b, c).ToString();
				txtArea.Text = clsRectangle.area(a, b, c).ToString();
				Draw(a, b, c);
			}
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
			this.txtPerimeter.Text = "";
			this.txtArea.Text = "";
			this.txtAB.Text = "";
			this.txtAC.Text = "";
			this.txtBC.Text = "";
		}
		void BtnClearClick(object sender, EventArgs e)
		{
			
			ClearData();
		}
	}
}
