/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/19/2018
 * Time: 11:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Library
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
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgshow = new System.Windows.Forms.DataGrid();
			this.txtQuatity = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.rdbMagazine = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtMonth = new System.Windows.Forms.TextBox();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtPage = new System.Windows.Forms.TextBox();
			this.txtPoet = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rdbNewspaper = new System.Windows.Forms.RadioButton();
			this.rdbBook = new System.Windows.Forms.RadioButton();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.rdbSearchB = new System.Windows.Forms.RadioButton();
			this.rdbSearchN = new System.Windows.Forms.RadioButton();
			this.rdbSearchM = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(7, 191);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Yellow;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(295, 191);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Quatity";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Yellow;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(161, 191);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Id";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgshow);
			this.groupBox1.Controls.Add(this.txtQuatity);
			this.groupBox1.Controls.Add(this.txtId);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.rdbMagazine);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.rdbNewspaper);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.rdbBook);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(488, 372);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Library";
			// 
			// dgshow
			// 
			this.dgshow.DataMember = "";
			this.dgshow.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgshow.Location = new System.Drawing.Point(7, 250);
			this.dgshow.Name = "dgshow";
			this.dgshow.Size = new System.Drawing.Size(474, 116);
			this.dgshow.TabIndex = 11;
			this.dgshow.CurrentCellChanged += new System.EventHandler(this.DataGrid1CurrentCellChanged);
			// 
			// txtQuatity
			// 
			this.txtQuatity.Location = new System.Drawing.Point(295, 222);
			this.txtQuatity.Name = "txtQuatity";
			this.txtQuatity.Size = new System.Drawing.Size(100, 22);
			this.txtQuatity.TabIndex = 10;
			this.txtQuatity.TextChanged += new System.EventHandler(this.TxtQuatityTextChanged);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(161, 222);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 22);
			this.txtId.TabIndex = 9;
			this.txtId.TextChanged += new System.EventHandler(this.TxtIdTextChanged);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(6, 222);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 22);
			this.txtName.TabIndex = 8;
			this.txtName.TextChanged += new System.EventHandler(this.TxtNameTextChanged);
			// 
			// rdbMagazine
			// 
			this.rdbMagazine.BackColor = System.Drawing.Color.Yellow;
			this.rdbMagazine.Location = new System.Drawing.Point(167, 19);
			this.rdbMagazine.Name = "rdbMagazine";
			this.rdbMagazine.Size = new System.Drawing.Size(94, 24);
			this.rdbMagazine.TabIndex = 3;
			this.rdbMagazine.Text = "Magazine";
			this.rdbMagazine.UseVisualStyleBackColor = false;
			this.rdbMagazine.CheckedChanged += new System.EventHandler(this.RdbMagazineCheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtDate);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Location = new System.Drawing.Point(327, 49);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(155, 139);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(6, 52);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(100, 22);
			this.txtDate.TabIndex = 9;
			this.txtDate.TextChanged += new System.EventHandler(this.TxtDateTextChanged);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Silver;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Location = new System.Drawing.Point(6, 18);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(120, 26);
			this.label9.TabIndex = 6;
			this.label9.Text = "Date edition";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtMonth);
			this.groupBox3.Controls.Add(this.txtNumber);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Location = new System.Drawing.Point(161, 49);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(155, 139);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			// 
			// txtMonth
			// 
			this.txtMonth.Location = new System.Drawing.Point(6, 108);
			this.txtMonth.Name = "txtMonth";
			this.txtMonth.Size = new System.Drawing.Size(100, 22);
			this.txtMonth.TabIndex = 8;
			this.txtMonth.TextChanged += new System.EventHandler(this.TxtYearTextChanged);
			// 
			// txtNumber
			// 
			this.txtNumber.Location = new System.Drawing.Point(6, 52);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(100, 22);
			this.txtNumber.TabIndex = 9;
			this.txtNumber.TextChanged += new System.EventHandler(this.TxtNumberTextChanged);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Silver;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(6, 79);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 26);
			this.label7.TabIndex = 7;
			this.label7.Text = "Month edition";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Silver;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(6, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 26);
			this.label6.TabIndex = 6;
			this.label6.Text = "Number edition";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtPage);
			this.groupBox2.Controls.Add(this.txtPoet);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(7, 49);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(135, 139);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// txtPage
			// 
			this.txtPage.Location = new System.Drawing.Point(6, 109);
			this.txtPage.Name = "txtPage";
			this.txtPage.Size = new System.Drawing.Size(100, 22);
			this.txtPage.TabIndex = 7;
			this.txtPage.TextChanged += new System.EventHandler(this.TxtPageTextChanged);
			// 
			// txtPoet
			// 
			this.txtPoet.Location = new System.Drawing.Point(6, 50);
			this.txtPoet.Name = "txtPoet";
			this.txtPoet.Size = new System.Drawing.Size(100, 22);
			this.txtPoet.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Silver;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(6, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 26);
			this.label5.TabIndex = 5;
			this.label5.Text = "Page";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Silver;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(6, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 26);
			this.label4.TabIndex = 4;
			this.label4.Text = "Poet";
			// 
			// rdbNewspaper
			// 
			this.rdbNewspaper.BackColor = System.Drawing.Color.Yellow;
			this.rdbNewspaper.Location = new System.Drawing.Point(346, 21);
			this.rdbNewspaper.Name = "rdbNewspaper";
			this.rdbNewspaper.Size = new System.Drawing.Size(111, 24);
			this.rdbNewspaper.TabIndex = 4;
			this.rdbNewspaper.Text = "Newspaper";
			this.rdbNewspaper.UseVisualStyleBackColor = false;
			this.rdbNewspaper.CheckedChanged += new System.EventHandler(this.RdbNewspaperCheckedChanged);
			// 
			// rdbBook
			// 
			this.rdbBook.BackColor = System.Drawing.Color.Yellow;
			this.rdbBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.rdbBook.Location = new System.Drawing.Point(7, 19);
			this.rdbBook.Name = "rdbBook";
			this.rdbBook.Size = new System.Drawing.Size(104, 24);
			this.rdbBook.TabIndex = 5;
			this.rdbBook.Text = "Book";
			this.rdbBook.UseVisualStyleBackColor = false;
			this.rdbBook.CheckedChanged += new System.EventHandler(this.RdbBookCheckedChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(524, 93);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(524, 193);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(524, 160);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(524, 129);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(513, 237);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Search";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.rdbSearchM);
			this.groupBox5.Controls.Add(this.rdbSearchN);
			this.groupBox5.Controls.Add(this.rdbSearchB);
			this.groupBox5.Location = new System.Drawing.Point(513, 263);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(100, 101);
			this.groupBox5.TabIndex = 9;
			this.groupBox5.TabStop = false;
			// 
			// rdbSearchB
			// 
			this.rdbSearchB.Location = new System.Drawing.Point(6, 14);
			this.rdbSearchB.Name = "rdbSearchB";
			this.rdbSearchB.Size = new System.Drawing.Size(87, 20);
			this.rdbSearchB.TabIndex = 0;
			this.rdbSearchB.TabStop = true;
			this.rdbSearchB.Text = "Book";
			this.rdbSearchB.UseVisualStyleBackColor = true;
			this.rdbSearchB.CheckedChanged += new System.EventHandler(this.RdbSearchBCheckedChanged);
			// 
			// rdbSearchN
			// 
			this.rdbSearchN.Location = new System.Drawing.Point(6, 40);
			this.rdbSearchN.Name = "rdbSearchN";
			this.rdbSearchN.Size = new System.Drawing.Size(87, 20);
			this.rdbSearchN.TabIndex = 1;
			this.rdbSearchN.TabStop = true;
			this.rdbSearchN.Text = "News";
			this.rdbSearchN.UseVisualStyleBackColor = true;
			// 
			// rdbSearchM
			// 
			this.rdbSearchM.Location = new System.Drawing.Point(6, 66);
			this.rdbSearchM.Name = "rdbSearchM";
			this.rdbSearchM.Size = new System.Drawing.Size(94, 20);
			this.rdbSearchM.TabIndex = 2;
			this.rdbSearchM.TabStop = true;
			this.rdbSearchM.Text = "Magazine";
			this.rdbSearchM.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 396);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Library";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RadioButton rdbSearchB;
		private System.Windows.Forms.RadioButton rdbSearchN;
		private System.Windows.Forms.RadioButton rdbSearchM;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.RadioButton rdbBook;
		private System.Windows.Forms.RadioButton rdbMagazine;
		private System.Windows.Forms.RadioButton rdbNewspaper;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPoet;
		private System.Windows.Forms.TextBox txtPage;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNumber;
		private System.Windows.Forms.TextBox txtMonth;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtDate;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtQuatity;
		private System.Windows.Forms.DataGrid dgshow;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
