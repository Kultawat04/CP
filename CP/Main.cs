using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member memberf = new Member();
            this.Controls.Add(memberf);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Exit this window?";
            string title = "Exit Windows";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_form loginf = new login_form();
            loginf.Show();
            this.Hide();
        }

        
        }
    }

