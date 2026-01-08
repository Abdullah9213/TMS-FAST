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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            student_submission student_Submission1 = new student_submission();
            student_Submission1.Show();
            this.Hide();
        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            string name = t1.Text;
            string rollNumber = t2.Text;
            string email = t3.Text;
            string newTitle = t4.Text;
            string potentialAreas = t5.Text;
            string currentTitle = t6.Text;
            string reason = t7.Text;

            string mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "INSERT INTO title_change_form (name, roll_number, email, new_title, potential_areas, current_title, reason) VALUES (@Name, @RollNumber, @Email, @NewTitle, @PotentialAreas, @CurrentTitle, @Reason)";
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@RollNumber", rollNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@NewTitle", newTitle);
                    cmd.Parameters.AddWithValue("@PotentialAreas", potentialAreas);
                    cmd.Parameters.AddWithValue("@CurrentTitle", currentTitle);
                    cmd.Parameters.AddWithValue("@Reason", reason);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            MessageBox.Show("Data saved successfully!");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
