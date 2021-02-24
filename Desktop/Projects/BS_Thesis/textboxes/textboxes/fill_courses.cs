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
    public partial class fill_courses : Form
    {
        public fill_courses()
        {
            InitializeComponent();
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

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 5)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 6)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 7)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 8)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 9)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 10)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 11)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox13.Visible = true;
                comboBox14.Visible = false;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 12)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox13.Visible = true;
                comboBox14.Visible = true;
                comboBox15.Visible = false;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 13)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox13.Visible = true;
                comboBox14.Visible = true;
                comboBox15.Visible = true;
                comboBox16.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 14)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox13.Visible = true;
                comboBox14.Visible = true;
                comboBox15.Visible = true;
                comboBox16.Visible = true;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 15)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox13.Visible = true;
                comboBox14.Visible = true;
                comboBox15.Visible = true;
                comboBox16.Visible = true;
                comboBox17.Visible = true;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 16)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox13.Visible = true;
                comboBox14.Visible = true;
                comboBox15.Visible = true;
                comboBox16.Visible = true;
                comboBox17.Visible = true;
                comboBox18.Visible = true;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 17)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox13.Visible = true;
                comboBox14.Visible = true;
                comboBox15.Visible = true;
                comboBox16.Visible = true;
                comboBox17.Visible = true;
                comboBox18.Visible = true;
                comboBox19.Visible = true;
                comboBox20.Visible = false;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 18)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox13.Visible = true;
                comboBox14.Visible = true;
                comboBox15.Visible = true;
                comboBox16.Visible = true;
                comboBox17.Visible = true;
                comboBox18.Visible = true;
                comboBox19.Visible = true;
                comboBox20.Visible = true;
                comboBox21.Visible = false;

            }
            if (comboBox1.SelectedIndex == 19)
            {
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox13.Visible = true;
                comboBox14.Visible = true;
                comboBox15.Visible = true;
                comboBox16.Visible = true;
                comboBox17.Visible = true;
                comboBox18.Visible = true;
                comboBox19.Visible = true;
                comboBox20.Visible = true;
                comboBox21.Visible = true;

            }
           

        }

        private void fill_courses_Load(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
            comboBox11.Visible = false;
            comboBox12.Visible = false;
            comboBox13.Visible = false;
            comboBox14.Visible = false;
            comboBox15.Visible = false;
            comboBox16.Visible = false;
            comboBox17.Visible = false;
            comboBox18.Visible = false;
            comboBox19.Visible = false;
            comboBox20.Visible = false;
            comboBox21.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "insert into Equalization(academic_nu, name, status, previous_university, previous_college, specialization, previous_specialization, previous_academic_nu, total_courses, total_hours, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20) Values ('" + textBox1.Text + "','" + textBox5.Text + "','" + "2" + "','" + textBox2.Text + "', '" + textBox6.Text + "','" + comboBox1.SelectedItem + "','" + textBox7.Text + "','" + textBox4.Text + "','" + comboBox1.SelectedItem + "','"+ textBox9.Text + "','" + comboBox2.SelectedItem + "','" + comboBox3.SelectedItem + "','"+ comboBox4.SelectedItem + "','"+ comboBox5.SelectedItem + "','"+ comboBox6.SelectedItem + "','"+ comboBox7.SelectedItem + "','"+ comboBox8.SelectedItem + "','"+ comboBox9.SelectedItem + "','"+ comboBox10.SelectedItem + "','"+ comboBox11.SelectedItem + "','"+ comboBox12.SelectedItem + "','"+ comboBox13.SelectedItem + "','"+ comboBox14.SelectedItem + "','"+ comboBox15.SelectedItem + "','"+ comboBox16.SelectedItem + "','"+ comboBox17.SelectedItem + "','"+ comboBox18.SelectedItem + "','"+ comboBox19.SelectedItem + "','"+ comboBox20.SelectedItem + "','"+ comboBox21.SelectedItem + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Equalization Enterd Successfully ");
            SqlCommand sqlda3 = new SqlCommand("update student_affairs set status= 2 where academic_nu='" + textBox1.Text + "'", con);
            sqlda3.ExecuteNonQuery();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cred_Home q1 = new Cred_Home();
            q1.Show();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand sqlda3 = new SqlCommand("update student_affairs set status= -1 where academic_nu='" + textBox1.Text + "'", con);
            sqlda3.ExecuteNonQuery();
            MessageBox.Show(" Equalization Request is Rejected ");
        }
    }
}
