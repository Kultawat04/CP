using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CP
{
    public partial class Member : UserControl
    {
        public Member()
        {
            InitializeComponent();
        }

        public void refresh_datagrid()
        {
            string query = "SELECT * FROM Member";
            OdbcConnection con = new OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa");
            OdbcDataAdapter da = new OdbcDataAdapter(query, con);
            DataSet ds = new DataSet();

            con.Open();
            da.Fill(ds, "Member");
            DataGridView1.DataSource = ds.Tables["Member"];
            con.Close();
        }

        public void Clear_Member()
        {
            MemberID_TB.Text = "";
            IDCard_TB.Text = "";
            FirstN_TB.Text = "";
            LastN_TB.Text = "";
            Age_TB.Text = "";
            Depart_CB.Text = "";
            Date_Birth.Text = "";
            Date_Member.Text = "";

        }

        private void Clear_BT_Click(object sender, EventArgs e)
        {
            Clear_Member();
        }


        private void Member_Load(object sender, EventArgs e)
        {
            refresh_datagrid();
        }

        private void GetData_BT_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Member WHERE [Member ID] = '" + MemberID_TB.Text + "' ";
                OdbcConnection con = new OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa");
                OdbcCommand cmd = new OdbcCommand(query, con);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    IDCard_TB.Text = dt.Rows[0]["ID Card"].ToString();
                    FirstN_TB.Text = dt.Rows[0]["First Name"].ToString();
                    LastN_TB.Text = dt.Rows[0]["Last Name"].ToString();

                    if (dt.Rows[0]["Gender"].ToString() == "Male")
                    {
                        Male_RB.Checked = true;
                    }
                    else
                    {
                        Famale_RB.Checked = true;
                    }

                    Age_TB.Text = dt.Rows[0]["Age"].ToString();
                    Depart_CB.SelectedItem = dt.Rows[0]["Department"].ToString();
                    Date_Birth.Text = dt.Rows[0]["Date of Birth"].ToString();
                    Date_Member.Text = dt.Rows[0]["Date of Membership"].ToString();

                }
                else
                {
                    Clear_Member();
                    MessageBox.Show("Member ID does not exist. Please check again");

                }

                con.Close();
                refresh_datagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_BT_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "";
                if (Male_RB.Checked == true)
                {
                    gender = Male_RB.Text;
                }
                else
                {
                    gender = Famale_RB.Text;
                }

                string query = "INSERT INTO Member ([Member ID], [ID Card], [First Name], [Last Name], Gender, Age, Department, [Date of Birth], [Date of Membership]) VALUES ('" + MemberID_TB.Text + "', '" + IDCard_TB.Text + "', '" + FirstN_TB.Text + "', '" + LastN_TB.Text + "', '" + gender + "', '" + Age_TB.Text + "', '" + Depart_CB.SelectedItem + "', '" + Date_Birth.Value + "', '" + Date_Member.Value + "')";
                OdbcConnection con = new OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa");
                OdbcCommand cmd = new OdbcCommand(query, con);

                con.Open();
                if (MemberID_TB.Text == "" || IDCard_TB.Text == "") 
                {
                    MessageBox.Show("Member ID and ID Card must be not blank.", "Alert");
                }
                else
                {
                    if (MessageBox.Show("Do you want to Add?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("[Member ID]", MemberID_TB.Text);
                        cmd.Parameters.AddWithValue("[ID Card]", IDCard_TB.Text);
                        cmd.Parameters.AddWithValue("[First Name]", FirstN_TB.Text);
                        cmd.Parameters.AddWithValue("[Last Name]", LastN_TB.Text);
                        cmd.Parameters.AddWithValue("Gender", gender);
                        cmd.Parameters.AddWithValue("Age", Age_TB.Text);
                        cmd.Parameters.AddWithValue("Department", Depart_CB.SelectedItem);
                        cmd.Parameters.AddWithValue("Date of Birth", Date_Birth.Value);
                        cmd.Parameters.AddWithValue("Date of Membership", Date_Member.Value);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        MessageBox.Show("Successfully Added", "Success");
                        Clear_Member();
                    }
                }

                con.Close();
                refresh_datagrid();

            }

            catch
            {
                MessageBox.Show("Invalid or Duplicate Data, Please Check.", "Alert");
            }

        }


        private void Update_BT_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "";
                if (Male_RB.Checked == true)
                {
                    gender = Male_RB.Text;
                }
                else
                {
                    gender = Famale_RB.Text;
                }

                string query = "UPDATE Member SET [ID Card] = '" + IDCard_TB.Text + "', [First Name] = '" + FirstN_TB.Text + "', [Last Name] = '" + LastN_TB.Text + "', Gender = '" + gender + "', Age = '" + Age_TB.Text + "', Department = '" + Depart_CB.SelectedItem + "', [Date of Birth] = '" + Date_Birth.Value + "', [Date of Membership] = '" + Date_Member.Value + "' WHERE [Member ID] = '" + MemberID_TB.Text + "'";
                OdbcConnection con = new OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa");
                OdbcCommand cmd = new OdbcCommand(query, con);

                con.Open();
                if (MemberID_TB.Text == "")
                {
                    MessageBox.Show("Please fill Member ID for Update.", "Alert");
                }
                else
                {
                    if (MessageBox.Show("Do you want to Update?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("[Member ID]", MemberID_TB.Text);
                        cmd.Parameters.AddWithValue("[ID Card]", IDCard_TB.Text);
                        cmd.Parameters.AddWithValue("[First Name]", FirstN_TB.Text);
                        cmd.Parameters.AddWithValue("[Last Name]", LastN_TB.Text);
                        cmd.Parameters.AddWithValue("Gender", gender);
                        cmd.Parameters.AddWithValue("Age", Age_TB.Text);
                        cmd.Parameters.AddWithValue("Department", Depart_CB.SelectedItem);
                        cmd.Parameters.AddWithValue("Date of Birth", Date_Birth.Value);
                        cmd.Parameters.AddWithValue("Date of Membership", Date_Member.Value);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        MessageBox.Show("Successfully Updated", "Success");
                        Clear_Member();
                    }
                }

                con.Close();
                refresh_datagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Delete_BT_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Member WHERE [Member ID] = '" + MemberID_TB.Text + "'";
                OdbcConnection con = new OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa");
                OdbcCommand cmd = new OdbcCommand(query, con);

                con.Open();
                if (MemberID_TB.Text == "")
                {

                    MessageBox.Show("Please fill Member ID for Delete.", "Alert");
                }
                else
                {
                    if (MessageBox.Show("Do you want to Delete?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("[Member ID]", MemberID_TB.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        MessageBox.Show("Successfully Deleted", "Success");
                    }
                }

                con.Close();
                refresh_datagrid();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
    }
}