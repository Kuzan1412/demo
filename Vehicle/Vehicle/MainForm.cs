/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/26/2018
 * Time: 9:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
namespace Vehicle
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsContainer container = new clsContainer();
		clsMotobike motobike = new clsMotobike();
		clsCar car = new clsCar();
		List<clsContainer> conlist = new List<clsContainer>();
		List<clsMotobike> motolist = new List<clsMotobike>();
		List<clsCar> carlist = new List<clsCar>();
		
		BindingList<clsContainer> bconlist;
		BindingList<clsMotobike> bmotolist;
		BindingList<clsCar> bcarlist;
		BindingSource source;
		BindingSource source1;
		BindingSource source2;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bcarlist = new BindingList<clsCar>(carlist);
			source = new BindingSource(bcarlist, null);
			
			bconlist = new BindingList<clsContainer>(conlist);
			source1 = new BindingSource(bconlist,null);
			
			bmotolist = new BindingList<clsMotobike>(motolist);
			source2 = new BindingSource(bmotolist, null);
		}
		public bool IsCapacity(string a)
		{
			Regex regex = new Regex(@"[0-9]W");
			return regex.IsMatch(a);
		}
		public void ClearData()
		{
			this.txtCapacity.Text = "";
			this.txtSeat.Text = "";
			this.txtYear.Text = "";
			this.txtPrice.Text = "";
			this.txtPayLoad.Text ="";
			this.txtEngine.Text = "";
			this.txtMaker.Text = "";
		}
		public void ShowData()
		{
			
		}
		void TxtMakerTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtPriceTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtPrice.Text);
				if(n < 0)
				{
					txtPrice.Text = "";
				}
			}catch
			{
				txtPrice.Text = "";
			}
		}
		
		void TxtYearTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtYear.Text);
				if(n < 0)
				{
					txtYear.Text = "";
				}
			}catch
			{
				txtYear.Text = "";
			}
		}
		
		void TxtSeatTextChanged(object sender, EventArgs e)
		{
			int n;
			try
			{
				n = int.Parse(txtSeat.Text);
				if(n < 0 || n > 60)
				{
					txtSeat.Text = "";
				}
			}catch
			{
				txtSeat.Text = "";
			}
		}
		
		
		
		void RdbContainerCheckedChanged(object sender, EventArgs e)
		{
		
			if(rdbContainer.Checked == true)
			{
				txtPayLoad.Visible = true;
				txtSeat.Visible = false;
				txtEngine.Visible = false;
				txtCapacity.Visible = false;
			}
		
		}
		
		void RdbCarCheckedChanged(object sender, EventArgs e)
		{
			if(rdbCar.Checked == true)
			{
				txtPayLoad.Visible = false;
				txtSeat.Visible = true;
				txtEngine.Visible = true;
				txtCapacity.Visible = false;
			}
		}
		
		void RdbMotoCheckedChanged(object sender, EventArgs e)
		{
			if(rdbMoto.Checked == true)
			{
				txtPayLoad.Visible = false;
				txtSeat.Visible = false;
				txtEngine.Visible = false;
				txtCapacity.Visible = true;
			}
		}
		void CheckColor(clsContainer a, clsMotobike b, clsCar c)
		{
			
			if(rdbGreen.Checked == true)
			{
				a.Color = "Green";
				b.Color = "Green";
				c.Color = "Green";
			}
			if(rdbBlack.Checked == true)
			{
				a.Color = "Black";
				b.Color = "Black";
				c.Color = "Black";
			}
			if(rdbBlue.Checked == true)
			{
				a.Color = "Blue";
				b.Color = "Blue";
				c.Color = "Blue";
			}
			if(rdbSilver.Checked == true)
			{
				a.Color = "Silver";
				b.Color = "Silver";
				c.Color = "Silver";
			}
			if(rdbRed.Checked == true)
			{
				a.Color = "Red";
				b.Color = "Red";
				c.Color = "Red";
			}
			if(rdbWhite.Checked == true)
			{
				a.Color = "White";
				b.Color = "White";
				c.Color = "White";
			}
		}
		void BtnAddClick(object sender, EventArgs e)
		{
			if ( txtYear.Text == "" || txtPrice.Text == "" || txtMaker.Text == "")
			{
				ClearData();
			}
			else
			{
				CheckColor(container, motobike, car);
				if(rdbMoto.Checked == true)
				{
					if(IsCapacity(txtCapacity.Text) == false)
						ClearData();
					else
					{
						dgshow.DataSource = source2;
						motobike.Maker = txtMaker.Text;
						motobike.Price = int.Parse(txtPrice.Text);
						motobike.Year = int.Parse(txtYear.Text);
						motobike.Capacity = txtCapacity.Text;
						
						source2.Add(motobike);
						motobike = new clsMotobike();
						ClearData();
						dgshow.Refresh();
					}
				}
				if(rdbCar.Checked == true)
				{
					dgshow.DataSource = source;
					
					car.Year = int.Parse(txtYear.Text);
					car.Seat = int.Parse(txtSeat.Text);
					car.Price = int.Parse(txtPrice.Text);
					car.Maker = txtMaker.Text;
					car.Engine = txtEngine.Text;
					source.Add(car);
					car = new clsCar();
					ClearData();
					dgshow.Refresh();
				}
				if(rdbContainer.Checked == true)
				{
					dgshow.DataSource = source1;
					
					container.Year = int.Parse(txtYear.Text);
					container.Price = int.Parse(txtPrice.Text);
					container.Maker = txtMaker.Text;
					container.Payload = txtPayLoad.Text;
					source1.Add(container);
					container = new clsContainer();
					ClearData();
					dgshow.Refresh();
				}
				
			}
		}
		
		void TxtCapacityTextChanged(object sender, EventArgs e)
		{
	
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			try
			{
				clsCar current = (clsCar)source[dgshow.CurrentRowIndex];
				source.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
			try
			{
				clsContainer current1 = (clsContainer)source1[dgshow.CurrentRowIndex];
				source1.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
			try
			{
				clsMotobike current2 = (clsMotobike)source2[dgshow.CurrentRowIndex];
				source2.RemoveAt(dgshow.CurrentRowIndex);
				
			}catch
			{
				
			}
		}
		
		void BtnLoadClick(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Json Files|*.json|All Files|*.*";
			if(rdbMoto.Checked == true)
			{
				if(open.ShowDialog() == DialogResult.OK)
				{
					string sFileName = open.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					StreamReader reader = new StreamReader(sFileName);
					string json = reader.ReadToEnd();
					reader.Close();
					var deserializeObject = serializer.Deserialize<List<clsMotobike>>(json);
					source.Clear();
					foreach (var element in deserializeObject) {
						source.Add(element);
					}
					MessageBox.Show("Load OK !");
				}
			}
			if(rdbCar.Checked == true)
			{
				if(open.ShowDialog() == DialogResult.OK)
				{
					string sFileName = open.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					StreamReader reader = new StreamReader(sFileName);
					string json = reader.ReadToEnd();
					reader.Close();
					var deserializeObject = serializer.Deserialize<List<clsCar>>(json);
					source.Clear();
					foreach (var element in deserializeObject) {
						source.Add(element);
					}
					MessageBox.Show("Load OK !");
				}
			}
			if(rdbContainer.Checked == true)
			{
				if(open.ShowDialog() == DialogResult.OK)
				{
					string sFileName = open.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					StreamReader reader = new StreamReader(sFileName);
					string json = reader.ReadToEnd();
					reader.Close();
					var deserializeObject = serializer.Deserialize<List<clsContainer>>(json);
					source.Clear();
					foreach (var element in deserializeObject) {
						source.Add(element);
					}
					MessageBox.Show("Load OK !");
				}
			}
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Json Files|*.json|All Files|*.*";
			if(rdbMoto.Checked == true)
			{
				if(save.ShowDialog() == DialogResult.OK)
				{
					string sFileName = save.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					var json = serializer.Serialize(bmotolist);
					StreamWriter writer ;
					writer = new StreamWriter(sFileName);
					writer.Write(json);
					writer.Close();
					MessageBox.Show("Saved !");
				}
			}
			if(rdbContainer.Checked == true)
			{
				if(save.ShowDialog() == DialogResult.OK)
				{
					string sFileName = save.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					var json = serializer.Serialize(bconlist);
					StreamWriter writer ;
					writer = new StreamWriter(sFileName);
					writer.Write(json);
					writer.Close();
					MessageBox.Show("Saved !");
				}
			}
			if(rdbCar.Checked == true)
			{
				if(save.ShowDialog() == DialogResult.OK)
				{
					string sFileName = save.FileName;
					JavaScriptSerializer serializer = new JavaScriptSerializer();
					var json = serializer.Serialize(bcarlist);
					StreamWriter writer ;
					writer = new StreamWriter(sFileName);
					writer.Write(json);
					writer.Close();
					MessageBox.Show("Saved !");
				}
			}
		}
	}
}
