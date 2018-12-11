using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBugTracker
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void txt_newPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            //string username = Form1.uname;
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");

            DataTable dt = new DataTable();
            MySqlCommand sdaa = new MySqlCommand("Select * from userdetails where username='" + LoginForm.uname + "'", conn);
            MySqlDataReader myreader;
            conn.Open();
            myreader = sdaa.ExecuteReader();
            while (myreader.Read())
            {
                string sid = myreader.GetInt32("id").ToString();

            }

        }

        private void buttonChangePwd_Click(object sender, EventArgs e)
        {

            string oldpwd = txt_oldpwd.Text;
            string newpwd = txt_newPwd.Text;
            //Database Connection
            string pas = LoginForm.userpasswor;
            string type = LoginForm.usertype;

            if (pas.Equals(txt_oldpwd.Text))
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
                // MessageBox.Show("password matched");
                MySqlCommand sda = new MySqlCommand("update userdetails set password='" + this.txt_newPwd.Text + "', confirmPassword='" + this.txt_newPwd.Text + "' where username='" + LoginForm.uname + "'", conn);
                //Open Connection
                conn.Open();
                int rows = sda.ExecuteNonQuery();

                //if Inserted rows is greater is greater than 0
                //Else set isSuccess to false, Save Failed


                if (rows > 0)
                {
                    MessageBox.Show("Password changed. Please click ok to continue");
                    //Dashboard page
                    if (type == "User")
                    {
                        UserPanel dash = new UserPanel();
                        dash.Show();
                        this.Hide();
                    }
                    else
                    {
                        //Dashboard page
                        ProgrammerPanel pdash = new ProgrammerPanel();
                        pdash.Show();
                        this.Hide();
                    }

                }
                else
                {

                    //Display message
                    MessageBox.Show("Password failed to changed. click ok to continue");

                }

            }
            else
            {
                //Display message
                MessageBox.Show("Old password didnot mathed");
            }
        }

    }
}
