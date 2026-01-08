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
    public partial class teacher_forms : Form
    {
        public teacher_forms()
        {
            InitializeComponent();
        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            Form13 form14 = new Form13();
            form14.Show();
            this.Hide();
        }

        private void button_WOC10_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void button_WOC12_Click(object sender, EventArgs e)
        {
            examier_change_form ex1 = new examier_change_form();
            ex1.Show();
            this.Hide();
        }

        private void button_WOC11_Click(object sender, EventArgs e)
        {
            examier_change_form ex1 = new examier_change_form();
            ex1.Show();
            this.Hide();
        }

        private void button_WOC24_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void button_WOC17_Click(object sender, EventArgs e)
        {
            teacher_academic_calender t11 = new teacher_academic_calender();
            t11.Show();
            this.Hide();
        }

        private void button_WOC18_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide(); // create assinmnet
        }

        private void button_WOC19_Click(object sender, EventArgs e)
        {
            supervisor_submit_marks s11 = new supervisor_submit_marks();
            s11.Show();
            this.Hide();
            // supervsior grade 
        }

        private void button_WOC16_Click(object sender, EventArgs e)
        {
            submit_reesult_teacher submit_Reesult_Teacher = new submit_reesult_teacher();
            submit_Reesult_Teacher.Show();
            this.Hide();
            // teacher 1 grade
        }

        private void button_WOC15_Click(object sender, EventArgs e)
        {
            submit_result_t2cs s22 = new submit_result_t2cs();
            s22.Show();
            this.Hide();
            // teacher 2 grade 
        }

        private void button_WOC23_Click(object sender, EventArgs e)
        {
            teacher_forms t22 = new teacher_forms();
            t22.Show();
            this.Hide();
            // teacher forms
        }

        private void button_WOC20_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void button_WOC21_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();

        }

        private void button_WOC22_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide(); // log out 
        }
    }
}
