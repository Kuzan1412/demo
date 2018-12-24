/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/10/2018
 * Time: 10:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CANBO
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
			this.rdbWaiter = new System.Windows.Forms.RadioButton();
			this.rdbWorker = new System.Windows.Forms.RadioButton();
			this.rdbEngine = new System.Windows.Forms.RadioButton();
			this.rdbBoy = new System.Windows.Forms.RadioButton();
			this.rdbGirl = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtMisson = new System.Windows.Forms.TextBox();
			this.txtLv = new System.Windows.Forms.TextBox();
			this.txtMajor = new System.Windows.Forms.TextBox();
			this.txtDob = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.dgshow = new System.Windows.Forms.DataGrid();
			this.btnAdd = new System.Windows.Forms.Button();
			this.Clear = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(427, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Management Staff";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rdbWaiter
			// 
			this.rdbWaiter.Checked = true;
			this.rdbWaiter.Location = new System.Drawing.Point(55, 165);
			this.rdbWaiter.Name = "rdbWaiter";
			this.rdbWaiter.Size = new System.Drawing.Size(77, 22);
			this.rdbWaiter.TabIndex = 1;
			this.rdbWaiter.TabStop = true;
			this.rdbWaiter.Text = "Waiter";
			this.rdbWaiter.UseVisualStyleBackColor = true;
			this.rdbWaiter.CheckedChanged += new System.EventHandler(this.RdbWaiterCheckedChanged);
			// 
			// rdbWorker
			// 
			this.rdbWorker.Location = new System.Drawing.Point(55, 221);
			this.rdbWorker.Name = "rdbWorker";
			this.rdbWorker.Size = new System.Drawing.Size(77, 22);
			this.rdbWorker.TabIndex = 2;
			this.rdbWorker.Text = "Woker";
			this.rdbWorker.UseVisualStyleBackColor = true;
			this.rdbWorker.CheckedChanged += new System.EventHandler(this.RdbWorkerCheckedChanged);
			// 
			// rdbEngine
			// 
			this.rdbEngine.Location = new System.Drawing.Point(55, 193);
			this.rdbEngine.Name = "rdbEngine";
			this.rdbEngine.Size = new System.Drawing.Size(94, 22);
			this.rdbEngine.TabIndex = 3;
			this.rdbEngine.Text = "Engineer";
			this.rdbEngine.UseVisualStyleBackColor = true;
			this.rdbEngine.CheckedChanged += new System.EventHandler(this.RdbEngineCheckedChanged);
			// 
			// rdbBoy
			// 
			this.rdbBoy.Checked = true;
			this.rdbBoy.Location = new System.Drawing.Point(6, 36);
			this.rdbBoy.Name = "rdbBoy";
			this.rdbBoy.Size = new System.Drawing.Size(77, 22);
			this.rdbBoy.TabIndex = 4;
			this.rdbBoy.TabStop = true;
			this.rdbBoy.Text = "Boy";
			this.rdbBoy.UseVisualStyleBackColor = true;
			// 
			// rdbGirl
			// 
			this.rdbGirl.Location = new System.Drawing.Point(6, 15);
			this.rdbGirl.Name = "rdbGirl";
			this.rdbGirl.Size = new System.Drawing.Size(77, 22);
			this.rdbGirl.TabIndex = 5;
			this.rdbGirl.Text = "Girl";
			this.rdbGirl.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Yellow;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(12, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 22);
			this.label2.TabIndex = 6;
			this.label2.Text = "Address";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Yellow;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(12, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 22);
			this.label3.TabIndex = 8;
			this.label3.Text = "Name";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Yellow;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(257, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 22);
			this.label4.TabIndex = 9;
			this.label4.Text = "Gender";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Yellow;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(12, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 22);
			this.label5.TabIndex = 10;
			this.label5.Text = "Dob";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Yellow;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(165, 221);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 22);
			this.label6.TabIndex = 11;
			this.label6.Text = "LV";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Yellow;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(165, 195);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 22);
			this.label7.TabIndex = 12;
			this.label7.Text = "Major";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Yellow;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(165, 167);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 22);
			this.label8.TabIndex = 13;
			this.label8.Text = "Misson";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Yellow;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Location = new System.Drawing.Point(14, 140);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 22);
			this.label9.TabIndex = 14;
			this.label9.Text = "Position";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label10.Location = new System.Drawing.Point(138, 177);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(21, 10);
			this.label10.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label11.Location = new System.Drawing.Point(138, 230);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(21, 10);
			this.label11.TabIndex = 16;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label12.Location = new System.Drawing.Point(138, 205);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(21, 10);
			this.label12.TabIndex = 17;
			// 
			// txtMisson
			// 
			this.txtMisson.Location = new System.Drawing.Point(234, 165);
			this.txtMisson.Name = "txtMisson";
			this.txtMisson.Size = new System.Drawing.Size(100, 22);
			this.txtMisson.TabIndex = 18;
			this.txtMisson.TextChanged += new System.EventHandler(this.TxtMissonTextChanged);
			// 
			// txtLv
			// 
			this.txtLv.Location = new System.Drawing.Point(234, 221);
			this.txtLv.Name = "txtLv";
			this.txtLv.Size = new System.Drawing.Size(100, 22);
			this.txtLv.TabIndex = 19;
			this.txtLv.TextChanged += new System.EventHandler(this.TxtLvTextChanged);
			// 
			// txtMajor
			// 
			this.txtMajor.Location = new System.Drawing.Point(234, 193);
			this.txtMajor.Name = "txtMajor";
			this.txtMajor.Size = new System.Drawing.Size(100, 22);
			this.txtMajor.TabIndex = 20;
			this.txtMajor.TextChanged += new System.EventHandler(this.TxtMajorTextChanged);
			// 
			// txtDob
			// 
			this.txtDob.Location = new System.Drawing.Point(118, 109);
			this.txtDob.Name = "txtDob";
			this.txtDob.Size = new System.Drawing.Size(100, 22);
			this.txtDob.TabIndex = 21;
			this.txtDob.TextChanged += new System.EventHandler(this.TxtDobTextChanged);
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(119, 81);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(100, 22);
			this.txtAddress.TabIndex = 22;
			this.txtAddress.TextChanged += new System.EventHandler(this.TxtAddressTextChanged);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(118, 47);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 22);
			this.txtName.TabIndex = 23;
			this.txtName.TextChanged += new System.EventHandler(this.TxtNameTextChanged);
			// 
			// dgshow
			// 
			this.dgshow.DataMember = "";
			this.dgshow.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgshow.Location = new System.Drawing.Point(12, 294);
			this.dgshow.Name = "dgshow";
			this.dgshow.Size = new System.Drawing.Size(425, 93);
			this.dgshow.TabIndex = 24;
			this.dgshow.CurrentCellChanged += new System.EventHandler(this.DgshowCurrentCellChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(14, 265);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 25;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// Clear
			// 
			this.Clear.Location = new System.Drawing.Point(95, 265);
			this.Clear.Name = "Clear";
			this.Clear.Size = new System.Drawing.Size(75, 23);
			this.Clear.TabIndex = 26;
			this.Clear.Text = "Clear";
			this.Clear.UseVisualStyleBackColor = true;
			this.Clear.Click += new System.EventHandler(this.ClearClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(176, 265);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 27;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(257, 265);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 28;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
			this.groupBox1.Controls.Add(this.rdbGirl);
			this.groupBox1.Controls.Add(this.rdbBoy);
			this.groupBox1.Location = new System.Drawing.Point(257, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(100, 59);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(449, 399);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.Clear);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgshow);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtDob);
			this.Controls.Add(this.txtMajor);
			this.Controls.Add(this.txtLv);
			this.Controls.Add(this.txtMisson);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.rdbWaiter);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rdbEngine);
			this.Controls.Add(this.rdbWorker);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "CANBO";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button Clear;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGrid dgshow;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtDob;
		private System.Windows.Forms.TextBox txtMajor;
		private System.Windows.Forms.TextBox txtLv;
		private System.Windows.Forms.TextBox txtMisson;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rdbGirl;
		private System.Windows.Forms.RadioButton rdbBoy;
		private System.Windows.Forms.RadioButton rdbEngine;
		private System.Windows.Forms.RadioButton rdbWorker;
		private System.Windows.Forms.RadioButton rdbWaiter;
		private System.Windows.Forms.Label label1;
	}
}
