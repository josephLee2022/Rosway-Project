using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace final_project.FORMS
{
    public partial class contact_us : Form
    {
        NetworkCredential login;
        SmtpClient Client;
        MailMessage msg;
        public contact_us()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
                    login = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                    Client = new SmtpClient(txtSmtp.Text);
                    Client.Port = Convert.ToInt32(txtPort.Text);
                    Client.EnableSsl = chkSSL.Checked;
                    Client.Credentials = login;
                    msg = new MailMessage { From = new MailAddress(txtUsername.Text + txtSmtp.Text.Replace("Smtp.", "@"), "Lucy", Encoding.UTF8) };
                    msg.To.Add(new MailAddress(txtTo.Text));
                    if (!string.IsNullOrEmpty(txtCC.Text))
                        msg.To.Add(new MailAddress(txtCC.Text));
                    msg.Subject = txtSubject.Text;
                    msg.Body = txtMessage.Text;
                    msg.BodyEncoding = Encoding.UTF8;
                    msg.IsBodyHtml = true;
                    msg.Priority = MailPriority.Normal;
                    msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    Client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                    string userstate = "sending...";
                    Client.SendAsync(msg, userstate);
                }
            
        
    
   
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}.", e.UserState, e.Error, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information));
            else
                MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }  
}

