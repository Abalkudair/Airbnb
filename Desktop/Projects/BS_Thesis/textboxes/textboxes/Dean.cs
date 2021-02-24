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
    public partial class Dean : Form
    {
        public Dean()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home q1 = new Home();
            q1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dean_Requests q1 = new Dean_Requests();
            q1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            eq_approve q1 = new eq_approve();
            q1.Show();
        }
    }
}
