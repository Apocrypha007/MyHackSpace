using System;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BugReport bg = new BugReport();
            bg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AssignBugTo aab = new AssignBugTo();
            aab.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewBugHistory fixbug = new ViewBugHistory();
            fixbug.Show();
        }
    }
}
