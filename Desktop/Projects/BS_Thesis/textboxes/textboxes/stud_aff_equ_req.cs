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
    public partial class stud_aff_equ_req : Form
    {
        public stud_aff_equ_req()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\3bdallh\OneDrive - Almustaqbal University\mythesis\sql_data.mdf"";Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter sqlda3 = new SqlDataAdapter("Select *  from Equalization where status=4", con);


            DataTable dtb1 = new DataTable();
            sqlda3.Fill(dtb1);
            DG1.DataSource = dtb1;


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_aff_home q1 = new student_aff_home();
            q1.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("studentafaairs@gmail.com");//STUDENT AFFAIRS email
                mail.To.Add(textBox1.Text);//STUDENT email
                mail.Subject = "ALMOSTAQBAL University";
                mail.Body = "Dear Student /n We're happy to inform you that your equlization is accepted you can get details from Student Affairs. ";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("studentafaairs@gmail.com", "Aa1234512345");//for STUDENT AFFAIRS correct username and password 
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
