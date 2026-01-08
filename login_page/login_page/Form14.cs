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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            FetchThesisRegistrationData1();
        }
        private void FetchThesisRegistrationData1()
        {
            string mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "SELECT reg_number, name, supervisor_name, title FROM thesis_registration WHERE reg_number = '1'";
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming you have labels or text boxes named lblRegNumber, lblName, lblSupervisorName, and lblTitle to display the data
                            reg.Text = reader.GetString(reader.GetOrdinal("reg_number"));
                            n_name.Text = reader.GetString(reader.GetOrdinal("name"));
                            i_name.Text = reader.GetString(reader.GetOrdinal("supervisor_name"));
                            t_name.Text = reader.GetString(reader.GetOrdinal("title"));
                        }
                        else
                        {
                            MessageBox.Show("No registration found with the registration number 1");
                        }
                    }
                }
                con.Close();
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            academic_plan plan = new academic_plan();
            plan.Show();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            student_submission student_Submission1 = new student_submission();
            student_Submission1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Accepted successfully ");
        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oh No  Rejected ");
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_WOC11_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide(); // home page 
        }

        private void button_WOC3_Click_1(object sender, EventArgs e)
        {
            teacher_academic_calender t11 = new teacher_academic_calender();
            t11.Show();
            this.Hide();
            // academic calender 
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide(); // create assinmnet
        }

        private void button_WOC5_Click_1(object sender, EventArgs e)
        {
            supervisor_submit_marks s11 = new supervisor_submit_marks();
            s11.Show();
            this.Hide();
            // supervsior grade 
        }

        private void button_WOC2_Click_1(object sender, EventArgs e)
        {
            submit_reesult_teacher submit_Reesult_Teacher = new submit_reesult_teacher();
            submit_Reesult_Teacher.Show();
            this.Hide();
            // teacher 1 grade
        }

        private void button_WOC1_Click_2(object sender, EventArgs e)
        {
            submit_result_t2cs s22 = new submit_result_t2cs();
            s22.Show();
            this.Hide();
            // teacher 2 grade
        }

        private void button_WOC6_Click_1(object sender, EventArgs e)
        {
            teacher_forms t22 = new teacher_forms();
            t22.Show();
            this.Hide();
            // teacher forms
        }

        private void button_WOC7_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();

            // panel creation
        }

        private void button_WOC8_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide(); // log out 
        }
    }
}

