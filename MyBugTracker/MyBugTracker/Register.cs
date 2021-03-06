﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBugTracker
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void registerButton2_Click(object sender, EventArgs e)
        {
            string Uname = txt_user.Text.Trim();
            string Pwd = txt_pwd.Text.Trim();
            string confirm_pwd = txt_confirmPwd.Text.Trim();
            string UserType = combo_utype.Text.Trim();

            if (Pwd.Equals(confirm_pwd))
            {
                //Database connection 
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
                //Database connection
                MySqlCommand sda = new MySqlCommand("INSERT INTO userdetails (username, password, confirmPassword, usertype) VALUES ('" + this.txt_user.Text + "','" + this.txt_pwd.Text + "','" + this.txt_confirmPwd.Text + "','" + this.combo_utype.Text + "')", conn);
                MySqlDataReader MyReader;
                conn.Open();
                MyReader = sda.ExecuteReader();
                MessageBox.Show("You are now registered. Please click ok");
                //view login page
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
            else
            {
                //Display message
                MessageBox.Show("Password didnot matched !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_confirmPwd.Focus();
            }

        }
    }
}
