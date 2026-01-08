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
    public partial class teacher_academic_calender : Form
    {
        public teacher_academic_calender()
        {
            InitializeComponent();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            teacher_academic_calender cal1= new teacher_academic_calender();   
            cal1.Show();
            this.Hide();
        }

        private void button_WOC3_Click_1(object sender, EventArgs e)
        {
            teacher_academic_calender t11 = new teacher_academic_calender();
                t11.Show();
            this.Hide();
            // academic calender 
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide(); // create assinmnet
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            supervisor_submit_marks s11= new supervisor_submit_marks();
            s11.Show();
            this.Hide();
            // supervsior grade 
        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            submit_reesult_teacher submit_Reesult_Teacher = new submit_reesult_teacher();
            submit_Reesult_Teacher.Show();
            this.Hide();
            // teacher 1 grade
        }

        private void button_WOC10_Click(object sender, EventArgs e)
        {
            submit_result_t2cs s22= new submit_result_t2cs();
            s22.Show();
            this.Hide();
            // teacher 2 grade 

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            teacher_forms t22 = new teacher_forms();
            t22.Show();
            this.Hide();
            // teacher forms
        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            Form11 f11= new Form11();
            f11.Show();
            this.Hide();
            // create assignmnet 
        }

        private void button_WOC7_Click(object sender, EventArgs e)
        {
            Form12  f12= new Form12();
            f12.Show();
            this.Hide();

            // panel creation
        }

        private void button_WOC8_Click(object sender, EventArgs e)
        {
            Form1 f1= new Form1();
            f1.Show();
            this.Hide(); // log out 
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide(); // home page 
        }
    }
}
