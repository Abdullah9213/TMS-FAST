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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            string name = s1.Text;
            string rollNumber = s2.Text;
            string thesisTitle = s3.Text;
            string reasonToChange = s4.Text;
            string newInstructorName = s5.Text;
            int checkbox1 = c1.Checked ? 1 : 0;
            int checkbox2 = c2.Checked ? 1 : 0;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(rollNumber) || string.IsNullOrWhiteSpace(thesisTitle) || string.IsNullOrWhiteSpace(reasonToChange) || string.IsNullOrWhiteSpace(newInstructorName))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "INSERT INTO supervisor_change_request (name, roll_number, thesis_title, reason_to_change, new_instructor_name, checkbox1, checkbox2) VALUES (@Name, @RollNumber, @ThesisTitle, @ReasonToChange, @NewInstructorName, @Checkbox1, @Checkbox2)";
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@RollNumber", rollNumber);
                    cmd.Parameters.AddWithValue("@ThesisTitle", thesisTitle);
                    cmd.Parameters.AddWithValue("@ReasonToChange", reasonToChange);
                    cmd.Parameters.AddWithValue("@NewInstructorName", newInstructorName);
                    cmd.Parameters.AddWithValue("@Checkbox1", checkbox1);
                    cmd.Parameters.AddWithValue("@Checkbox2", checkbox2);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            MessageBox.Show("Request saved successfully!");
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
