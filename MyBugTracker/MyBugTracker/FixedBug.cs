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
    public partial class FixedBug : Form
    {
        public FixedBug()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataTable Select_fixed()
        {
            //Database connection
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            //Getting data from database using DataAdapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bugsolve ", conn);
            //Holding data from database
            DataTable dt = new DataTable();
            sda.Fill(dt); //It means to fill in our database
            return dt;
        }

        private void FixedBug_Load(object sender, EventArgs e)
        {
            //Data Grid View
            FixedBug vu = new FixedBug();
            DataTable dt = vu.Select_fixed();
            dgv_fixed.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
