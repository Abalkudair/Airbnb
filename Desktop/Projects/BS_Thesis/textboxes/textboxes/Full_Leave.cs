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
    public partial class Full_Leave : Form
    {
        public Full_Leave()
        {
            InitializeComponent();
        }

        private void Full_Leave_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher q1 = new Teacher();
            q1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            con.Open();

            DateTime iDate;
            iDate = dateTimePicker1.Value;



            SqlCommand cmd2 = new SqlCommand("Insert into full_leave (Username, Start_Date, No_Days, Mobile_No, Reason, Status) values ('" + textBox1.Text + "','" + iDate + "','" + comboBox1.SelectedItem + "','" + textBox3.Text + "','" + textBox4.Text + "','" + "0" + "')", con);

            cmd2.ExecuteNonQuery();


            MessageBox.Show("Your Request is Submitted Sucessfully ");
            this.Hide();
            Teacher t1 = new Teacher();
            t1.Show();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
