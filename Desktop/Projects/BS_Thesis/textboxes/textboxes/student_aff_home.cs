using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textboxes
{
    public partial class student_aff_home : Form
    {
        public student_aff_home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students q1 = new Students();
            q1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home q1 = new Home();
            q1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            stud_aff_equ_req q1 = new stud_aff_equ_req();
            q1.Show();
        }
    }
}
