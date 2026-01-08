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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            FetchAndDisplayStudentDetails();
        }
        private void FetchAndDisplayStudentDetails()
        {
            string username = "s"; // replace with the actual username
            Student student = null;

            string mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "SELECT * FROM Students WHERE username = @Username";
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            student = new Student
                            {
                                StudentId = reader.GetInt32(reader.GetOrdinal("student_id")),
                                Username = reader.GetString(reader.GetOrdinal("username")),
                                Password = reader.GetString(reader.GetOrdinal("password")),
                                FirstName = reader.GetString(reader.GetOrdinal("first_name")),
                                LastName = reader.GetString(reader.GetOrdinal("last_name")),
                                Email = reader.GetString(reader.GetOrdinal("email")),
                                RegistrationNumber = reader.GetString(reader.GetOrdinal("registration_number"))
                            };
                        }
                    }
                }
                con.Close();
            }

            // Assuming you have labels or text boxes named LabelUsername, LabelFirstName, LabelLastName, LabelEmail, and LabelRegistrationNumber
            u1.Text = student.Username;
         u2.Text = student.FirstName;
            u3.Text = student.LastName;
           u4.Text = student.Email;
           u5.Text = student.RegistrationNumber;
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC16_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            academic_plan form16 = new academic_plan();
            form16.Show();
            this.Hide();
        }

        private void button_WOC15_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button_WOC12_Click(object sender, EventArgs e)
        {
           student_submission form15 = new student_submission();
            form15.Show();
            this.Hide();
        }

        private void button_WOC10_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC11_Click(object sender, EventArgs e)
        {
            Form8 form8= new Form8();
            form8.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_WOC14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
