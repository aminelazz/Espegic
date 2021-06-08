using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using e.Components;

namespace e
{
    public partial class Main : Form
    {

        //
        // Constructor 
        //
        public Main()
        {
            InitializeComponent();
        }

        //
        // Properties
        //
        readonly Helpers help = new Helpers();
        readonly Espegic db = new Espegic();

        //
        // Load
        //
        private void Main_Load(object sender, EventArgs e)
        {
            Content.Controls.Clear();
            Content.Controls.Add(new Home());
            Profile.Text = "  " + db.USERS.Find(help.Connected).L_NAME.ToString();
        }

        //
        // Navigate to home page
        //
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Content.Controls.Clear();
            Content.Controls.Add(new Home());
        }

        //
        // Navigate to users
        //
        private void UsersBtn_Click(object sender, EventArgs e)
        {
            if (help.Permitted("READ USER"))
            {
                Content.Controls.Clear();
                Content.Controls.Add(new Users());
            }
            else
            {
                MessageBox.Show("Vous n'avez pas la permission d'accéder aux utilisateurs.");
            }
        }

        //
        // Navigate to professors
        //
        private void ProfessorsBtn_Click(object sender, EventArgs e)
        {
            if (help.Permitted("READ PROFESSOR"))
            {
                Content.Controls.Clear();
                Content.Controls.Add(new Professors());
            }
            else
            {
                MessageBox.Show("Vous n'avez pas la permission d'accéder aux professeurs.");
            }
        }

        //
        // Navigate to students
        private void StudentsBtn_Click(object sender, EventArgs e)
        {
            if (help.Permitted("READ STUDENT"))
            {
                Content.Controls.Clear();
                Content.Controls.Add(new Students());
            }
            else
            {
                MessageBox.Show("Vous n'avez pas la permission d'accéder aux étudiants.");
            }
        }

        //
        // Navigate to formations
        //
        private void FormationsBtn_Click(object sender, EventArgs e)
        {
            if (help.Permitted("READ FORMATION"))
            {
                Content.Controls.Clear();
                Content.Controls.Add(new Formations());
            }
            else
            {
                MessageBox.Show("Vous n'avez pas la permission d'accéder aux formations.");
            }
        }

        //
        // Navigate to Payment
        //
        private void paymentBtn_Click(object sender, EventArgs e)
        {
            if (help.Permitted("READ STUDENT"))
            {
                Content.Controls.Clear();
                Content.Controls.Add(new Payment());
            }
            else
            {
                MessageBox.Show("Vous n'avez pas la permission d'accéder au payment des étudiants.");
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Voulez-vous déconnecter?", "Déconnexion", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HELPER helper = new HELPER()
                {
                    KEY = "CONNECTED",
                    VALUE = "0"
                };

                db.HELPERS.AddOrUpdate(h => h.KEY, helper);
                db.SaveChanges();
                this.Hide();
                new Login().ShowDialog();
                this.Close();
            }
            
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            Content.Controls.Clear();
            Content.Controls.Add(new UserProfile());
        }
    }
}
