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
    public partial class Teacher_Requests_Status : Form
    {
        public Teacher_Requests_Status()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + textBox1.Text + "'and Password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    SqlDataAdapter sqlda3 = new SqlDataAdapter("Select Username,  Date, Exit_Time, Entry_Time, Reason, Mobile_No, Status ,ID from S_leave WHERE Username ='" + textBox3.Text + "'", con);


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
                    SqlDataAdapter sqlda4 = new SqlDataAdapter("Select Username,  Start_Date, No_Days, Mobile_No, Reason, Status ,ID from full_leave WHERE Username ='" + textBox3.Text + "'", con);


                    DataTable dtb2 = new DataTable();
                    sqlda4.Fill(dtb2);
                    DG1.DataSource = dtb2;
                    if (dtb2.Rows.Count == 0)
                    {
                        MessageBox.Show("No Record is Found");
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher q1 = new Teacher();
            q1.Show();
        }
    }
}
