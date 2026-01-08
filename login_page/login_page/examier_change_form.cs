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
using System.Xml.Linq;

namespace login_page
{
    public partial class examier_change_form : Form
    {
        public examier_change_form()
        {
            InitializeComponent();
        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            string name = e1.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please fill in the name.");
                return;
            }

            string examinerName = e2.Text;
            if (string.IsNullOrWhiteSpace(examinerName))
            {
                MessageBox.Show("Please fill in the examiner name.");
                return;
            }

            string program = e3.Text;
            if (string.IsNullOrWhiteSpace(program))
            {
                MessageBox.Show("Please fill in the program.");
                return;
            }

            string thesisName = e4.Text;
            if (string.IsNullOrWhiteSpace(thesisName))
            {
                MessageBox.Show("Please fill in the thesis name.");
                return;
            }

            string reasonToChangeExaminer = e5.Text;
            if (string.IsNullOrWhiteSpace(reasonToChangeExaminer))
            {
                MessageBox.Show("Please fill in the reason to change examiner.");
                return;
            }

            string mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "INSERT INTO Examiner_change_form (name, examiner_name, program, thesis_name, reason_to_change_examiner) VALUES (@Name, @ExaminerName, @Program, @ThesisName, @ReasonToChangeExaminer)";
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@ExaminerName", examinerName);
                    cmd.Parameters.AddWithValue("@Program", program);
                    cmd.Parameters.AddWithValue("@ThesisName", thesisName);
                    cmd.Parameters.AddWithValue("@ReasonToChangeExaminer", reasonToChangeExaminer);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            MessageBox.Show("Form saved successfully!");

        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            academic_plan form16 = new academic_plan();
            form16.Show();
            this.Hide();
        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
           student_submission student_Submission = new student_submission();
            student_Submission.Show();
            this.Hide();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button_WOC8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
