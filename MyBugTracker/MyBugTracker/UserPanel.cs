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
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
        }
    }
}
