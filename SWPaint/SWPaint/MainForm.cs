/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/27/2018
 * Time: 8:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.ComponentModel;
using System.Web.Script.Serialization;
using System.IO;
using System.Linq;


namespace SWPaint
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	public partial class MainForm : Form
	{
		clsPoint A1 = new clsPoint();
		clsPoint A2 = new clsPoint();
		clsPoint A3 = new clsPoint();
		clsPoint A4 = new clsPoint();
		
		bool IsDrawing = false;
		List<clsShape> shape = new List<clsShape>();
		BindingList<clsShape> bshape;
		BindingSource source;
		Graphics g;
		Pen p;
		Bitmap filejpg; 
		Point[] polygonPoints = new Point[4];
	
		public MainForm()
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			
			filejpg = new Bitmap(pbDraw.Width, pbDraw.Height);
			bshape = new BindingList<clsShape>(shape);
			source = new BindingSource(bshape, null);
			g = Graphics.FromImage(filejpg);
			p = new Pen(Color.Black);
			
	
		}
		
		void PictureBoxMouseUp(object sender, MouseEventArgs e)
		{
			if(tsbLine.Checked == true)
			{
				A2.X = e.X;
				A2.Y = e.Y;
				System.Drawing.Graphics g = pbDraw.CreateGraphics();
				g.DrawLine(new Pen(Color.Black),A1.X, A1.Y, A2.X, A2.Y);
				IsDrawing = false;
				clsLine l = new clsLine(A1, A2);
				shape.Add(l);
				foreach (var element in shape)
				{
					element.Draw(g, new Pen(Color.Black));
				}
				
			}
			
			if(tsbTriangle.Checked == true)
			{
				A3.Y = e.Y;
				A3.X = e.X;				
				System.Drawing.Graphics g = pbDraw.CreateGraphics();
				g.DrawLine(new Pen(Color.Black), A1.X, A1.Y, A3.X, A3.Y);
				g.DrawLine(new Pen(Color.Black), A1.X, A1.Y, A2.X, A2.Y);
				g.DrawLine(new Pen(Color.Black), A2.X, A2.Y, A3.X, A3.Y);
				IsDrawing = false;
				clsTriagle tri = new clsTriagle(A1, A2, A3);
				shape = new List<clsShape>();
				shape.Add(tri);
				foreach (var element in shape)
				{
					element.Draw(g, new Pen(Color.Black));
				}
				
				
			}
			if(tsbRhombus.Checked == true)
			{
				A3.Y = e.Y;
				A3.X = e.X;				
				System.Drawing.Graphics g = pbDraw.CreateGraphics();
				g.DrawLine(new Pen(Color.Black), A1.X, A1.Y, A2.X, A2.Y);
				g.DrawLine(new Pen(Color.Black), A1.X, A1.Y, A3.X, A3.Y);
				g.DrawLine(new Pen(Color.Black), A3.X, A3.Y, A4.X, A4.Y);
				g.DrawLine(new Pen(Color.Black), A4.X, A4.Y, A2.X, A2.Y);
				IsDrawing = false;
				clsRhombus rho = new clsRhombus(A1, A2, A3, A4);
				shape = new List<clsShape>();
				shape.Add(rho);
				foreach (var element in shape)
				{
					element.Draw(g, new Pen(Color.Black));
				}
			}
			
		}
		
		void PictureBoxMouseDown(object sender, MouseEventArgs e)
		{
			if(tsbLine.Checked == true)
			{
				IsDrawing = true;
				A1.X = e.X;
				A1.Y = e.Y;	
			}
			if(tsbTriangle.Checked == true)
			{
				IsDrawing = true;
				A1.X = e.X;
				A1.Y = e.Y;	
				
			}
			if(tsbRhombus.Checked == true)
			{
				IsDrawing = true;
				A1.Y = e.Y;
				A1.X = e.X;
				
			}
					
		}
		
		
		
		void PbDrawMouseMove(object sender, MouseEventArgs e)
		{
			if(IsDrawing == true)
			{
				if(tsbLine.Checked == true)
				{
					
					System.Drawing.Graphics g = pbDraw.CreateGraphics();
		       		g.DrawLine(new Pen(Color.White), A1.X, A1.Y, A2.X, A2.Y);
		       		A2.X = e.X;
		       		A2.Y = e.Y;
		       		foreach(var element in shape)
		       		{
		       			element.Draw(g, new Pen(Color.Black));
		       		}
		       		
		       		g.DrawLine(new Pen(Color.Black), A1.X, A1.Y, A2.X, A2.Y);
		       		
				}
				if(tsbTriangle.Checked == true)
				{
					
					System.Drawing.Graphics g = pbDraw.CreateGraphics();
		       		g.DrawLine(new Pen(Color.White), A1.X, A1.Y, A2.X, A2.Y);
		       		g.DrawLine(new Pen(Color.White), A2.X, A2.Y, A3.X, A3.Y);
		       		g.DrawLine(new Pen(Color.White), A1.X, A1.Y, A3.X, A3.Y);
		       		A2.X = e.X;
		       		A2.Y = e.Y;
		       		foreach(var element in shape)
		       		{
		       			element.Draw(g, new Pen(Color.Black));
		       		}
		       		g.DrawLine(new Pen(Color.Black), A1.X, A1.Y, A2.X, A2.Y);		
					g.DrawLine(new Pen(Color.Black), A2.X, A2.Y, A3.X, A3.Y);
					g.DrawLine(new Pen(Color.Black), A1.X, A1.Y, A3.X, A3.Y);
					
					
				}
				if(tsbRhombus.Checked == true)
				{
				
		       		System.Drawing.Graphics g = pbDraw.CreateGraphics();
		       		g.DrawLine(new Pen(Color.White), A1.X, A1.Y, A2.X, A2.Y);
		       		g.DrawLine(new Pen(Color.White), A4.X, A4.Y, A3.X, A3.Y);
		       		g.DrawLine(new Pen(Color.White), A1.X, A1.Y, A3.X, A3.Y);
		       		g.DrawLine(new Pen(Color.White), A4.X, A4.Y, A3.X, A3.Y);
		       		
		       		A2.X = e.X;
		       		A2.Y = e.Y;
		       		foreach(var element in shape)
		       		{
		       			element.Draw(g, new Pen(Color.Black));
		       		}
		       		g.DrawLine(new Pen(Color.Black), A1.X, A1.Y, A2.X, A2.Y);		
					g.DrawLine(new Pen(Color.Black), A1.X, A1.Y, A3.X, A3.Y);
					g.DrawLine(new Pen(Color.Black), A4.X, A4.Y, A3.X, A3.Y);
					g.DrawLine(new Pen(Color.Black), A4.X, A4.Y, A2.X, A2.Y);
					
					
				}
		       
			}
			
		}
		
	
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	
		
		
		
		
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Json Files|*.json|All Files|*.*";
			if(save.ShowDialog() == DialogResult.OK)
			{
				string sFileName = save.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				var json = serializer.Serialize(shape);
				StreamWriter writer ;
				writer = new StreamWriter(sFileName);
				writer.Write(json);
				writer.Close();
				MessageBox.Show("Saved !");
			}
			/*
			Bitmap bitmap = new Bitmap(pbDraw.Width, pbDraw.Height);
			SaveFileDialog save = new SaveFileDialog();
			pbDraw.DrawToBitmap(bitmap, new Rectangle(0, 0, pbDraw.Width, pbDraw.Height));//pbPaint là instance object của thằng PictureBox
			pbDraw.Image = bitmap;//gán Image lại cho picturebox
			ImageFormat format = ImageFormat.Jpeg;
			pbDraw.Image.Save(save.FileName, format);*/
		}
		
		void LoadToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			/*OpenFileDialog image = new OpenFileDialog();
			
			image.Filter = "Hinh anh JPG|*.jpg|Hinh anh Bitmap|*.bmp|Tat ca cac file|*.*";
			if (image.ShowDialog() == DialogResult.OK)
			{
				image.FileName = image.FileName;
				pbDraw.Load(image.FileName);
			}		*/
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Json Files|*.json|All Files|*.*";
			if(open.ShowDialog() == DialogResult.OK)
			{
				string sFileName = open.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				StreamReader reader = new StreamReader(sFileName);
				string json = reader.ReadToEnd();
				reader.Close();
				var deserializeObject = serializer.Deserialize<List<clsShape>>(json);
				source.Clear();
				foreach (var element in deserializeObject) {
					source.Add(element);
				}
				
				//pbDraw.Load(Image);
				MessageBox.Show("Load OK !");
			}	
		}
		
		void ClearToolStripMenuItemClick(object sender, EventArgs e)
		{
			Graphics g = pbDraw.CreateGraphics();
			g.Clear(Color.White);
			shape = new List<clsShape>();
		}
		
		
	}
}
