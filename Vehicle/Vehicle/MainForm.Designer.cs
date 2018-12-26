/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/26/2018
 * Time: 9:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Vehicle
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMaker = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.rdbContainer = new System.Windows.Forms.RadioButton();
			this.rdbMoto = new System.Windows.Forms.RadioButton();
			this.rdbCar = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtPayLoad = new System.Windows.Forms.TextBox();
			this.txtEngine = new System.Windows.Forms.TextBox();
			this.txtSeat = new System.Windows.Forms.TextBox();
			this.txtCapacity = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dgshow = new System.Windows.Forms.DataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbSilver = new System.Windows.Forms.RadioButton();
			this.rdbWhite = new System.Windows.Forms.RadioButton();
			this.rdbBlack = new System.Windows.Forms.RadioButton();
			this.rdbGreen = new System.Windows.Forms.RadioButton();
			this.rdbBlue = new System.Windows.Forms.RadioButton();
			this.rdbRed = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.PaleGreen;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(30, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Maker";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Cyan;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(13, 9);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(700, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Management Vehicle";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Cyan;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label2.Location = new System.Drawing.Point(13, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(10, 323);
			this.label2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Cyan;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label3.Location = new System.Drawing.Point(703, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(10, 323);
			this.label3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.PaleGreen;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(29, 154);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Year";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.PaleGreen;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(30, 101);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "Price";
			// 
			// txtMaker
			// 
			this.txtMaker.Location = new System.Drawing.Point(106, 47);
			this.txtMaker.Name = "txtMaker";
			this.txtMaker.Size = new System.Drawing.Size(128, 22);
			this.txtMaker.TabIndex = 0;
			this.txtMaker.TextChanged += new System.EventHandler(this.TxtMakerTextChanged);
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(106, 155);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(128, 22);
			this.txtYear.TabIndex = 2;
			this.txtYear.TextChanged += new System.EventHandler(this.TxtYearTextChanged);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(106, 99);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(128, 22);
			this.txtPrice.TabIndex = 1;
			this.txtPrice.TextChanged += new System.EventHandler(this.TxtPriceTextChanged);
			// 
			// rdbContainer
			// 
			this.rdbContainer.Location = new System.Drawing.Point(265, 46);
			this.rdbContainer.Name = "rdbContainer";
			this.rdbContainer.Size = new System.Drawing.Size(104, 24);
			this.rdbContainer.TabIndex = 13;
			this.rdbContainer.TabStop = true;
			this.rdbContainer.Text = "Container";
			this.rdbContainer.UseVisualStyleBackColor = true;
			this.rdbContainer.CheckedChanged += new System.EventHandler(this.RdbContainerCheckedChanged);
			// 
			// rdbMoto
			// 
			this.rdbMoto.Location = new System.Drawing.Point(570, 46);
			this.rdbMoto.Name = "rdbMoto";
			this.rdbMoto.Size = new System.Drawing.Size(104, 24);
			this.rdbMoto.TabIndex = 14;
			this.rdbMoto.TabStop = true;
			this.rdbMoto.Text = "Motobike";
			this.rdbMoto.UseVisualStyleBackColor = true;
			this.rdbMoto.CheckedChanged += new System.EventHandler(this.RdbMotoCheckedChanged);
			// 
			// rdbCar
			// 
			this.rdbCar.Location = new System.Drawing.Point(418, 46);
			this.rdbCar.Name = "rdbCar";
			this.rdbCar.Size = new System.Drawing.Size(54, 24);
			this.rdbCar.TabIndex = 15;
			this.rdbCar.TabStop = true;
			this.rdbCar.Text = "Car";
			this.rdbCar.UseVisualStyleBackColor = true;
			this.rdbCar.CheckedChanged += new System.EventHandler(this.RdbCarCheckedChanged);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Cyan;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label8.Location = new System.Drawing.Point(240, 49);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(10, 137);
			this.label8.TabIndex = 16;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Cyan;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label9.Location = new System.Drawing.Point(402, 51);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(10, 137);
			this.label9.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Cyan;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label10.Location = new System.Drawing.Point(553, 51);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(10, 137);
			this.label10.TabIndex = 18;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.PaleGreen;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(419, 129);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(69, 23);
			this.label11.TabIndex = 19;
			this.label11.Text = "Engine";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.PaleGreen;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Location = new System.Drawing.Point(418, 73);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(69, 23);
			this.label12.TabIndex = 20;
			this.label12.Text = "Seat";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.PaleGreen;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label13.Location = new System.Drawing.Point(265, 73);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(69, 23);
			this.label13.TabIndex = 21;
			this.label13.Text = "Payload";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.PaleGreen;
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label14.Location = new System.Drawing.Point(570, 73);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(73, 23);
			this.label14.TabIndex = 22;
			this.label14.Text = "Capacity";
			// 
			// txtPayLoad
			// 
			this.txtPayLoad.Location = new System.Drawing.Point(265, 99);
			this.txtPayLoad.Name = "txtPayLoad";
			this.txtPayLoad.Size = new System.Drawing.Size(128, 22);
			this.txtPayLoad.TabIndex = 3;
			this.txtPayLoad.Visible = false;
			// 
			// txtEngine
			// 
			this.txtEngine.Location = new System.Drawing.Point(419, 155);
			this.txtEngine.Name = "txtEngine";
			this.txtEngine.Size = new System.Drawing.Size(128, 22);
			this.txtEngine.TabIndex = 5;
			this.txtEngine.Visible = false;
			// 
			// txtSeat
			// 
			this.txtSeat.Location = new System.Drawing.Point(418, 99);
			this.txtSeat.Name = "txtSeat";
			this.txtSeat.Size = new System.Drawing.Size(128, 22);
			this.txtSeat.TabIndex = 4;
			this.txtSeat.Visible = false;
			this.txtSeat.TextChanged += new System.EventHandler(this.TxtSeatTextChanged);
			// 
			// txtCapacity
			// 
			this.txtCapacity.Location = new System.Drawing.Point(569, 99);
			this.txtCapacity.Name = "txtCapacity";
			this.txtCapacity.Size = new System.Drawing.Size(121, 22);
			this.txtCapacity.TabIndex = 6;
			this.txtCapacity.Visible = false;
			this.txtCapacity.TextChanged += new System.EventHandler(this.TxtCapacityTextChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(30, 201);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(142, 201);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 8;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(244, 201);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(348, 201);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 10;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.BtnLoadClick);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(453, 201);
			this.btnSave.Name = "btnSave";
			this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// dgshow
			// 
			this.dgshow.DataMember = "";
			this.dgshow.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgshow.Location = new System.Drawing.Point(29, 230);
			this.dgshow.Name = "dgshow";
			this.dgshow.Size = new System.Drawing.Size(394, 139);
			this.dgshow.TabIndex = 32;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.groupBox1.Controls.Add(this.rdbSilver);
			this.groupBox1.Controls.Add(this.rdbWhite);
			this.groupBox1.Controls.Add(this.rdbBlack);
			this.groupBox1.Controls.Add(this.rdbGreen);
			this.groupBox1.Controls.Add(this.rdbBlue);
			this.groupBox1.Controls.Add(this.rdbRed);
			this.groupBox1.Location = new System.Drawing.Point(457, 239);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(232, 129);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Color";
			// 
			// rdbSilver
			// 
			this.rdbSilver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.rdbSilver.Location = new System.Drawing.Point(84, 93);
			this.rdbSilver.Name = "rdbSilver";
			this.rdbSilver.Size = new System.Drawing.Size(69, 30);
			this.rdbSilver.TabIndex = 5;
			this.rdbSilver.Text = "Silver";
			this.rdbSilver.UseVisualStyleBackColor = true;
			// 
			// rdbWhite
			// 
			this.rdbWhite.ForeColor = System.Drawing.Color.White;
			this.rdbWhite.Location = new System.Drawing.Point(143, 57);
			this.rdbWhite.Name = "rdbWhite";
			this.rdbWhite.Size = new System.Drawing.Size(69, 30);
			this.rdbWhite.TabIndex = 4;
			this.rdbWhite.Text = "White";
			this.rdbWhite.UseVisualStyleBackColor = true;
			// 
			// rdbBlack
			// 
			this.rdbBlack.ForeColor = System.Drawing.Color.Black;
			this.rdbBlack.Location = new System.Drawing.Point(41, 57);
			this.rdbBlack.Name = "rdbBlack";
			this.rdbBlack.Size = new System.Drawing.Size(69, 30);
			this.rdbBlack.TabIndex = 3;
			this.rdbBlack.Text = "Black";
			this.rdbBlack.UseVisualStyleBackColor = true;
			// 
			// rdbGreen
			// 
			this.rdbGreen.ForeColor = System.Drawing.Color.Lime;
			this.rdbGreen.Location = new System.Drawing.Point(84, 22);
			this.rdbGreen.Name = "rdbGreen";
			this.rdbGreen.Size = new System.Drawing.Size(81, 24);
			this.rdbGreen.TabIndex = 2;
			this.rdbGreen.Text = "Green";
			this.rdbGreen.UseVisualStyleBackColor = true;
			// 
			// rdbBlue
			// 
			this.rdbBlue.ForeColor = System.Drawing.Color.Blue;
			this.rdbBlue.Location = new System.Drawing.Point(167, 22);
			this.rdbBlue.Name = "rdbBlue";
			this.rdbBlue.Size = new System.Drawing.Size(63, 24);
			this.rdbBlue.TabIndex = 1;
			this.rdbBlue.Text = "Blue";
			this.rdbBlue.UseVisualStyleBackColor = true;
			// 
			// rdbRed
			// 
			this.rdbRed.Checked = true;
			this.rdbRed.ForeColor = System.Drawing.Color.Red;
			this.rdbRed.Location = new System.Drawing.Point(6, 21);
			this.rdbRed.Name = "rdbRed";
			this.rdbRed.Size = new System.Drawing.Size(69, 24);
			this.rdbRed.TabIndex = 0;
			this.rdbRed.TabStop = true;
			this.rdbRed.Text = "Red";
			this.rdbRed.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Beige;
			this.ClientSize = new System.Drawing.Size(724, 383);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgshow);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtCapacity);
			this.Controls.Add(this.txtSeat);
			this.Controls.Add(this.txtEngine);
			this.Controls.Add(this.txtPayLoad);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.rdbContainer);
			this.Controls.Add(this.rdbCar);
			this.Controls.Add(this.rdbMoto);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.txtMaker);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Blue;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Vehicle";
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton rdbRed;
		private System.Windows.Forms.RadioButton rdbBlue;
		private System.Windows.Forms.RadioButton rdbGreen;
		private System.Windows.Forms.RadioButton rdbBlack;
		private System.Windows.Forms.RadioButton rdbWhite;
		private System.Windows.Forms.RadioButton rdbSilver;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGrid dgshow;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtCapacity;
		private System.Windows.Forms.TextBox txtSeat;
		private System.Windows.Forms.TextBox txtEngine;
		private System.Windows.Forms.TextBox txtPayLoad;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton rdbCar;
		private System.Windows.Forms.RadioButton rdbMoto;
		private System.Windows.Forms.RadioButton rdbContainer;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.TextBox txtMaker;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		
		
	}
}
