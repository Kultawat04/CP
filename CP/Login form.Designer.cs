namespace CP
{
    partial class login_form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_GB = new System.Windows.Forms.GroupBox();
            this.Close_BT = new System.Windows.Forms.Button();
            this.PwTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.LoginBT = new System.Windows.Forms.Button();
            this.pwLB = new System.Windows.Forms.Label();
            this.UserLB = new System.Windows.Forms.Label();
            this.Login_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_GB
            // 
            this.Login_GB.Controls.Add(this.Close_BT);
            this.Login_GB.Controls.Add(this.PwTB);
            this.Login_GB.Controls.Add(this.UsernameTB);
            this.Login_GB.Controls.Add(this.LoginBT);
            this.Login_GB.Controls.Add(this.pwLB);
            this.Login_GB.Controls.Add(this.UserLB);
            this.Login_GB.Location = new System.Drawing.Point(79, 101);
            this.Login_GB.Name = "Login_GB";
            this.Login_GB.Size = new System.Drawing.Size(366, 175);
            this.Login_GB.TabIndex = 8;
            this.Login_GB.TabStop = false;
            this.Login_GB.Text = "Login";
            // 
            // Close_BT
            // 
            this.Close_BT.Location = new System.Drawing.Point(224, 118);
            this.Close_BT.Name = "Close_BT";
            this.Close_BT.Size = new System.Drawing.Size(62, 26);
            this.Close_BT.TabIndex = 4;
            this.Close_BT.Text = "Close";
            this.Close_BT.UseVisualStyleBackColor = true;
            this.Close_BT.Click += new System.EventHandler(this.Close_BT_Click);
            // 
            // PwTB
            // 
            this.PwTB.Location = new System.Drawing.Point(138, 83);
            this.PwTB.Name = "PwTB";
            this.PwTB.Size = new System.Drawing.Size(148, 20);
            this.PwTB.TabIndex = 2;
            this.PwTB.UseSystemPasswordChar = true;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(138, 40);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(148, 20);
            this.UsernameTB.TabIndex = 1;
            // 
            // LoginBT
            // 
            this.LoginBT.Location = new System.Drawing.Point(138, 118);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(62, 26);
            this.LoginBT.TabIndex = 3;
            this.LoginBT.Text = "Login";
            this.LoginBT.UseVisualStyleBackColor = true;
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // pwLB
            // 
            this.pwLB.AutoSize = true;
            this.pwLB.Location = new System.Drawing.Point(73, 90);
            this.pwLB.Name = "pwLB";
            this.pwLB.Size = new System.Drawing.Size(59, 13);
            this.pwLB.TabIndex = 2;
            this.pwLB.Text = "Password :";
            // 
            // UserLB
            // 
            this.UserLB.AutoSize = true;
            this.UserLB.Location = new System.Drawing.Point(71, 47);
            this.UserLB.Name = "UserLB";
            this.UserLB.Size = new System.Drawing.Size(61, 13);
            this.UserLB.TabIndex = 1;
            this.UserLB.Text = "Username :";
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 381);
            this.Controls.Add(this.Login_GB);
            this.Name = "login_form";
            this.Text = "CP";
            this.Login_GB.ResumeLayout(false);
            this.Login_GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox Login_GB;
        internal System.Windows.Forms.Button Close_BT;
        internal System.Windows.Forms.TextBox PwTB;
        internal System.Windows.Forms.TextBox UsernameTB;
        internal System.Windows.Forms.Button LoginBT;
        internal System.Windows.Forms.Label pwLB;
        internal System.Windows.Forms.Label UserLB;
    }
}

