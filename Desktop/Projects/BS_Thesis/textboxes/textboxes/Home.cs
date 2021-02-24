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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Username");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }
            else
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + textBox1.Text + "'and Password='" + textBox2.Text + "'and Role='" + comboBox1.SelectedItem + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    if (comboBox1.SelectedItem.ToString() == "HOD")
                    {
                        this.Hide();
                        Hod h1 = new Hod();
                        h1.Show();
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Dean")
                    {

                        this.Hide();
                        Dean h6 = new Dean();
                        h6.Show();
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Teacher")
                    {

                        this.Hide();
                        Teacher h2 = new Teacher();
                        h2.Show();
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Student affer")
                    {

                        this.Hide();
                        student_aff_home h3 = new student_aff_home();
                        h3.Show();
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Director")
                    {

                        this.Hide();
                        Director h4 = new Director();
                        h4.Show();
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Admin")
                    {

                        this.Hide();
                        signup h6 = new signup();
                        h6.Show();
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Credit Trasfer")
                    {

                        this.Hide();
                        Cred_Home h5 = new Cred_Home();
                        h5.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup ss = new signup();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
