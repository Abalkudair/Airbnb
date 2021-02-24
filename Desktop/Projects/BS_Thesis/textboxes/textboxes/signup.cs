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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + textBox1.Text + "'", con1);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);

            if (int.Parse(dt2.Rows[0][0].ToString()) == 0)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
                    con.Open();



                    SqlCommand cmd = new SqlCommand("Insert into Login (Username, Password, Role) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem + "')", con);

                    cmd.ExecuteNonQuery();
                    con.Close();



                    MessageBox.Show("You are Registered");



                }



                else
                {

                    MessageBox.Show("Password is not Same");

                }
            }

            else
            {
                MessageBox.Show("This Name is Already in Use");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home q1 = new Home();
            q1.Show();
        }



        }
    }

