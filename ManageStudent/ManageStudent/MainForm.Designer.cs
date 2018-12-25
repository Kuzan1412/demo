/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/25/2018
 * Time: 6:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ManageStudent
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
			this.rdbC = new System.Windows.Forms.RadioButton();
			this.rdbA = new System.Windows.Forms.RadioButton();
			this.rdbB = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtPriority = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtMath = new System.Windows.Forms.TextBox();
			this.txtGeoraphy = new System.Windows.Forms.TextBox();
			this.txtPhysicalB = new System.Windows.Forms.TextBox();
			this.txtLiterature = new System.Windows.Forms.TextBox();
			this.txtHistory = new System.Windows.Forms.TextBox();
			this.txtChemistryA = new System.Windows.Forms.TextBox();
			this.txtChemistryB = new System.Windows.Forms.TextBox();
			this.txtPhysicalA = new System.Windows.Forms.TextBox();
			this.txtBiology = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.Edit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dgshow = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(22, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(22, 83);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Priority";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(22, 124);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Address";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(22, 46);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 28);
			this.label4.TabIndex = 3;
			this.label4.Text = "Id";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(22, 180);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(331, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Marks";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(22, 206);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 178);
			this.label6.TabIndex = 5;
			this.label6.Text = "||||||||||||||||||||||";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(335, 206);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(19, 178);
			this.label7.TabIndex = 6;
			this.label7.Text = "||||||||||||||||||||||";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// rdbC
			// 
			this.rdbC.Location = new System.Drawing.Point(254, 206);
			this.rdbC.Name = "rdbC";
			this.rdbC.Size = new System.Drawing.Size(36, 24);
			this.rdbC.TabIndex = 7;
			this.rdbC.TabStop = true;
			this.rdbC.Text = "C";
			this.rdbC.UseVisualStyleBackColor = true;
			this.rdbC.CheckedChanged += new System.EventHandler(this.RdbCCheckedChanged);
			// 
			// rdbA
			// 
			this.rdbA.Location = new System.Drawing.Point(37, 202);
			this.rdbA.Name = "rdbA";
			this.rdbA.Size = new System.Drawing.Size(36, 24);
			this.rdbA.TabIndex = 8;
			this.rdbA.TabStop = true;
			this.rdbA.Text = "A";
			this.rdbA.UseVisualStyleBackColor = true;
			this.rdbA.CheckedChanged += new System.EventHandler(this.RdbACheckedChanged);
			// 
			// rdbB
			// 
			this.rdbB.Location = new System.Drawing.Point(148, 206);
			this.rdbB.Name = "rdbB";
			this.rdbB.Size = new System.Drawing.Size(36, 24);
			this.rdbB.TabIndex = 9;
			this.rdbB.TabStop = true;
			this.rdbB.Text = "B";
			this.rdbB.UseVisualStyleBackColor = true;
			this.rdbB.CheckedChanged += new System.EventHandler(this.RdbBCheckedChanged);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Yellow;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(37, 238);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "Math";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Yellow;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Location = new System.Drawing.Point(37, 340);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 23);
			this.label9.TabIndex = 11;
			this.label9.Text = "Chemistry";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Yellow;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Location = new System.Drawing.Point(37, 289);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 23);
			this.label10.TabIndex = 12;
			this.label10.Text = "Physical";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(124, 206);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(18, 178);
			this.label11.TabIndex = 13;
			this.label11.Text = "||||||||||||||||||||||";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Yellow;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Location = new System.Drawing.Point(239, 238);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(90, 23);
			this.label12.TabIndex = 14;
			this.label12.Text = "Geography";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Yellow;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label13.Location = new System.Drawing.Point(137, 340);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(81, 23);
			this.label13.TabIndex = 15;
			this.label13.Text = "Chemistry";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Yellow;
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label14.Location = new System.Drawing.Point(137, 289);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(81, 23);
			this.label14.TabIndex = 16;
			this.label14.Text = "Biology";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Yellow;
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label15.Location = new System.Drawing.Point(137, 238);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(81, 23);
			this.label15.TabIndex = 17;
			this.label15.Text = "Physical";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(224, 210);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(18, 178);
			this.label16.TabIndex = 18;
			this.label16.Text = "||||||||||||||||||||||";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Yellow;
			this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label17.Location = new System.Drawing.Point(239, 340);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(90, 23);
			this.label17.TabIndex = 19;
			this.label17.Text = "Literature";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Yellow;
			this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label18.Location = new System.Drawing.Point(239, 289);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(90, 23);
			this.label18.TabIndex = 20;
			this.label18.Text = "History";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(124, 15);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 22);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.TxtNameTextChanged);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(125, 52);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 22);
			this.txtId.TabIndex = 1;
			this.txtId.TextChanged += new System.EventHandler(this.TxtIdTextChanged);
			// 
			// txtPriority
			// 
			this.txtPriority.Location = new System.Drawing.Point(125, 89);
			this.txtPriority.Name = "txtPriority";
			this.txtPriority.Size = new System.Drawing.Size(100, 22);
			this.txtPriority.TabIndex = 2;
			this.txtPriority.TextChanged += new System.EventHandler(this.TxtPriorityTextChanged);
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(125, 127);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(100, 22);
			this.txtAddress.TabIndex = 3;
			this.txtAddress.TextChanged += new System.EventHandler(this.TxtAddressTextChanged);
			// 
			// txtMath
			// 
			this.txtMath.Location = new System.Drawing.Point(37, 264);
			this.txtMath.Name = "txtMath";
			this.txtMath.Size = new System.Drawing.Size(81, 22);
			this.txtMath.TabIndex = 4;
			this.txtMath.TextChanged += new System.EventHandler(this.TxtMathTextChanged);
			// 
			// txtGeoraphy
			// 
			this.txtGeoraphy.Location = new System.Drawing.Point(239, 264);
			this.txtGeoraphy.Name = "txtGeoraphy";
			this.txtGeoraphy.Size = new System.Drawing.Size(90, 22);
			this.txtGeoraphy.TabIndex = 10;
			this.txtGeoraphy.TextChanged += new System.EventHandler(this.TxtGeoraphyTextChanged);
			// 
			// txtPhysicalB
			// 
			this.txtPhysicalB.Location = new System.Drawing.Point(137, 264);
			this.txtPhysicalB.Name = "txtPhysicalB";
			this.txtPhysicalB.Size = new System.Drawing.Size(81, 22);
			this.txtPhysicalB.TabIndex = 7;
			this.txtPhysicalB.TextChanged += new System.EventHandler(this.TxtPhysicalBTextChanged);
			// 
			// txtLiterature
			// 
			this.txtLiterature.Location = new System.Drawing.Point(239, 366);
			this.txtLiterature.Name = "txtLiterature";
			this.txtLiterature.Size = new System.Drawing.Size(90, 22);
			this.txtLiterature.TabIndex = 12;
			this.txtLiterature.TextChanged += new System.EventHandler(this.TxtLiteratureTextChanged);
			// 
			// txtHistory
			// 
			this.txtHistory.Location = new System.Drawing.Point(239, 315);
			this.txtHistory.Name = "txtHistory";
			this.txtHistory.Size = new System.Drawing.Size(90, 22);
			this.txtHistory.TabIndex = 11;
			this.txtHistory.TextChanged += new System.EventHandler(this.TxtHistoryTextChanged);
			// 
			// txtChemistryA
			// 
			this.txtChemistryA.Location = new System.Drawing.Point(37, 366);
			this.txtChemistryA.Name = "txtChemistryA";
			this.txtChemistryA.Size = new System.Drawing.Size(81, 22);
			this.txtChemistryA.TabIndex = 6;
			this.txtChemistryA.TextChanged += new System.EventHandler(this.TxtChemistryATextChanged);
			// 
			// txtChemistryB
			// 
			this.txtChemistryB.Location = new System.Drawing.Point(137, 366);
			this.txtChemistryB.Name = "txtChemistryB";
			this.txtChemistryB.Size = new System.Drawing.Size(81, 22);
			this.txtChemistryB.TabIndex = 9;
			this.txtChemistryB.TextChanged += new System.EventHandler(this.TxtChemistryBTextChanged);
			// 
			// txtPhysicalA
			// 
			this.txtPhysicalA.Location = new System.Drawing.Point(37, 315);
			this.txtPhysicalA.Name = "txtPhysicalA";
			this.txtPhysicalA.Size = new System.Drawing.Size(81, 22);
			this.txtPhysicalA.TabIndex = 5;
			this.txtPhysicalA.TextChanged += new System.EventHandler(this.TxtPhysicalATextChanged);
			// 
			// txtBiology
			// 
			this.txtBiology.Location = new System.Drawing.Point(137, 315);
			this.txtBiology.Name = "txtBiology";
			this.txtBiology.Size = new System.Drawing.Size(81, 22);
			this.txtBiology.TabIndex = 8;
			this.txtBiology.TextChanged += new System.EventHandler(this.TxtBiologyTextChanged);
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(29, 393);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(325, 10);
			this.label19.TabIndex = 34;
			this.label19.Text = "--------------------------------------------------------------------------";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(360, 7);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(19, 373);
			this.label20.TabIndex = 35;
			this.label20.Text = "||||||||||||||||||||||||||||||||||||||||||||||";
			this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Edit
			// 
			this.Edit.Location = new System.Drawing.Point(254, 49);
			this.Edit.Name = "Edit";
			this.Edit.Size = new System.Drawing.Size(75, 23);
			this.Edit.TabIndex = 37;
			this.Edit.Text = "Edit";
			this.Edit.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(254, 89);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 38;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(254, 127);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 39;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(137, 155);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 40;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(254, 15);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 41;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.BtnLoadClick);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(386, 46);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(100, 22);
			this.txtSearch.TabIndex = 43;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(385, 17);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 44;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearchClick);
			// 
			// dgshow
			// 
			this.dgshow.DataMember = "";
			this.dgshow.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgshow.Location = new System.Drawing.Point(385, 83);
			this.dgshow.Name = "dgshow";
			this.dgshow.Size = new System.Drawing.Size(352, 305);
			this.dgshow.TabIndex = 45;
			this.dgshow.CurrentCellChanged += new System.EventHandler(this.DgshowCurrentCellChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(749, 412);
			this.Controls.Add(this.dgshow);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.Edit);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.txtBiology);
			this.Controls.Add(this.txtPhysicalA);
			this.Controls.Add(this.txtChemistryB);
			this.Controls.Add(this.txtChemistryA);
			this.Controls.Add(this.txtHistory);
			this.Controls.Add(this.txtLiterature);
			this.Controls.Add(this.txtPhysicalB);
			this.Controls.Add(this.txtGeoraphy);
			this.Controls.Add(this.txtMath);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtPriority);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.rdbB);
			this.Controls.Add(this.rdbA);
			this.Controls.Add(this.rdbC);
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
			this.Text = "ManageStudent";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgshow)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGrid dgshow;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button Edit;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtBiology;
		private System.Windows.Forms.TextBox txtPhysicalA;
		private System.Windows.Forms.TextBox txtChemistryB;
		private System.Windows.Forms.TextBox txtChemistryA;
		private System.Windows.Forms.TextBox txtHistory;
		private System.Windows.Forms.TextBox txtLiterature;
		private System.Windows.Forms.TextBox txtPhysicalB;
		private System.Windows.Forms.TextBox txtGeoraphy;
		private System.Windows.Forms.TextBox txtMath;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPriority;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtName;
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
		private System.Windows.Forms.RadioButton rdbB;
		private System.Windows.Forms.RadioButton rdbA;
		private System.Windows.Forms.RadioButton rdbC;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
