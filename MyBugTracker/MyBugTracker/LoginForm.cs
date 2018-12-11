using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
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
    public partial class LoginForm : Form
    {
        public static string uname, userpasswor, usertype;
        public static int uid;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Username
            string user = textBox_user.Text;
            //Password
            string pass = textBox_pwd.Text;
            //Usertype
            string uType = comboBox_utype.Text.Trim();

            //Database connection
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=bugbase");

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select count(*) from userdetails where username='" + textBox_user.Text + "'and password='" + textBox_pwd.Text + "' and usertype='" + comboBox_utype.Text + "'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);//

                if (user.Equals("") || pass.Equals("") || uType.Equals(""))
                {

                    MessageBox.Show("Fill all the forms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dt.Rows[0][0].ToString() == "1")
                {
                    // loggedIn = user;
                    // loggedIN_utype = uType;
                    userpasswor = pass;
                    uname = user;

                    usertype = uType;
                    switch (uType)
                    {
                        case "Admin":
                            {

                                // Admin Panel
                                //  loggedIN_utype = uType;
                                AdminPanel admin = new AdminPanel();
                                MessageBox.Show("Login was succesful.");
                                admin.Show();
                                this.Hide();

                                break;

                            }
                        //user
                        case "User":
                            {

                                // User Dashboard is displayed
                                UserPanel umenu = new UserPanel();
                                MessageBox.Show("Login was succesful.");
                                umenu.Show();
                                this.Hide();
                                break;
                            }
                        case "Programmer":
                            {
                                //Programmer Dashboard is displayed
                                ProgrammerPanel pmenu = new ProgrammerPanel();
                                MessageBox.Show("Login was succesful.");
                                pmenu.Show();
                                this.Hide();
                                break;
                            }
                    }
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step :CLose Connection
                conn.Close();
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerButton1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }
    }
}
