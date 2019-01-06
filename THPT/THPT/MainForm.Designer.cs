/*
 * Created by SharpDevelop.
 * User: user
 * Date: 1/6/2019
 * Time: 3:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace THPT
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.txtDob = new System.Windows.Forms.TextBox();
			this.txtClass = new System.Windows.Forms.TextBox();
			this.txtK = new System.Windows.Forms.TextBox();
			this.dgshow = new System.Windows.Forms.DataGrid();
			this.rdbI = new System.Windows.Forms.RadioButton();
			this.rdbTemp = new System.Windows.Forms.RadioButton();
			this.rdbII = new System.Windows.Forms.RadioButton();
			this.btnCount = new System.Windows.Forms.Button();
			this.dgDocument = new System.Windows.Forms.DataGrid();
			this.label10 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.cbAdd = new System.Windows.Forms.ComboBox();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgDocument)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(701, 10);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(15, 423);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(527, 10);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(12, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(10, 381);
			this.label3.TabIndex = 2;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(532, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 381);
			this.label4.TabIndex = 3;
			this.label4.Text = "label4";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(28, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Name";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(28, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Dob";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(28, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Age";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Location = new System.Drawing.Point(28, 137);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 23);
			this.label9.TabIndex = 8;
			this.label9.Text = "Address";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(235, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 23);
			this.label8.TabIndex = 9;
			this.label8.Text = "Class";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(235, 101);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(71, 23);
			this.label11.TabIndex = 11;
			this.label11.Text = "K";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Location = new System.Drawing.Point(235, 67);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(71, 23);
			this.label12.TabIndex = 12;
			this.label12.Text = "Term";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(28, 173);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(132, 173);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 14;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(344, 173);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 15;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(235, 173);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 16;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(451, 173);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(107, 34);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 22);
			this.txtName.TabIndex = 18;
			this.txtName.TextChanged += new System.EventHandler(this.TxtNameTextChanged);
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(107, 68);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(100, 22);
			this.txtAge.TabIndex = 19;
			this.txtAge.Visible = false;
			this.txtAge.TextChanged += new System.EventHandler(this.TxtAgeTextChanged);
			// 
			// txtDob
			// 
			this.txtDob.Location = new System.Drawing.Point(107, 102);
			this.txtDob.Name = "txtDob";
			this.txtDob.Size = new System.Drawing.Size(100, 22);
			this.txtDob.TabIndex = 20;
			this.txtDob.TextChanged += new System.EventHandler(this.TxtDobTextChanged);
			// 
			// txtClass
			// 
			this.txtClass.Location = new System.Drawing.Point(319, 34);
			this.txtClass.Name = "txtClass";
			this.txtClass.Size = new System.Drawing.Size(100, 22);
			this.txtClass.TabIndex = 22;
			this.txtClass.TextChanged += new System.EventHandler(this.TxtClassTextChanged);
			// 
			// txtK
			// 
			this.txtK.Location = new System.Drawing.Point(319, 102);
			this.txtK.Name = "txtK";
			this.txtK.Size = new System.Drawing.Size(100, 22);
			this.txtK.TabIndex = 24;
			this.txtK.TextChanged += new System.EventHandler(this.TxtKTextChanged);
			// 
			// dgshow
			// 
			this.dgshow.DataMember = "";
			this.dgshow.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgshow.Location = new System.Drawing.Point(28, 238);
			this.dgshow.Name = "dgshow";
			this.dgshow.Size = new System.Drawing.Size(498, 66);
			this.dgshow.TabIndex = 25;
			this.dgshow.CurrentCellChanged += new System.EventHandler(this.DgshowCurrentCellChanged);
			// 
			// rdbI
			// 
			this.rdbI.Checked = true;
			this.rdbI.Location = new System.Drawing.Point(319, 68);
			this.rdbI.Name = "rdbI";
			this.rdbI.Size = new System.Drawing.Size(31, 24);
			this.rdbI.TabIndex = 26;
			this.rdbI.TabStop = true;
			this.rdbI.Text = "I";
			this.rdbI.UseVisualStyleBackColor = true;
			// 
			// rdbTemp
			// 
			this.rdbTemp.Location = new System.Drawing.Point(436, 68);
			this.rdbTemp.Name = "rdbTemp";
			this.rdbTemp.Size = new System.Drawing.Size(68, 24);
			this.rdbTemp.TabIndex = 27;
			this.rdbTemp.Text = "Temp";
			this.rdbTemp.UseVisualStyleBackColor = true;
			// 
			// rdbII
			// 
			this.rdbII.Location = new System.Drawing.Point(372, 68);
			this.rdbII.Name = "rdbII";
			this.rdbII.Size = new System.Drawing.Size(34, 24);
			this.rdbII.TabIndex = 28;
			this.rdbII.Text = "II";
			this.rdbII.UseVisualStyleBackColor = true;
			// 
			// btnCount
			// 
			this.btnCount.Location = new System.Drawing.Point(560, 37);
			this.btnCount.Name = "btnCount";
			this.btnCount.Size = new System.Drawing.Size(75, 23);
			this.btnCount.TabIndex = 29;
			this.btnCount.Text = "Count";
			this.btnCount.UseVisualStyleBackColor = true;
			this.btnCount.Click += new System.EventHandler(this.BtnSearchClick);
			// 
			// dgDocument
			// 
			this.dgDocument.DataMember = "";
			this.dgDocument.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgDocument.Location = new System.Drawing.Point(28, 334);
			this.dgDocument.Name = "dgDocument";
			this.dgDocument.Size = new System.Drawing.Size(498, 80);
			this.dgDocument.TabIndex = 30;
			this.dgDocument.CurrentCellChanged += new System.EventHandler(this.DgDocumentCurrentCellChanged);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Cyan;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(45, 308);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(459, 23);
			this.label10.TabIndex = 31;
			this.label10.Text = "Document of Student";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Cyan;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label13.ForeColor = System.Drawing.Color.Red;
			this.label13.Location = new System.Drawing.Point(46, 210);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(459, 23);
			this.label13.TabIndex = 32;
			this.label13.Text = "Resume";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbAdd
			// 
			this.cbAdd.FormattingEnabled = true;
			this.cbAdd.Location = new System.Drawing.Point(107, 137);
			this.cbAdd.Name = "cbAdd";
			this.cbAdd.Size = new System.Drawing.Size(121, 24);
			this.cbAdd.TabIndex = 33;
			this.cbAdd.SelectedIndexChanged += new System.EventHandler(this.CbAddSelectedIndexChanged);
			this.cbAdd.TextChanged += new System.EventHandler(this.CbAddTextChanged);
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point(560, 70);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(136, 22);
			this.txtCount.TabIndex = 34;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(275, 138);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(162, 23);
			this.button1.TabIndex = 35;
			this.button1.Text = "Student (dob 1985)";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 442);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.cbAdd);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dgDocument);
			this.Controls.Add(this.btnCount);
			this.Controls.Add(this.rdbII);
			this.Controls.Add(this.rdbTemp);
			this.Controls.Add(this.rdbI);
			this.Controls.Add(this.dgshow);
			this.Controls.Add(this.txtK);
			this.Controls.Add(this.txtClass);
			this.Controls.Add(this.txtDob);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "THPT";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgDocument)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtCount;
		private System.Windows.Forms.ComboBox cbAdd;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGrid dgDocument;
		private System.Windows.Forms.Button btnCount;
		private System.Windows.Forms.RadioButton rdbII;
		private System.Windows.Forms.RadioButton rdbTemp;
		private System.Windows.Forms.RadioButton rdbI;
		private System.Windows.Forms.DataGrid dgshow;
		private System.Windows.Forms.TextBox txtK;
		private System.Windows.Forms.TextBox txtClass;
		private System.Windows.Forms.TextBox txtDob;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
