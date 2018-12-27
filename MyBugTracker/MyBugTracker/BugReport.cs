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
    public partial class BugReport : Form
    {
        public BugReport()
        {
            InitializeComponent();
        }

        public DataTable Select_bug()
        {
            //Database connection
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            //Holding data from database
            DataTable dt = new DataTable();
            try
            {
                //Getting data from database using dataadapter 
                MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bugreport", conn);


                sda.Fill(dt);//It means the fill in our database

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
            return dt;

        }
        public DataTable Search_bug(string keyword)
        {


            //Database connection
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            //Getting data from database using DataAdapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM bugreport WHERE project LIKE '%" + keyword + "%'", conn);
            //Holding data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//It means the fill in database
            return dt;

        }
        private void reportDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            if (browse.ShowDialog() == DialogResult.OK)
            {

                lbl_img_path.Text = browse.FileName;
                pictureBox_bugimg.Image = new Bitmap(browse.FileName);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            int BugID = 0;
            if (textBox_bugid.Text.Trim() != "")
            {
                BugID = int.Parse(textBox_bugid.Text.Trim());
            }
            string ProjectTitle = comboBox_project.Text.ToString();
            string BugTitle = textBox_bugtitle.Text.Trim();
            string BugDescription = textBox_bugissue.Text.Trim();
            string ReportDate = reportDate.Text.Trim();
            string ImagePath = lbl_img_path.Text.Trim();
            string status = combo_bugStatus.Text.ToString();

            //Getting loggedin user in added by field
            string loggeduser = LoginForm.uname;
            string reportedby = loggeduser;
            ReportDate = DateTime.Now.ToString("yyyy-MM-dd");


            try
            {
                //Database connection
                MySqlCommand sda = new MySqlCommand("INSERT INTO bugreport (project, bugtitle, bugissue, reportdate,status,image,reportedby) VALUES ('" + this.comboBox_project.Text + "','" + this.textBox_bugtitle.Text + "','" + this.textBox_bugissue.Text + "','" + this.reportDate.Text + "','" + this.combo_bugStatus.Text + "','" + this.lbl_img_path.Text + "',@reportedby)", conn);
                sda.Parameters.AddWithValue("@reportedby", reportedby);
                conn.Open();
                int rows = sda.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Bug added to database. click ok to continue");
                    //Refresh Data Grid View
                    BugReport vb = new BugReport();
                    DataTable dt = vb.Select_bug();
                    dataGridView.DataSource = dt;
                    //Clear all the Input fields
                    textBox_bugid.Clear();
                    comboBox_project.Text = "";
                    textBox_bugtitle.Clear();
                    textBox_bugissue.Clear();
                    reportDate.Text = "";
                    lbl_img_path.Text = "path";
                    combo_bugStatus.Text = "";
                }
                else
                {
                    MessageBox.Show("Bug failed to database. click ok to continue");

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

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            //get keyword from textbox 
            string keyword = textBox_search.Text;
            BugReport vb1 = new BugReport();
            if (keyword != null)
            {
                DataTable dt = vb1.Search_bug(keyword);
                dataGridView.DataSource = dt;

            }
            else
            {
                //show all user from database
                DataTable dt = vb1.Select_bug();
                dataGridView.DataSource = dt;
            }

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            string type = LoginForm.usertype;
            if (type == "Admin")
            {
                //Admin Dashboard
                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Hide();
            }
            else
            {
                //User Dashboard
                UserPanel home = new UserPanel();
                home.Show();
                this.Close();
            }
        }

        private void Bug_Load(object sender, EventArgs e)
        {
            BugReport vb = new BugReport();
            DataTable dt = vb.Select_bug();
            dataGridView.DataSource = dt;
            string type = LoginForm.usertype;
            if (type == "Admin")
            {
                label_header.Text = "Manage bug";
            }
            else
            {
                label_header.Text = "Enter a new bug";
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //Checking if the user is admin or user or debugger
            string type = LoginForm.usertype;
            if (type == "Admin")
            {
                //Database connection
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");

                MySqlCommand sda = new MySqlCommand("DELETE FROM bugreport WHERE id='" + this.textBox_bugid.Text + "'", conn);
                conn.Open();

                //Step 6: Execute cmd
                int rows = sda.ExecuteNonQuery();
                //if sda is success rows value is greater than 0
                if (rows > 0)
                {
                    MessageBox.Show("Bug Deleted Successfully. Thank You.");
                    //Refresh Data Grid View
                    BugReport vb = new BugReport();
                    DataTable dt = vb.Select_bug();
                    dataGridView.DataSource = dt;
                    //Clear all the Input fields
                    textBox_bugid.Clear();
                    comboBox_project.Text = "";
                    textBox_bugtitle.Clear();
                    textBox_bugissue.Clear();
                    reportDate.Text = "";
                    lbl_img_path.Text = "path";
                    combo_bugStatus.Text = "";

                }
                else
                {
                    //Delete Failed Message
                    MessageBox.Show("Failed to delte bug. Please Try Again.");
                }

            }
            else
            {
                //Display message
                MessageBox.Show("Sorry! You are not allowed to remove any data.");
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            int BugID = 0;
            if (textBox_bugid.Text.Trim() != "")
            {
                BugID = int.Parse(textBox_bugid.Text.Trim());
            }
            string ProjectTitle = comboBox_project.Text.ToString();
            string BugTitle = textBox_bugtitle.Text.Trim();
            string BugDescription = textBox_bugissue.Text.Trim();
            string ReportDate = reportDate.Text.Trim();
            string ImagePath = lbl_img_path.Text.Trim();
            string status = combo_bugStatus.Text.ToString();
            string loggedusertype = LoginForm.usertype;

            string reportedby = loggedusertype;

            ReportDate = DateTime.Now.ToString("yyyy-MM-dd");


            try
            {
                //Database connection
                MySqlCommand sda = new MySqlCommand("update bugreport set project='" + this.comboBox_project.Text + "',bugtitle='" + this.textBox_bugtitle.Text + "',bugissue='" + this.textBox_bugissue.Text + "',reportdate='" + this.reportDate.Text + "',status='" + this.combo_bugStatus.Text + "',image='" + this.lbl_img_path.Text + "' where bugreport.id='" + this.textBox_bugid.Text + "'", conn);
                conn.Open();

                int rows = sda.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Bug updated. click ok to continue");
                    //Refresh Data Grid View
                    BugReport vb = new BugReport();
                    DataTable dt = vb.Select_bug();
                    dataGridView.DataSource = dt;
                    //Clearing the fields
                    textBox_bugid.Clear();
                    comboBox_project.Text = "";
                    textBox_bugtitle.Clear();
                    textBox_bugissue.Clear();
                    reportDate.Text = "";
                    lbl_img_path.Text = "path";
                    combo_bugStatus.Text = "";
                }
                else
                {
                    MessageBox.Show("Bug failed to update. click ok to continue");

                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Close Connection
                conn.Close();
            }

        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox_bugid.Text = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            comboBox_project.Text = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            textBox_bugtitle.Text = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            textBox_bugissue.Text = dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            reportDate.Text = dataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            combo_bugStatus.Text = dataGridView.Rows[rowIndex].Cells[5].Value.ToString();

            lbl_img_path.Text = dataGridView.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void pictureBox_bugimg_Click(object sender, EventArgs e)
        {

        }
    }
}
