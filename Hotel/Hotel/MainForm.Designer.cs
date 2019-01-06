/*
 * Created by SharpDevelop.
 * User: user
 * Date: 1/3/2019
 * Time: 8:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hotel
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
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtCost = new System.Windows.Forms.TextBox();
			this.txtDob = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.rdbS = new System.Windows.Forms.RadioButton();
			this.rdbLarge = new System.Windows.Forms.RadioButton();
			this.rdbM = new System.Windows.Forms.RadioButton();
			this.dgshow = new System.Windows.Forms.DataGrid();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(29, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Yellow;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(29, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Dob(YY)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Yellow;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(29, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "ID";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Yellow;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(29, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Age";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(13, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(10, 350);
			this.label5.TabIndex = 4;
			this.label5.Text = "label5";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(460, 17);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(10, 350);
			this.label6.TabIndex = 5;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(29, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(425, 10);
			this.label7.TabIndex = 6;
			this.label7.Text = "label7";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Yellow;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(228, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(79, 20);
			this.label8.TabIndex = 7;
			this.label8.Text = "Type";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Yellow;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Location = new System.Drawing.Point(228, 107);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 20);
			this.label9.TabIndex = 8;
			this.label9.Text = "Cost";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Yellow;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Location = new System.Drawing.Point(228, 46);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(79, 20);
			this.label10.TabIndex = 9;
			this.label10.Text = "TimeStay";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(107, 40);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 22);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.TxtNameTextChanged);
			// 
			// txtCost
			// 
			this.txtCost.Location = new System.Drawing.Point(313, 105);
			this.txtCost.Name = "txtCost";
			this.txtCost.Size = new System.Drawing.Size(100, 22);
			this.txtCost.TabIndex = 6;
			this.txtCost.Visible = false;
			// 
			// txtDob
			// 
			this.txtDob.Location = new System.Drawing.Point(107, 141);
			this.txtDob.Name = "txtDob";
			this.txtDob.Size = new System.Drawing.Size(100, 22);
			this.txtDob.TabIndex = 3;
			this.txtDob.TextChanged += new System.EventHandler(this.TxtDobTextChanged);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(107, 107);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 22);
			this.txtID.TabIndex = 2;
			this.txtID.TextChanged += new System.EventHandler(this.TxtIDTextChanged);
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(107, 73);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(100, 22);
			this.txtAge.TabIndex = 1;
			this.txtAge.Visible = false;
			this.txtAge.TextChanged += new System.EventHandler(this.TxtAgeTextChanged);
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(313, 46);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(100, 22);
			this.txtTime.TabIndex = 5;
			this.txtTime.TextChanged += new System.EventHandler(this.TxtTimeTextChanged);
			// 
			// rdbS
			// 
			this.rdbS.Location = new System.Drawing.Point(313, 69);
			this.rdbS.Name = "rdbS";
			this.rdbS.Size = new System.Drawing.Size(36, 24);
			this.rdbS.TabIndex = 4;
			this.rdbS.TabStop = true;
			this.rdbS.Text = "S";
			this.rdbS.UseVisualStyleBackColor = true;
			this.rdbS.CheckedChanged += new System.EventHandler(this.RdbSCheckedChanged);
			// 
			// rdbLarge
			// 
			this.rdbLarge.Location = new System.Drawing.Point(406, 69);
			this.rdbLarge.Name = "rdbLarge";
			this.rdbLarge.Size = new System.Drawing.Size(36, 24);
			this.rdbLarge.TabIndex = 18;
			this.rdbLarge.TabStop = true;
			this.rdbLarge.Text = "L";
			this.rdbLarge.UseVisualStyleBackColor = true;
			this.rdbLarge.CheckedChanged += new System.EventHandler(this.RdbLargeCheckedChanged);
			// 
			// rdbM
			// 
			this.rdbM.Location = new System.Drawing.Point(364, 69);
			this.rdbM.Name = "rdbM";
			this.rdbM.Size = new System.Drawing.Size(36, 24);
			this.rdbM.TabIndex = 19;
			this.rdbM.TabStop = true;
			this.rdbM.Text = "M";
			this.rdbM.UseVisualStyleBackColor = true;
			this.rdbM.CheckedChanged += new System.EventHandler(this.RdbMCheckedChanged);
			// 
			// dgshow
			// 
			this.dgshow.DataMember = "";
			this.dgshow.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgshow.Location = new System.Drawing.Point(29, 219);
			this.dgshow.Name = "dgshow";
			this.dgshow.Size = new System.Drawing.Size(425, 148);
			this.dgshow.TabIndex = 20;
			this.dgshow.CurrentCellChanged += new System.EventHandler(this.DgshowCurrentCellChanged);
			this.dgshow.Navigate += new System.Windows.Forms.NavigateEventHandler(this.DgshowNavigate);
			// 
			// btnAccept
			// 
			this.btnAccept.Location = new System.Drawing.Point(29, 178);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(75, 23);
			this.btnAccept.TabIndex = 21;
			this.btnAccept.Text = "Accept";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Click += new System.EventHandler(this.BtnAcceptClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(132, 178);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 22;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(232, 178);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 23;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(483, 376);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.dgshow);
			this.Controls.Add(this.rdbM);
			this.Controls.Add(this.rdbLarge);
			this.Controls.Add(this.rdbS);
			this.Controls.Add(this.txtTime);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.txtDob);
			this.Controls.Add(this.txtCost);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
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
			this.Text = "Hotel";
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.DataGrid dgshow;
		private System.Windows.Forms.RadioButton rdbM;
		private System.Windows.Forms.RadioButton rdbLarge;
		private System.Windows.Forms.RadioButton rdbS;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtDob;
		private System.Windows.Forms.TextBox txtCost;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
