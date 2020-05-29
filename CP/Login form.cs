using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CP
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void LoginBT_Click(object sender, EventArgs e)
           
        {
            String query = "SELECT * FROM Userlogin WHERE Username = '" + UsernameTB.Text + "' AND Password = '" + PwTB.Text + "'";
            OdbcConnection con = new OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa");
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            cmd.ExecuteScalar();
            if (dt.Rows.Count > 0)
            {
            Main mainf = new Main();
                mainf.Show();
                this.Hide();
            }
            con.Close();
                    
        }

        private void Close_BT_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Windows";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
