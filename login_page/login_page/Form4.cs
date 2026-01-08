using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_page
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void button_WOC10_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button_WOC12_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();

        }

        private void button_WOC11_Click(object sender, EventArgs e)
        {
            examier_change_form form = new examier_change_form();
            form.Show();
            this.Hide();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            academic_plan plan = new academic_plan();   
            plan.Show();
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

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            student_submission student_Submission1 = new student_submission();
            student_Submission1.Show();
            this.Hide();
        }

        private void button_WOC7_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {

        }
    }
}
