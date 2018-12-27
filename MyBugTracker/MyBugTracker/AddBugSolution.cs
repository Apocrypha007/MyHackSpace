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
    public partial class AddBugSolution : Form
    {
        public AddBugSolution()
        {
            InitializeComponent();
        }

        private void txtbox_desc_Click(object sender, EventArgs e)
        {

        }

        private void lbl_reportDate_Click(object sender, EventArgs e)
        {

        }

        private void txt_class_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cls_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// This codes help to connect with database and helps to add the solution of bugs 
        /// to the availabe bug and errors.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
         
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            int BugID = 0;
            if (txtBox_bugID.Text.Trim() != "")
            {
                BugID = int.Parse(txtBox_bugID.Text.Trim());
            }
            string projectTitle = txtboxProject.Text.ToString();
            string BugTitle = txt_bugtitle.Text.Trim();
            string cls = txt_class.Text;
            string mthd = txt_method.Text;
            string line = txt_line.Text;
            string BugDescription = txtdes.Text.Trim();
            string bugsolved = txt_bugsol.Text;
            string ReportDate = reportDate.Text.Trim();
            string SolveDate = solvedate.Text.Trim();
            string status = cmbBox_status.Text.ToString();
            string loggedusr = LoginForm.uname;
            string BugFixedName = loggedusr;
            ReportDate = DateTime.Now.ToString("yyyy-MM-dd");
            SolveDate = DateTime.Now.ToString("yyyy-MM-dd");

            try
            {
                //Database connection established to insert data
                MySqlCommand sda = new MySqlCommand("INSERT INTO bugsolve (bugid, projectTitle, bugTitle, class,method,line,error,solution,reportdate,solvedate,status,BugFixedName) " +
                    "VALUES ('" + this.txtBox_bugID.Text + "','" + this.txtboxProject.Text + "','" + this.txt_bugtitle.Text + "','" + this.txt_class.Text + "','" + this.txt_method.Text + "','" + this.txt_line.Text + "'" +
                    ",'" + this.txtdes.Text + "','" + this.txt_bugsol.Text + "','" + this.reportDate.Text + "','" + this.solvedate.Text + "','" + this.cmbBox_status.Text + "',@BugFixedName)", conn);
                sda.Parameters.AddWithValue("@BugFixedName", BugFixedName);
                conn.Open();

                int rows = sda.ExecuteNonQuery();
              

                if (rows > 0)
                {
                    MessageBox.Show("Bug has been fixed. click ok to continue");
                    //Database connection
                    MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = bugbase");
                    //DataAdapter helps to get data from database
                    MySqlDataAdapter adapter = new MySqlDataAdapter("update bugreport set status='" + this.cmbBox_status.Text + "' where id='" + this.txtBox_bugID.Text + "'", conn);
                    //dt holds the data collected from database
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    //To fill in the database

                    AddBugSolution abs = new AddBugSolution();
                    dt = abs.SelectBug();
                    dgv_sol.DataSource = dt;

                    //To clear all the fields
                    txtboxProject.Clear();
                    txt_bugtitle.Clear();
                    txt_class.Clear();
                    txt_method.Clear();
                    txt_line.Clear();
                    txtdes.Clear();
                    txt_bugsol.Clear();
                }
                else
                {
                    MessageBox.Show("Bug failed to fixed. click ok to continue");

                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //CLosing the Connection
                conn.Close();
            }
        }

        /// <summary>
        /// This codes maintain database connection and dt helps to return data from the database
        /// and it holds the data in table.
        /// </summary>
        /// <returns>dt</returns>
        public DataTable SelectBug()
        {

            //Database connection
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugbase");
            //Getting data from database using DataAdapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bugreport where assignedto='" + LoginForm.uname + "'", conn);
            //Holding data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//It means the fill in our database
            return dt;// this returns the data from database by holding it
        }

        /// <summary>
        /// This method is for data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBugSolution_Load(object sender, EventArgs e)
        {
            //Data Grid View
            AddBugSolution ab = new AddBugSolution();
            DataTable dt = ab.SelectBug();
            dgv_sol.DataSource = dt;
        }

        /// <summary>
        /// This is for the format of data to display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_sol_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtBox_bugID.Text = dgv_sol.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxProject.Text = dgv_sol.Rows[rowIndex].Cells[1].Value.ToString();
            txt_bugtitle.Text = dgv_sol.Rows[rowIndex].Cells[2].Value.ToString();
            txtdes.Text = dgv_sol.Rows[rowIndex].Cells[3].Value.ToString();
            reportDate.Text = dgv_sol.Rows[rowIndex].Cells[4].Value.ToString();
            cmbBox_status.Text = dgv_sol.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void txtdes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
