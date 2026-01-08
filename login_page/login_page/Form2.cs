using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace login_page
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string first_name = textBox2.Text;
            string last_name = textBox4.Text;
            string email = textBox6.Text;
            string password = textBox3.Text;
            string registration_number = textBox5.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username field cannot be empty.");
                return;
            }

            if (string.IsNullOrEmpty(first_name))
            {
                MessageBox.Show("First name field cannot be empty.");
                return;
            }

            if (string.IsNullOrEmpty(last_name))
            {
                MessageBox.Show("Last name field cannot be empty.");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email field cannot be empty.");
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Email should contain '@'.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password field cannot be empty.");
                return;
            }

            if (string.IsNullOrEmpty(registration_number))
            {
                MessageBox.Show("Registration number field cannot be empty.");
                return;
            }
            String mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "INSERT INTO Students(username, password, first_name, last_name, email, registration_number) VALUES (@Username, @Password, @FirstName, @LastName, @Email, @RegNum)";
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@FirstName", first_name);
                    cmd.Parameters.AddWithValue("@LastName", last_name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@RegNum", registration_number);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            MessageBox.Show("Account has been created.");
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
