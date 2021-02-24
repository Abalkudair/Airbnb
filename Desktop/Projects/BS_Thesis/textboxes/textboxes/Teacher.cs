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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Short_Leave l1 = new Short_Leave();
            l1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            Full_Leave q1 = new Full_Leave();
            q1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Requests_Status q1 = new Teacher_Requests_Status();
            q1.Show();
        }
    }
}
