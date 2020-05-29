namespace CP
{
    partial class Member
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Member_Data = new System.Windows.Forms.GroupBox();
            this.Date_Member = new System.Windows.Forms.DateTimePicker();
            this.DateMember_LB = new System.Windows.Forms.Label();
            this.MemberID_TB = new System.Windows.Forms.TextBox();
            this.Member_LB = new System.Windows.Forms.Label();
            this.Clear_BT = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date_Birth = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Delete_BT = new System.Windows.Forms.Button();
            this.Update_BT = new System.Windows.Forms.Button();
            this.GetData_BT = new System.Windows.Forms.Button();
            this.Age_TB = new System.Windows.Forms.TextBox();
            this.LastN_TB = new System.Windows.Forms.TextBox();
            this.FirstN_TB = new System.Windows.Forms.TextBox();
            this.IDCard_TB = new System.Windows.Forms.TextBox();
            this.Add_BT = new System.Windows.Forms.Button();
            this.Famale_RB = new System.Windows.Forms.RadioButton();
            this.Male_RB = new System.Windows.Forms.RadioButton();
            this.Datebirth_LB = new System.Windows.Forms.Label();
            this.Depart_LB = new System.Windows.Forms.Label();
            this.Gender_LB = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.IDCard_LB = new System.Windows.Forms.Label();
            this.LastN_LB = new System.Windows.Forms.Label();
            this.FirstN_LB = new System.Windows.Forms.Label();
            this.Depart_CB = new System.Windows.Forms.ComboBox();
            this.Member_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Member_Data
            // 
            this.Member_Data.Controls.Add(this.Date_Member);
            this.Member_Data.Controls.Add(this.DateMember_LB);
            this.Member_Data.Controls.Add(this.MemberID_TB);
            this.Member_Data.Controls.Add(this.Member_LB);
            this.Member_Data.Controls.Add(this.Clear_BT);
            this.Member_Data.Controls.Add(this.DataGridView1);
            this.Member_Data.Controls.Add(this.Date_Birth);
            this.Member_Data.Controls.Add(this.Label2);
            this.Member_Data.Controls.Add(this.Label1);
            this.Member_Data.Controls.Add(this.Delete_BT);
            this.Member_Data.Controls.Add(this.Update_BT);
            this.Member_Data.Controls.Add(this.GetData_BT);
            this.Member_Data.Controls.Add(this.Age_TB);
            this.Member_Data.Controls.Add(this.LastN_TB);
            this.Member_Data.Controls.Add(this.FirstN_TB);
            this.Member_Data.Controls.Add(this.IDCard_TB);
            this.Member_Data.Controls.Add(this.Add_BT);
            this.Member_Data.Controls.Add(this.Famale_RB);
            this.Member_Data.Controls.Add(this.Male_RB);
            this.Member_Data.Controls.Add(this.Datebirth_LB);
            this.Member_Data.Controls.Add(this.Depart_LB);
            this.Member_Data.Controls.Add(this.Gender_LB);
            this.Member_Data.Controls.Add(this.Label4);
            this.Member_Data.Controls.Add(this.IDCard_LB);
            this.Member_Data.Controls.Add(this.LastN_LB);
            this.Member_Data.Controls.Add(this.FirstN_LB);
            this.Member_Data.Controls.Add(this.Depart_CB);
            this.Member_Data.Location = new System.Drawing.Point(62, 58);
            this.Member_Data.Name = "Member_Data";
            this.Member_Data.Size = new System.Drawing.Size(1089, 663);
            this.Member_Data.TabIndex = 34;
            this.Member_Data.TabStop = false;
            this.Member_Data.Text = "Member";
            // 
            // Date_Member
            // 
            this.Date_Member.Location = new System.Drawing.Point(181, 403);
            this.Date_Member.Name = "Date_Member";
            this.Date_Member.Size = new System.Drawing.Size(200, 20);
            this.Date_Member.TabIndex = 11;
            this.Date_Member.Value = new System.DateTime(2020, 4, 9, 15, 11, 19, 0);
            // 
            // DateMember_LB
            // 
            this.DateMember_LB.AutoSize = true;
            this.DateMember_LB.Location = new System.Drawing.Point(41, 410);
            this.DateMember_LB.Name = "DateMember_LB";
            this.DateMember_LB.Size = new System.Drawing.Size(102, 13);
            this.DateMember_LB.TabIndex = 30;
            this.DateMember_LB.Text = "Date of Membership";
            // 
            // MemberID_TB
            // 
            this.MemberID_TB.Location = new System.Drawing.Point(181, 82);
            this.MemberID_TB.Name = "MemberID_TB";
            this.MemberID_TB.Size = new System.Drawing.Size(102, 20);
            this.MemberID_TB.TabIndex = 1;
            // 
            // Member_LB
            // 
            this.Member_LB.AutoSize = true;
            this.Member_LB.Location = new System.Drawing.Point(40, 89);
            this.Member_LB.Name = "Member_LB";
            this.Member_LB.Size = new System.Drawing.Size(59, 13);
            this.Member_LB.TabIndex = 26;
            this.Member_LB.Text = "Member ID";
            // 
            // Clear_BT
            // 
            this.Clear_BT.Location = new System.Drawing.Point(389, 127);
            this.Clear_BT.Name = "Clear_BT";
            this.Clear_BT.Size = new System.Drawing.Size(58, 34);
            this.Clear_BT.TabIndex = 13;
            this.Clear_BT.Text = "CLEAR";
            this.Clear_BT.UseVisualStyleBackColor = true;
            this.Clear_BT.Click += new System.EventHandler(this.Clear_BT_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(500, 36);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.Size = new System.Drawing.Size(532, 586);
            this.DataGridView1.TabIndex = 17;
            // 
            // Date_Birth
            // 
            this.Date_Birth.Location = new System.Drawing.Point(181, 360);
            this.Date_Birth.Name = "Date_Birth";
            this.Date_Birth.Size = new System.Drawing.Size(200, 20);
            this.Date_Birth.TabIndex = 10;
            this.Date_Birth.Value = new System.DateTime(2020, 4, 9, 15, 11, 3, 0);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(40, 36);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(423, 13);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "If you already have information and want to update Please fill Member ID and Clic" +
    "k GET.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(340, 81);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 13);
            this.Label1.TabIndex = 20;
            // 
            // Delete_BT
            // 
            this.Delete_BT.BackColor = System.Drawing.Color.Maroon;
            this.Delete_BT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Delete_BT.Location = new System.Drawing.Point(319, 587);
            this.Delete_BT.Name = "Delete_BT";
            this.Delete_BT.Size = new System.Drawing.Size(62, 29);
            this.Delete_BT.TabIndex = 16;
            this.Delete_BT.Text = "DELETE";
            this.Delete_BT.UseVisualStyleBackColor = false;
            this.Delete_BT.Click += new System.EventHandler(this.Delete_BT_Click);
            // 
            // Update_BT
            // 
            this.Update_BT.Location = new System.Drawing.Point(221, 587);
            this.Update_BT.Name = "Update_BT";
            this.Update_BT.Size = new System.Drawing.Size(62, 29);
            this.Update_BT.TabIndex = 15;
            this.Update_BT.Text = "UPDATE";
            this.Update_BT.UseVisualStyleBackColor = true;
            this.Update_BT.Click += new System.EventHandler(this.Update_BT_Click);
            // 
            // GetData_BT
            // 
            this.GetData_BT.Location = new System.Drawing.Point(389, 68);
            this.GetData_BT.Name = "GetData_BT";
            this.GetData_BT.Size = new System.Drawing.Size(58, 34);
            this.GetData_BT.TabIndex = 12;
            this.GetData_BT.Text = "GET";
            this.GetData_BT.UseVisualStyleBackColor = true;
            this.GetData_BT.Click += new System.EventHandler(this.GetData_BT_Click);
            // 
            // Age_TB
            // 
            this.Age_TB.Location = new System.Drawing.Point(181, 280);
            this.Age_TB.Name = "Age_TB";
            this.Age_TB.Size = new System.Drawing.Size(48, 20);
            this.Age_TB.TabIndex = 8;
            // 
            // LastN_TB
            // 
            this.LastN_TB.Location = new System.Drawing.Point(181, 201);
            this.LastN_TB.Name = "LastN_TB";
            this.LastN_TB.Size = new System.Drawing.Size(102, 20);
            this.LastN_TB.TabIndex = 5;
            // 
            // FirstN_TB
            // 
            this.FirstN_TB.Location = new System.Drawing.Point(181, 160);
            this.FirstN_TB.Name = "FirstN_TB";
            this.FirstN_TB.Size = new System.Drawing.Size(102, 20);
            this.FirstN_TB.TabIndex = 4;
            // 
            // IDCard_TB
            // 
            this.IDCard_TB.Location = new System.Drawing.Point(181, 120);
            this.IDCard_TB.Name = "IDCard_TB";
            this.IDCard_TB.Size = new System.Drawing.Size(157, 20);
            this.IDCard_TB.TabIndex = 3;
            // 
            // Add_BT
            // 
            this.Add_BT.Location = new System.Drawing.Point(124, 587);
            this.Add_BT.Name = "Add_BT";
            this.Add_BT.Size = new System.Drawing.Size(62, 29);
            this.Add_BT.TabIndex = 14;
            this.Add_BT.Text = "ADD";
            this.Add_BT.UseVisualStyleBackColor = true;
            this.Add_BT.Click += new System.EventHandler(this.Add_BT_Click);
            // 
            // Famale_RB
            // 
            this.Famale_RB.AutoSize = true;
            this.Famale_RB.Location = new System.Drawing.Point(241, 243);
            this.Famale_RB.Name = "Famale_RB";
            this.Famale_RB.Size = new System.Drawing.Size(59, 17);
            this.Famale_RB.TabIndex = 7;
            this.Famale_RB.Text = "Famale";
            this.Famale_RB.UseVisualStyleBackColor = true;
            // 
            // Male_RB
            // 
            this.Male_RB.AutoSize = true;
            this.Male_RB.Location = new System.Drawing.Point(187, 243);
            this.Male_RB.Name = "Male_RB";
            this.Male_RB.Size = new System.Drawing.Size(48, 17);
            this.Male_RB.TabIndex = 6;
            this.Male_RB.Text = "Male";
            this.Male_RB.UseVisualStyleBackColor = true;
            // 
            // Datebirth_LB
            // 
            this.Datebirth_LB.AutoSize = true;
            this.Datebirth_LB.Location = new System.Drawing.Point(40, 367);
            this.Datebirth_LB.Name = "Datebirth_LB";
            this.Datebirth_LB.Size = new System.Drawing.Size(66, 13);
            this.Datebirth_LB.TabIndex = 7;
            this.Datebirth_LB.Text = "Date of Birth";
            // 
            // Depart_LB
            // 
            this.Depart_LB.AutoSize = true;
            this.Depart_LB.Location = new System.Drawing.Point(40, 327);
            this.Depart_LB.Name = "Depart_LB";
            this.Depart_LB.Size = new System.Drawing.Size(62, 13);
            this.Depart_LB.TabIndex = 6;
            this.Depart_LB.Text = "Department";
            // 
            // Gender_LB
            // 
            this.Gender_LB.AutoSize = true;
            this.Gender_LB.Location = new System.Drawing.Point(40, 247);
            this.Gender_LB.Name = "Gender_LB";
            this.Gender_LB.Size = new System.Drawing.Size(42, 13);
            this.Gender_LB.TabIndex = 5;
            this.Gender_LB.Text = "Gender";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(40, 287);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(26, 13);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Age";
            // 
            // IDCard_LB
            // 
            this.IDCard_LB.AutoSize = true;
            this.IDCard_LB.Location = new System.Drawing.Point(41, 127);
            this.IDCard_LB.Name = "IDCard_LB";
            this.IDCard_LB.Size = new System.Drawing.Size(43, 13);
            this.IDCard_LB.TabIndex = 3;
            this.IDCard_LB.Text = "ID Card";
            // 
            // LastN_LB
            // 
            this.LastN_LB.AutoSize = true;
            this.LastN_LB.Location = new System.Drawing.Point(41, 204);
            this.LastN_LB.Name = "LastN_LB";
            this.LastN_LB.Size = new System.Drawing.Size(58, 13);
            this.LastN_LB.TabIndex = 2;
            this.LastN_LB.Text = "Last Name";
            // 
            // FirstN_LB
            // 
            this.FirstN_LB.AutoSize = true;
            this.FirstN_LB.Location = new System.Drawing.Point(40, 167);
            this.FirstN_LB.Name = "FirstN_LB";
            this.FirstN_LB.Size = new System.Drawing.Size(57, 13);
            this.FirstN_LB.TabIndex = 1;
            this.FirstN_LB.Text = "First Name";
            // 
            // Depart_CB
            // 
            this.Depart_CB.FormattingEnabled = true;
            this.Depart_CB.Items.AddRange(new object[] {
            "Accounting",
            "Bussiness-Deverlopment",
            "HR",
            "IT",
            "Management",
            "Maintenance",
            "Production-Technology",
            "Marketing",
            "Purchasing",
            "QC",
            "QMS",
            "RD",
            "Safety-Enviroment",
            "Store",
            "Logistic",
            "Production",
            "Planning",
            "Internal-Audit",
            "Factory-Management"});
            this.Depart_CB.Location = new System.Drawing.Point(181, 319);
            this.Depart_CB.Name = "Depart_CB";
            this.Depart_CB.Size = new System.Drawing.Size(133, 21);
            this.Depart_CB.TabIndex = 9;
            this.Depart_CB.Text = " ";
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Member_Data);
            this.Name = "Member";
            this.Size = new System.Drawing.Size(1202, 771);
            this.Load += new System.EventHandler(this.Member_Load);
            this.Member_Data.ResumeLayout(false);
            this.Member_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox Member_Data;
        internal System.Windows.Forms.Label DateMember_LB;
        internal System.Windows.Forms.TextBox MemberID_TB;
        internal System.Windows.Forms.Label Member_LB;
        internal System.Windows.Forms.Button Clear_BT;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DateTimePicker Date_Birth;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Delete_BT;
        internal System.Windows.Forms.Button Update_BT;
        internal System.Windows.Forms.Button GetData_BT;
        internal System.Windows.Forms.TextBox Age_TB;
        internal System.Windows.Forms.TextBox LastN_TB;
        internal System.Windows.Forms.TextBox FirstN_TB;
        internal System.Windows.Forms.TextBox IDCard_TB;
        internal System.Windows.Forms.Button Add_BT;
        internal System.Windows.Forms.RadioButton Famale_RB;
        internal System.Windows.Forms.RadioButton Male_RB;
        internal System.Windows.Forms.Label Datebirth_LB;
        internal System.Windows.Forms.Label Depart_LB;
        internal System.Windows.Forms.Label Gender_LB;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label IDCard_LB;
        internal System.Windows.Forms.Label LastN_LB;
        internal System.Windows.Forms.Label FirstN_LB;
        internal System.Windows.Forms.ComboBox Depart_CB;
        internal System.Windows.Forms.DateTimePicker Date_Member;
    }
}
