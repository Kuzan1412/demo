/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/25/2018
 * Time: 8:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace OOPpoint
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtAx = new System.Windows.Forms.TextBox();
			this.txtBy = new System.Windows.Forms.TextBox();
			this.txtAy = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPerimeter = new System.Windows.Forms.TextBox();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txtCx = new System.Windows.Forms.TextBox();
			this.txtCy = new System.Windows.Forms.TextBox();
			this.txtBx = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.btnCalculator = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.txtAB = new System.Windows.Forms.TextBox();
			this.txtAC = new System.Windows.Forms.TextBox();
			this.txtBC = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Gold;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "A";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Gold;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(13, 65);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 38);
			this.label2.TabIndex = 1;
			this.label2.Text = "B";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtAx
			// 
			this.txtAx.Location = new System.Drawing.Point(93, 25);
			this.txtAx.Name = "txtAx";
			this.txtAx.Size = new System.Drawing.Size(33, 22);
			this.txtAx.TabIndex = 2;
			this.txtAx.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// txtBy
			// 
			this.txtBy.Location = new System.Drawing.Point(149, 82);
			this.txtBy.Name = "txtBy";
			this.txtBy.Size = new System.Drawing.Size(36, 22);
			this.txtBy.TabIndex = 5;
			this.txtBy.TextChanged += new System.EventHandler(this.TxtByTextChanged);
			// 
			// txtAy
			// 
			this.txtAy.Location = new System.Drawing.Point(149, 24);
			this.txtAy.Name = "txtAy";
			this.txtAy.Size = new System.Drawing.Size(36, 22);
			this.txtAy.TabIndex = 6;
			this.txtAy.TextChanged += new System.EventHandler(this.TxtAyTextChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Gold;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(13, 119);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 38);
			this.label3.TabIndex = 8;
			this.label3.Text = "C";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Gold;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(235, 64);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 39);
			this.label4.TabIndex = 9;
			this.label4.Text = "Perimeter";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Gold;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(235, 9);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 39);
			this.label5.TabIndex = 10;
			this.label5.Text = "Area";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPerimeter
			// 
			this.txtPerimeter.Location = new System.Drawing.Point(318, 77);
			this.txtPerimeter.Name = "txtPerimeter";
			this.txtPerimeter.Size = new System.Drawing.Size(102, 22);
			this.txtPerimeter.TabIndex = 11;
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(318, 21);
			this.txtArea.Name = "txtArea";
			this.txtArea.Size = new System.Drawing.Size(102, 22);
			this.txtArea.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(132, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(11, 22);
			this.label6.TabIndex = 13;
			this.label6.Text = ",";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(132, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(10, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = ",";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(132, 130);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(10, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = ",";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(292, 23);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(20, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "=";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(292, 76);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(20, 23);
			this.label10.TabIndex = 17;
			this.label10.Text = "=";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(66, 13);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(21, 45);
			this.label11.TabIndex = 18;
			this.label11.Text = "[";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(66, 115);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(23, 49);
			this.label12.TabIndex = 19;
			this.label12.Text = "[";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(66, 69);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(23, 49);
			this.label13.TabIndex = 20;
			this.label13.Text = "[";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(54, 134);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(20, 23);
			this.label14.TabIndex = 21;
			this.label14.Text = "=";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(54, 85);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(20, 23);
			this.label15.TabIndex = 22;
			this.label15.Text = "=";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(54, 24);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(20, 23);
			this.label16.TabIndex = 23;
			this.label16.Text = "=";
			// 
			// txtCx
			// 
			this.txtCx.Location = new System.Drawing.Point(90, 130);
			this.txtCx.Name = "txtCx";
			this.txtCx.Size = new System.Drawing.Size(36, 22);
			this.txtCx.TabIndex = 24;
			this.txtCx.TextChanged += new System.EventHandler(this.TxtCxTextChanged);
			// 
			// txtCy
			// 
			this.txtCy.Location = new System.Drawing.Point(148, 130);
			this.txtCy.Name = "txtCy";
			this.txtCy.Size = new System.Drawing.Size(36, 22);
			this.txtCy.TabIndex = 25;
			this.txtCy.TextChanged += new System.EventHandler(this.TxtCyTextChanged);
			// 
			// txtBx
			// 
			this.txtBx.Location = new System.Drawing.Point(90, 82);
			this.txtBx.Name = "txtBx";
			this.txtBx.Size = new System.Drawing.Size(36, 22);
			this.txtBx.TabIndex = 26;
			this.txtBx.TextChanged += new System.EventHandler(this.TxtBxTextChanged);
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(191, 114);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(23, 49);
			this.label17.TabIndex = 27;
			this.label17.Text = "]";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(191, 69);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(23, 49);
			this.label18.TabIndex = 28;
			this.label18.Text = "]";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(191, 13);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(23, 49);
			this.label19.TabIndex = 29;
			this.label19.Text = "]";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(326, 128);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(36, 22);
			this.textBox9.TabIndex = 30;
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Gold;
			this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label20.Location = new System.Drawing.Point(235, 114);
			this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(60, 39);
			this.label20.TabIndex = 31;
			this.label20.Text = "Space";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label20.Click += new System.EventHandler(this.Label20Click);
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(384, 128);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(36, 22);
			this.textBox10.TabIndex = 32;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(368, 130);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(10, 23);
			this.label21.TabIndex = 33;
			this.label21.Text = ",";
			// 
			// btnCalculator
			// 
			this.btnCalculator.Location = new System.Drawing.Point(13, 193);
			this.btnCalculator.Name = "btnCalculator";
			this.btnCalculator.Size = new System.Drawing.Size(84, 25);
			this.btnCalculator.TabIndex = 34;
			this.btnCalculator.Text = "Caculator";
			this.btnCalculator.UseVisualStyleBackColor = true;
			this.btnCalculator.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(118, 193);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(84, 25);
			this.btnClose.TabIndex = 35;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(235, 193);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(84, 25);
			this.btnClear.TabIndex = 36;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Gold;
			this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label22.Location = new System.Drawing.Point(442, 115);
			this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(34, 39);
			this.label22.TabIndex = 37;
			this.label22.Text = "AB";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Gold;
			this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label23.Location = new System.Drawing.Point(442, 65);
			this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(34, 39);
			this.label23.TabIndex = 38;
			this.label23.Text = "AC";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Gold;
			this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label24.Location = new System.Drawing.Point(442, 7);
			this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(34, 39);
			this.label24.TabIndex = 39;
			this.label24.Text = "BC";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtAB
			// 
			this.txtAB.Location = new System.Drawing.Point(483, 132);
			this.txtAB.Name = "txtAB";
			this.txtAB.Size = new System.Drawing.Size(102, 22);
			this.txtAB.TabIndex = 40;
			// 
			// txtAC
			// 
			this.txtAC.Location = new System.Drawing.Point(483, 78);
			this.txtAC.Name = "txtAC";
			this.txtAC.Size = new System.Drawing.Size(102, 22);
			this.txtAC.TabIndex = 41;
			// 
			// txtBC
			// 
			this.txtBC.Location = new System.Drawing.Point(483, 25);
			this.txtBC.Name = "txtBC";
			this.txtBC.Size = new System.Drawing.Size(102, 22);
			this.txtBC.TabIndex = 42;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(903, 460);
			this.Controls.Add(this.txtBC);
			this.Controls.Add(this.txtAC);
			this.Controls.Add(this.txtAB);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCalculator);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtBx);
			this.Controls.Add(this.txtCy);
			this.Controls.Add(this.txtCx);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.txtPerimeter);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAy);
			this.Controls.Add(this.txtBy);
			this.Controls.Add(this.txtAx);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "OOPpoint";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtBC;
		private System.Windows.Forms.TextBox txtAC;
		private System.Windows.Forms.TextBox txtAB;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnCalculator;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.TextBox txtPerimeter;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBx;
		private System.Windows.Forms.TextBox txtAy;
		private System.Windows.Forms.TextBox txtBy;
		private System.Windows.Forms.TextBox txtCy;
		private System.Windows.Forms.TextBox txtCx;
		private System.Windows.Forms.TextBox txtAx;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
