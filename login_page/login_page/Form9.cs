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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            FetchAndDisplayTeacherDetails();
        }
        private void FetchAndDisplayTeacherDetails()
        {
            string username = "niazi1"; // replace with the actual username
            Teacher teacher = null;

            string mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "SELECT * FROM Teachers WHERE username = @Username";
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            teacher = new Teacher
                            {
                                TeacherId = reader.GetInt32(reader.GetOrdinal("teacher_id")),
                                Username = reader.GetString(reader.GetOrdinal("username")),
                                Password = reader.GetString(reader.GetOrdinal("password")),
                                FirstName = reader.GetString(reader.GetOrdinal("first_name")),
                                LastName = reader.GetString(reader.GetOrdinal("last_name")),
                                Email = reader.GetString(reader.GetOrdinal("email"))
                            };
                        }
                    }
                }
                con.Close();
            }

            // Assuming you have labels or text boxes named u1, u2, u3, u4, and u5
            u1.Text = teacher.Username;
            u2.Text = teacher.FirstName;
            u3.Text = teacher.LastName;
            u4.Text = teacher.Email;
            u5.Text = teacher.TeacherId.ToString();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            teacher_academic_calender t11 = new teacher_academic_calender();
            t11.Show();
            this.Hide();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            supervisor_submit_marks s11 = new supervisor_submit_marks();
            s11.Show();
            this.Hide();
        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            submit_reesult_teacher submit_Reesult_Teacher = new submit_reesult_teacher();
            submit_Reesult_Teacher.Show();
            this.Hide();
        }

        private void button_WOC10_Click(object sender, EventArgs e)
        {
            submit_result_t2cs s22 = new submit_result_t2cs();
            s22.Show();
            this.Hide();
        }

        private void button_WOC2_Click_1(object sender, EventArgs e)
        {
            teacher_forms t22 = new teacher_forms();
            t22.Show();
            this.Hide();
        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void button_WOC7_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void button_WOC8_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
