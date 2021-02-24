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
using System.IO;

namespace textboxes
{
    public partial class eq_approve : Form
    {
        public eq_approve()
        {
            InitializeComponent();
        }

        private void eq_approve_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqlda3 = new SqlDataAdapter("Select academic_nu, name, status from student_affairs where status= 0 ", con);
            DataTable dtb1 = new DataTable();
            sqlda3.Fill(dtb1);
            DG1.DataSource = dtb1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            string query1 = "select * from student_affairs where academic_nu='" + textBox1.Text + "'";
            SqlCommand cmd1 = new SqlCommand(query1, con1);
            SqlDataReader dr1;
            try
            {
                con1.Open();
                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())

                {
                    textBox4.Text = dr1.GetString(6);
                    textBox5.Text = dr1.GetString(1);
                    textBox2.Text = dr1.GetString(2);
                    textBox6.Text = dr1.GetString(3);
                    textBox8.Text = dr1.GetString(4);
                    textBox7.Text = dr1.GetString(5);
                    
                    byte[] imgg = (byte[])(dr1["transcript"]);//image is name of table column in database
                    if (imgg == null)
                    {
                        pictureBox1.Image = null;

                    }
                    else
                    {
                        MemoryStream mst = new MemoryStream(imgg);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mst);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            con1.Open();
            SqlCommand sqlda5 = new SqlCommand("update student_affairs set status=1 where academic_nu='" + textBox1.Text + "'", con1);
            sqlda5.ExecuteNonQuery();
            MessageBox.Show("Equalization is Approved");
            textBox1.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox8.Text = String.Empty;
            textBox7.Text = String.Empty;
            pictureBox1.InitialImage = null;

            con1.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            con1.Open();
            SqlCommand sqlda5 = new SqlCommand("update student_affairs set status=-1 where academic_nu='" + textBox1.Text + "'", con1);
            sqlda5.ExecuteNonQuery();
            MessageBox.Show("Equalization is Rejected");
            con1.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dean q1 = new Dean();
            q1.Show();
        }
    }
}
