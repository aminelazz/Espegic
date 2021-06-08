using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using e;
using System.Net.Mail;
using System.Net;

namespace e
{
    public partial class Login : Form
    {
        Espegic db = new Espegic();
        public Login()
        {
            InitializeComponent();
            // SET FORM SHADOW
            this.ShadowForm.SetShadowForm(this);
        }

        //
        // Close application
        //
        private void CLOSE_BTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        // Login
        //
        private void LOGIN_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                var user = db.USERS.Where(u => u.EMAIL == LOGIN_EMAIL.Text && u.PASSWORD == LOGIN_PASSWORD.Text);

                if (user.Count() > 0)
                {
                    db.HELPERS.AddOrUpdate(h => h.KEY, new HELPER { KEY = "CONNECTED", VALUE = user.First().ID.ToString() });
                    db.SaveChanges();
                    this.Hide();
                    new Main().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Les données sont incorrects");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LOGIN_RECOVER_Click(object sender, EventArgs e)
        {
            var user = db.USERS.Where(u => u.EMAIL == LOGIN_EMAIL.Text);

            if (user.Count() > 0)
            {
                string password = user.First().PASSWORD;
                string to = user.First().EMAIL;
                string from = "dv.hamham@gmail.com";
                MailMessage message = new MailMessage(from, to);
                message.Subject = "Réinitialiser le mot de passe";
                message.Body = @"Votre mot de passe est : " + password;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("espegic2021@gmail.com", "2021espegic");
                // Credentials are necessary if the server requires the client
                // to authenticate before it will send email on the client's behalf.

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Email envoyé avec succés.", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("L'email est incorrect");
            }
        }

        private void LOGIN_PASSWORD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LOGIN_BTN_Click(sender, e);
            }
        }
    }
}
