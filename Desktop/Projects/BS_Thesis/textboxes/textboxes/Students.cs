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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
        String imgLocation = "";
        SqlCommand cmd;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files (*.*)|*.*";
            dlg.Title = "Select User Picture";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                textBox3.Text = picPath;
                pictureBox1.ImageLocation = picPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imgbt = null;
            FileStream fstream = new FileStream(this.textBox3.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imgbt = br.ReadBytes((int)fstream.Length);


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            string query = "insert into student_affairs(academic_nu, name, status, previous_university, previous_college, specialization, previous_specialization, previous_academic_nu, transcript) Values ('" + textBox1.Text + "','" + textBox5.Text + "','" + "0" + "','" + textBox2.Text + "', '" + textBox6.Text + "','" + comboBox1.SelectedItem + "','" + textBox7.Text + "','" + textBox4.Text + "',@IMG)";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                cmd.Parameters.Add(new SqlParameter("@IMG", imgbt));
                dr = cmd.ExecuteReader();
                MessageBox.Show("Data sucessfully Saved");
                while (dr.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_aff_home q1 = new student_aff_home();
            q1.Show();
        }
    }
}
