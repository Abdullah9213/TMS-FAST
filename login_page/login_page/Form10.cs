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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
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
    }
}
