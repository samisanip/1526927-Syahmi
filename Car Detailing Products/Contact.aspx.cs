using System;
using System.Net.Mail;

namespace Car_Detailing_Products
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("car2017pro@gmail.com");
                mailMessage.To.Add("car2017pro@gmail.com");
                mailMessage.Subject = txtSubject.Text;

                mailMessage.Body = "<b>Sender Name: </b>" + txtName.Text + "</br>"
                + "<b>Sender Email: </b>" + txtEmail.Text + "</br>"
                + "<b>Message: </b>" + txtMessage.Text;
                mailMessage.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("car2017pro@gmail.com", "carpro2017");
                smtpClient.Send(mailMessage);

                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Text = "Message Submitted";

                txtName.Enabled = false;
                txtEmail.Enabled = false;
                txtSubject.Enabled = false;
                txtMessage.Enabled = false;
                Button1.Enabled = false;
            }

            catch(Exception ex)
            {
                // Log
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Problem Occur, Try Again Later";

            }

        }
    }
}