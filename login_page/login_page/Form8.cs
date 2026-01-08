using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_page
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            FetchMarks_Click_s_1();
            FetchMarks_Click_t_1();
            FetchMarks_Click_t_2();
        }   
        private void FetchMarks_Click_s_1()
        {
            // Fetch the marks from the database
            string mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "SELECT mark1, mark2, mark3, mark4, total_marks FROM s1_marks WHERE id = '1'"; // Replace with your actual query
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", 1); // Replace with the actual ID

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display the marks in the text boxes
                            s1.Text = reader.GetInt32(0).ToString();
                            s2.Text = reader.GetInt32(1).ToString();
                            s3.Text = reader.GetInt32(2).ToString();
                            s4.Text = reader.GetInt32(3).ToString();
                            s5.Text = reader.GetInt32(4).ToString();
                        }
                    }
                }
                con.Close();
            }
        }
        private void FetchMarks_Click_t_1()
        {
            // Fetch the marks from the database
            string mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "SELECT mark1, mark2, mark3, mark4, total_marks FROM t1_marks WHERE id = '1'"; // Replace with your actual query
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", 1); // Replace with the actual ID

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display the marks in the text boxes
                            e11.Text = reader.GetInt32(0).ToString();
                            e12.Text = reader.GetInt32(1).ToString();
                            e13.Text = reader.GetInt32(2).ToString();
                            e14.Text = reader.GetInt32(3).ToString();
                            e15.Text = reader.GetInt32(4).ToString();
                        }
                    }
                }
                con.Close();
            }
        }
        private void FetchMarks_Click_t_2()
        {
            // Fetch the marks from the database
            string mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "SELECT mark1, mark2, mark3, mark4, total_marks FROM t2_marks WHERE id = '1'"; // Replace with your actual query
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", 1); // Replace with the actual ID

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display the marks in the text boxes
                            e16.Text = reader.GetInt32(0).ToString();
                            e17.Text = reader.GetInt32(1).ToString();
                            e18.Text = reader.GetInt32(2).ToString();
                            e19.Text = reader.GetInt32(3).ToString();
                            e20.Text = reader.GetInt32(4).ToString();
                        }
                    }
                }
                con.Close();
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            academic_plan plan = new academic_plan();
            plan.Show();
            this.Hide();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }


        private void button_WOC6_Click(object sender, EventArgs e)
        {
            student_submission student_Submission1 = new student_submission();
            student_Submission1.Show();
            this.Hide();
        }

        private void s1_TextChanged(object sender, EventArgs e)
        {

        }

        private void s2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
