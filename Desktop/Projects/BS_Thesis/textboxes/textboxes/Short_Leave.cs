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
    public partial class Short_Leave : Form
    {
        public Short_Leave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            con.Open();



            SqlCommand cmd2 = new SqlCommand("Insert into S_leave (Username, Date, Exit_Time, Entry_Time, Reason, Mobile_No, Status) values ('" + textBox1.Text + "','" + DateTime.Now + "','" + comboBox1.SelectedItem + "','" + comboBox2.SelectedItem + "','" + textBox4.Text + "','" + textBox3.Text + "','" + "0" + "')", con);

            cmd2.ExecuteNonQuery();


            MessageBox.Show("Your Request is Submitted Sucessfully ");
            this.Hide();
            Teacher t1 = new Teacher();
            t1.Show();
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher q1 = new Teacher();
            q1.Show();
        }
    }
}
