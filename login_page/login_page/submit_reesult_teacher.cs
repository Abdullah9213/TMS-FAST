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
    public partial class submit_reesult_teacher : Form
    {
        public submit_reesult_teacher()
        {
            InitializeComponent();
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

        private void button_WOC4_Click(object sender, EventArgs e)
        {

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

        private void button_WOC4_Click_1(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            // Get the marks from the text boxes
            int mark1 = int.Parse(t1.Text);
            int mark2 = int.Parse(t2.Text);
            int mark3 = int.Parse(t3.Text);
            int mark4 = int.Parse(t4.Text);

            // Calculate the total
            int total = mark1 + mark2 + mark3 + mark4;

            // Display the total in the t5 text box
            t5.Text = total.ToString();
        }

        private void button_WOC10_Click(object sender, EventArgs e)
        {
            // Get the marks from the text boxes
            int mark1 = int.Parse(t1.Text);
            int mark2 = int.Parse(t2.Text);
            int mark3 = int.Parse(t3.Text);
            int mark4 = int.Parse(t4.Text);

            // Calculate the total
            int total = mark1 + mark2 + mark3 + mark4;

            // Display the total in the t5 text box
            t5.Text = total.ToString();

            // Insert the marks and total into the database
            string mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "INSERT INTO t1_marks (mark1, mark2, mark3, mark4, total_marks) VALUES (@Mark1, @Mark2, @Mark3, @Mark4, @TotalMarks)";
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Mark1", mark1);
                    cmd.Parameters.AddWithValue("@Mark2", mark2);
                    cmd.Parameters.AddWithValue("@Mark3", mark3);
                    cmd.Parameters.AddWithValue("@Mark4", mark4);
                    cmd.Parameters.AddWithValue("@TotalMarks", total);

                    cmd.ExecuteNonQuery();
                }
                con.Close();

            }
            MessageBox.Show("Data Submitted Successfully");
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide(); // home page 
        }

        private void button_WOC3_Click_1(object sender, EventArgs e)
        {

        }

        private void button_WOC5_Click_1(object sender, EventArgs e)
        {

        }

        private void button_WOC11_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide(); // home page 
        }

        private void button_WOC3_Click_2(object sender, EventArgs e)
        {

            teacher_academic_calender t11 = new teacher_academic_calender();
            t11.Show();
            this.Hide();
            // academic calender 
        }

        private void button_WOC4_Click_2(object sender, EventArgs e)
        {

            Form11 form11 = new Form11();
            form11.Show();
            this.Hide(); // create assinmnet
        }

        private void button_WOC5_Click_2(object sender, EventArgs e)
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
