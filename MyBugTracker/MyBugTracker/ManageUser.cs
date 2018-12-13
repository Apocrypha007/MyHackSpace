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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public DataTable Select_user()
        {
            //Database connection
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            //Getting data from database using DataAdapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from userdetails", conn);
            //Holding data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill in our database
            return dt;
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            // Data Grid View
            ManageUser vu = new ManageUser();
            DataTable dt = vu.Select_user();
            dataGridView1.DataSource = dt;
        }
        public DataTable Search(string keyword)
        {
            //Database connection
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            //Getting data from database using DataAdapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM userdetails WHERE username LIKE '%" + keyword + "%'", conn);
            //Holding data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//It means the fill in our database
            return dt;

        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            //Get keyword from textbox 
            string keyword = text_search.Text;
            ManageUser vu1 = new ManageUser();
            //Check if keywords have value or not
            if (keyword != null)
            {
                //show user based based on keywords
                DataTable dt = vu1.Search(keyword);
                dataGridView1.DataSource = dt;
            }
            else
            {
                //show all user from database
                DataTable dt = vu1.Select_user();
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            // Data Grid View
            ManageUser vu = new ManageUser();
            DataTable dt = vu.Select_user();
            dataGridView1.DataSource = dt;
        }
    }
}
