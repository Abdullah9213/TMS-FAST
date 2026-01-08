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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            FetchThesisRegistrationData();
        }
        private void FetchThesisRegistrationData()
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

        private void tt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }
    }
}
