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
using System.Net.Mail;

namespace textboxes
{
    public partial class Dean_Requests : Form
    {
        public Dean_Requests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            con.Open();
            if (comboBox1.SelectedIndex == 0)
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

            else if (comboBox1.SelectedIndex == 1)
            {
                SqlDataAdapter sqlda3 = new SqlDataAdapter("Select Username,  Date, Exit_Time, Entry_Time, Reason, Mobile_No, Status ,ID from S_leave where Status=2", con);


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
                SqlDataAdapter sqlda3 = new SqlDataAdapter("Select Username, Start_Date, No_Days, Mobile_No, Reason, Status, ID from full_leave where Status=1", con);


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
                SqlDataAdapter sqlda3 = new SqlDataAdapter("Select Username, Start_Date, No_Days, Mobile_No, Reason, Status, ID from full_leave where Status=2", con);


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
                SqlDataAdapter sqlda3 = new SqlDataAdapter("Select ID, academic_nu, name, status, previous_university, previous_college, specialization, previous_specialization, previous_academic_nu, total_courses, total_hours, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20 from Equalization where status=3", con);


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

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand sqlda3 = new SqlCommand("update S_leave set Status=2 where ID='" + textBox1.Text + "'", con);
                sqlda3.ExecuteNonQuery();
                MessageBox.Show("Request is Approved");
                string q1 = "select * from S_leave where ID = '" + textBox1.Text + "'";
                SqlCommand sql4 = new SqlCommand(q1, con);
                SqlDataReader dr1 = sql4.ExecuteReader();

                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("Deanalmostaqbal@gmail.com");//dean email
                    mail.To.Add("ad.almostaqbal@gmail.com");//HR email
                    mail.Subject = "Approval of Short Leave";
                    while (dr1.Read())
                    {
                        string c = "Teacher Name is  ";
                        c += dr1.GetString(0);
                        c += "  Date of Application  ";
                        c += dr1.GetString(1);
                        c += "  Exit Time  ";
                        c += dr1.GetString(2);
                        c += "  Re-entry Time  ";
                        c += dr1.GetString(3);
                        c += "  Reason is  ";
                        c += dr1.GetString(4);
                        c += "  Mobile Number  ";
                        c += dr1.GetString(5);
                        mail.Body = c;
                    }
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("Deanalmostaqbal@gmail.com", "Aa1234512345");//for dean correct username and password 
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("mail Send");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand sqlda3 = new SqlCommand("update full_leave set Status=2 where ID='" + textBox1.Text + "'", con);
                sqlda3.ExecuteNonQuery();
                MessageBox.Show("Request is Approved");
                string q1 = "select * from full_leave where ID = '" + textBox1.Text + "'";
                SqlCommand sql4 = new SqlCommand(q1, con);
                SqlDataReader dr1 = sql4.ExecuteReader();

                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("Deanalmostaqbal@gmail.com");//dean email
                    mail.To.Add("ad.almostaqbal@gmail.com");//HR email
                    mail.Subject = "Approval of Short Leave";
                    while (dr1.Read())
                    {
                        string c = "Teacher Name is  ";
                        c += dr1.GetString(0);
                        c += "  Date of Application  ";
                        c += dr1.GetString(1);
                        c += "  Exit Time  ";
                        c += dr1.GetString(2);
                        c += "  Re-entry Time  ";
                        c += dr1.GetString(3);
                        c += "  Reason is  ";
                        c += dr1.GetString(4);
                        c += "  Mobile Number  ";
                        c += dr1.GetString(5);
                        mail.Body = c;
                    }
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("Deanalmostaqbal@gmail.com", "Aa1234512345");//for dean correct username and password 
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("mail Send");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (comboBox1.SelectedIndex == 4)
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand sqlda3 = new SqlCommand("update Equalization set status=4 where ID='" + textBox1.Text + "'", con);
                sqlda3.ExecuteNonQuery();
                MessageBox.Show("Request is Approved");


                //send email to student


            }

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dean q1 = new Dean();
            q1.Show();
        }
    }
}
