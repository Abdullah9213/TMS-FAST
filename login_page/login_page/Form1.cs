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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.Show();
            this.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked ==true) { 
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

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

            // Check credentials from the database
            String mycon = "Data Source=TAREEN\\SQLEXPRESS;Initial Catalog=T_M_S;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(mycon))
            {
                con.Open();
                string my_query = "SELECT COUNT(*) FROM students WHERE email = @Email AND password = @Password";
                using (SqlCommand cmd = new SqlCommand(my_query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        MessageBox.Show("Login successful.");

                        // Check ComboBox selection
                        if (comboBox1.SelectedItem.ToString() == "Student")
                        {
                            Form3 form3 = new Form3();
                            form3.Show();
                            this.Hide();
                        }
                        else if (comboBox1.SelectedItem.ToString() =="Faculty")

                        {
                            Form9 form9 = new Form9();
                            form9.Show();
                            this.Hide();// Handle other selections or default case
                        }
                        else
                        {
                            MessageBox.Show("My lord please ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
