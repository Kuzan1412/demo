/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/26/2018
 * Time: 9:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Town
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
			this.txtHome = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.gbInformation = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.txtMajor = new System.Windows.Forms.TextBox();
			this.txtDob = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dgshow = new System.Windows.Forms.DataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtMember = new System.Windows.Forms.TextBox();
			this.txtNow = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.gbInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "House\' s number";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(6, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Amount Members";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(12, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 378);
			this.label3.TabIndex = 2;
			this.label3.Text = "||||||||||||||||||||||||||||||||||||";
			// 
			// txtHome
			// 
			this.txtHome.Location = new System.Drawing.Point(141, 18);
			this.txtHome.Name = "txtHome";
			this.txtHome.Size = new System.Drawing.Size(100, 22);
			this.txtHome.TabIndex = 3;
			this.txtHome.TextChanged += new System.EventHandler(this.TxtHomeTextChanged);
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(486, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 378);
			this.label4.TabIndex = 5;
			this.label4.Text = "||||||||||||||||||||||||||||||||||||";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(25, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(455, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" +
			"||||||||||||||||||||||||||||||||||";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(25, 364);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(455, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" +
			"||||||||||||||||||||||||||||||";
			// 
			// gbInformation
			// 
			this.gbInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.gbInformation.Controls.Add(this.label9);
			this.gbInformation.Controls.Add(this.txtAge);
			this.gbInformation.Controls.Add(this.txtMajor);
			this.gbInformation.Controls.Add(this.txtDob);
			this.gbInformation.Controls.Add(this.txtName);
			this.gbInformation.Controls.Add(this.label10);
			this.gbInformation.Controls.Add(this.label8);
			this.gbInformation.Controls.Add(this.label7);
			this.gbInformation.Location = new System.Drawing.Point(32, 110);
			this.gbInformation.Name = "gbInformation";
			this.gbInformation.Size = new System.Drawing.Size(447, 93);
			this.gbInformation.TabIndex = 9;
			this.gbInformation.TabStop = false;
			this.gbInformation.Text = "Detail information";
			this.gbInformation.Visible = false;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Location = new System.Drawing.Point(223, 23);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 23);
			this.label9.TabIndex = 18;
			this.label9.Text = "Age";
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(311, 24);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(111, 22);
			this.txtAge.TabIndex = 17;
			this.txtAge.TextChanged += new System.EventHandler(this.TxtAgeTextChanged);
			// 
			// txtMajor
			// 
			this.txtMajor.Location = new System.Drawing.Point(311, 57);
			this.txtMajor.Name = "txtMajor";
			this.txtMajor.Size = new System.Drawing.Size(111, 22);
			this.txtMajor.TabIndex = 16;
			// 
			// txtDob
			// 
			this.txtDob.Location = new System.Drawing.Point(94, 55);
			this.txtDob.Name = "txtDob";
			this.txtDob.Size = new System.Drawing.Size(111, 22);
			this.txtDob.TabIndex = 15;
			this.txtDob.TextChanged += new System.EventHandler(this.TxtDobTextChanged);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(94, 21);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(111, 22);
			this.txtName.TabIndex = 14;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Location = new System.Drawing.Point(223, 57);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 23);
			this.label10.TabIndex = 13;
			this.label10.Text = "Major";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(6, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "Dob";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(6, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Full Name";
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(32, 209);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(75, 23);
			this.btnShow.TabIndex = 10;
			this.btnShow.Text = "SHOW";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(126, 209);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 11;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(218, 209);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(311, 209);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 13;
			this.btnLoad.Text = "LOAD";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.BtnLoadClick);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(404, 209);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// dgshow
			// 
			this.dgshow.DataMember = "";
			this.dgshow.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgshow.Location = new System.Drawing.Point(32, 238);
			this.dgshow.Name = "dgshow";
			this.dgshow.Size = new System.Drawing.Size(448, 123);
			this.dgshow.TabIndex = 15;
			this.dgshow.CurrentCellChanged += new System.EventHandler(this.DgshowCurrentCellChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.groupBox1.Controls.Add(this.txtMember);
			this.groupBox1.Controls.Add(this.txtHome);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(32, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(255, 74);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Town";
			// 
			// txtMember
			// 
			this.txtMember.Location = new System.Drawing.Point(141, 46);
			this.txtMember.Name = "txtMember";
			this.txtMember.Size = new System.Drawing.Size(100, 22);
			this.txtMember.TabIndex = 5;
			this.txtMember.TextChanged += new System.EventHandler(this.TxtMemberTextChanged);
			// 
			// txtNow
			// 
			this.txtNow.Location = new System.Drawing.Point(326, 75);
			this.txtNow.Name = "txtNow";
			this.txtNow.Size = new System.Drawing.Size(100, 22);
			this.txtNow.TabIndex = 6;
			this.txtNow.TextChanged += new System.EventHandler(this.TxtNowTextChanged);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(326, 47);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 23);
			this.label11.TabIndex = 19;
			this.label11.Text = "Now";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(522, 393);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtNow);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgshow);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.gbInformation);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Town";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.gbInformation.ResumeLayout(false);
			this.gbInformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtNow;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGrid dgshow;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtDob;
		private System.Windows.Forms.TextBox txtMajor;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.GroupBox gbInformation;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMember;
		private System.Windows.Forms.TextBox txtHome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			
		}
		
		
		
	}
}
