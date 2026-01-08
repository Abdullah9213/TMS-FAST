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
    public partial class Form7 : Form
    {
        public Form7()
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
            academic_plan academic_Plan1= new academic_plan();
           academic_Plan1.Show();
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            string name = f1.Text;
            string regNumber = f2.Text;
            string programName = f3.Text;
            string contact = f4.Text;
            string supervisorName = f5.Text;
            string potentialAreas = f8.Text;
            string title = f6.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(regNumber) || string.IsNullOrWhiteSpace(programName) || string.IsNullOrWhiteSpace(contact) || string.IsNullOrWhiteSpace(supervisorName) || string.IsNullOrWhiteSpace(potentialAreas) || string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "INSERT INTO thesis_registration (name, reg_number, program_name, contact, supervisor_name, potential_areas, title) VALUES (@Name, @RegNumber, @ProgramName, @Contact, @SupervisorName, @PotentialAreas, @Title)";
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@RegNumber", regNumber);
                    cmd.Parameters.AddWithValue("@ProgramName", programName);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@SupervisorName", supervisorName);
                    cmd.Parameters.AddWithValue("@PotentialAreas", potentialAreas);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            MessageBox.Show("Registration saved successfully!");

        }
    }
}
