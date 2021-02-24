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
    public partial class Hod : Form
    {
       
        public Hod()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            con.Open();
            if (comboBox1.SelectedIndex == 0)
            {
                SqlDataAdapter sqlda3 = new SqlDataAdapter("Select Username,  Date, Exit_Time, Entry_Time, Reason, Mobile_No, Status ,ID from S_leave where Status=0", con);


                DataTable dtb1 = new DataTable();
                sqlda3.Fill(dtb1);
                DG1.DataSource = dtb1;
                if (dtb1.Rows.Count == 0)
                {
                    MessageBox.Show("No Record is Found");
                }
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                SqlDataAdapter sqlda3 = new SqlDataAdapter("Select Username,  Date, Exit_Time, Entry_Time, Reason, Mobile_No, Status ,ID from S_leave where Status=1", con);


                DataTable dtb1 = new DataTable();
                sqlda3.Fill(dtb1);
                DG1.DataSource = dtb1;
                if (dtb1.Rows.Count == 0)
                {
                    MessageBox.Show("No Record is Found");
                }
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                SqlDataAdapter sqlda3 = new SqlDataAdapter("Select Username, Start_Date, No_Days, Mobile_No, Reason, Status, ID from full_leave where Status=0", con);


                DataTable dtb1 = new DataTable();
                sqlda3.Fill(dtb1);
                DG1.DataSource = dtb1;
                if (dtb1.Rows.Count == 0)
                {
                    MessageBox.Show("No Record is Found");
                }
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                SqlDataAdapter sqlda3 = new SqlDataAdapter("Select Username, Start_Date, No_Days, Mobile_No, Reason, Status, ID from full_leave where Status=1", con);


                DataTable dtb1 = new DataTable();
                sqlda3.Fill(dtb1);
                DG1.DataSource = dtb1;
                if (dtb1.Rows.Count == 0)
                {
                    MessageBox.Show("No Record is Found");
                }
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                SqlDataAdapter sqlda3 = new SqlDataAdapter("Select ID, academic_nu, name, status, previous_university, previous_college, specialization, previous_specialization, previous_academic_nu, total_courses, total_hours, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20 from Equalization where Status=2", con);


                DataTable dtb1 = new DataTable();
                sqlda3.Fill(dtb1);
                DG1.DataSource = dtb1;
                if (dtb1.Rows.Count == 0)
                {
                    MessageBox.Show("No Record is Found");
                }
            }

            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex == 0)
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand sqlda3 = new SqlCommand("update S_leave set Status=1 where ID='" + textBox1.Text + "'", con);
                sqlda3.ExecuteNonQuery();
                MessageBox.Show("Request is Approved");
            }

            if (comboBox1.SelectedIndex == 2)
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand sqlda3 = new SqlCommand("update full_leave set Status=1 where ID='" + textBox1.Text + "'", con);
                sqlda3.ExecuteNonQuery();
                MessageBox.Show("Request is Approved");
            }


            if (comboBox1.SelectedIndex == 4)
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand sqlda3 = new SqlCommand("update Equalization set status=3 where ID='" + textBox1.Text + "'", con);
                sqlda3.ExecuteNonQuery();
                MessageBox.Show("Request is Approved");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home q1 = new Home();
            q1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand sqlda3 = new SqlCommand("update S_leave set Status=-1 where ID='" + textBox1.Text + "'", con);
                sqlda3.ExecuteNonQuery();
                MessageBox.Show("Request is Successfully Rejected");
            }

            if (comboBox1.SelectedIndex == 2)
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand sqlda3 = new SqlCommand("update full_leave set Status=-1 where ID='" + textBox1.Text + "'", con);
                sqlda3.ExecuteNonQuery();
                MessageBox.Show("Request is Successfully Rejected");
            }
        }
        
        
    }
}