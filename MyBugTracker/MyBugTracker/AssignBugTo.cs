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
    public partial class AssignBugTo : Form
    {
        public AssignBugTo()
        {
            InitializeComponent();
        }

        public DataTable SelectBug()
        {
            //Database connection
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            DataTable dt = new DataTable();

            try
            {

                //Getting data from database using DataAdapter 
                MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bugreport", conn);

                //Create a Datatable to hold the records from database
                //Step 5:Open Connection
                conn.Open();

                //Step 6: Use Adapter to Fill dt
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step 8: Close Connection
                conn.Close();
            }
            return dt;
        }

        public DataTable Selectutype()
        {
            //Database Connection
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            DataTable dt = new DataTable();

            try
            {

                //Getting data from database using DataAdapter 
                MySqlDataAdapter sda = new MySqlDataAdapter("Select username from userdetails where usertype='programmer'", conn);

                //Create a Datatable to hold the records from database
                //Step 5:Open Connection
                conn.Open();

                //Step 6: Use Adapter to Fill dt
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step 8: Close Connection
                conn.Close();
            }
            return dt;
        }

        private void AssignBugTo_Load(object sender, EventArgs e)
        {
            //Datatable created to hold the categories from database
            AssignBugTo a = new AssignBugTo();
            DataTable dtassign = a.Selectutype();
            //Specify datasource for assigned box
            comboBox_assign.DataSource = dtassign;
            //Specify display member and valuemenber for combobox
            comboBox_assign.DisplayMember = "username";
            comboBox_assign.ValueMember = "username";
            //Data Gird view 
            AssignBugTo vu = new AssignBugTo
();
            DataTable dt = vu.SelectBug();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //Step 0: Find the index of the row clicked
            int index = e.RowIndex;

            //Step 1: Get Values from Row Clicked
            string BugID = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string BugTitle = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string ProjectTitle = dataGridView1.Rows[index].Cells[1].Value.ToString();

            //Step2: Write Values to the textbox to assign user
            textBox_bugID.Text = BugID;
            textBox_BugTitle.Text = BugTitle;

        }

        private void comboBox_assign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_appoint_Click(object sender, EventArgs e)
        {
            int BugID = 0;
            if (textBox_bugID.Text.Trim() != "")
            {
                BugID = int.Parse(textBox_bugID.Text.Trim());
            }
            string BugTitle = textBox_BugTitle.Text.Trim();

            //Database connection
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            try
            {
                MySqlCommand sda = new MySqlCommand("update bugreport set assignedto='" + this.comboBox_assign.Text + "' WHERE bugreport.id= '" + this.textBox_bugID.Text + "'", conn);
                //Open Connection
                conn.Open();
                int rows = sda.ExecuteNonQuery();
                //if Inserted rows is greater is greater than 0
                //Else set isSuccess to false, Save Failed

                if (rows > 0)
                {
                    MessageBox.Show("Bug Assigned. click ok to continue");
                    //Refresh Data Grid View
                    AssignBugTo vb = new AssignBugTo();
                    DataTable dt = vb.SelectBug();
                    dataGridView1.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Bug failed to Assigned. click ok to continue");

                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //CLose Connection
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_bugTitle_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
