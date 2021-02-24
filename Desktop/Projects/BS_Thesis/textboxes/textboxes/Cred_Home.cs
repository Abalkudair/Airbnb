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

namespace textboxes
{
    public partial class Cred_Home : Form
    {
        public Cred_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            con.Open();
                SqlDataAdapter sqlda3 = new SqlDataAdapter("SELECT academic_nu, name, status, previous_university, previous_college, specialization, previous_specialization, previous_academic_nu, transcript from student_affairs where status = 1", con);


                DataTable dtb1 = new DataTable();
                sqlda3.Fill(dtb1);
                DG1.DataSource = dtb1;
                if (dtb1.Rows.Count == 0)
                {
                    MessageBox.Show("No Record is Found");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fill_courses q1 = new fill_courses();
            q1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home q1 = new Home();
            q1.Show();
        }
    }
}
