using e.Validators;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e.Components
{
    public partial class UserProfile : UserControl
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        //
        // Properties
        //
        readonly Helpers help = new Helpers();
        readonly Espegic db   = new Espegic();

        //
        // Load
        //
        private void UserProfile_Load(object sender, EventArgs e)
        {
            UserInfos();
        }

        //
        // Navigate to update data
        //
        private void EditBtn_Click(object sender, EventArgs e)
        {
            USER user = db.USERS.Find(help.Connected);
            // Fill input
            CIN.Text        = user.CIN;
            L_Name.Text     = user.L_NAME;
            F_Name.Text     = user.F_NAME;
            Phone.Text      = user.PHONE;
            Password.Text   = user.PASSWORD;
            Email.Text      = user.EMAIL;

            Pages.PageName = "tabPage2";
        }

        //
        // Save updated data
        //
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            USER user = new USER()
            {
                ID          = help.Connected,
                CIN         = CIN.Text.ToUpper(),
                F_NAME      = F_Name.Text.ToUpper(),
                L_NAME      = L_Name.Text.ToUpper(),
                PHONE       = Phone.Text,
                EMAIL       = Email.Text.ToLower(),
                PASSWORD    = Password.Text,
                ARCHIVE     = false,
                CREATED_BY = db.USERS.Find(help.Connected).CREATED_BY,
                CREATED_AT = db.USERS.Find(help.Connected).CREATED_AT,
                UPDATED_BY  = help.Connected,
                UPDATED_AT  = DateTime.Now
            };

            // Validate data
            UserValidator validator     = new UserValidator();
            ValidationResult results    = validator.Validate(user);

            if (results.IsValid)
            {
                // Check if any one has same Cin or email
                if (db.USERS.Where(u => u.CIN == user.CIN && u.ID != user.ID).Count() > 0)
                {
                    MessageBox.Show("Vous avez utilisé un CIN qui existe dans un autre compte");
                }
                else if (db.USERS.Where(u => u.EMAIL == user.EMAIL && u.ID != user.ID).Count() > 0)
                {
                    MessageBox.Show("Vous avez utilisé un EMAIL qui existe dans un autre compte");
                }
                else
                {
                    // Update user
                    db.USERS.AddOrUpdate(u => u.ID, user);
                    db.SaveChanges();

                    // Create history
                    help.CreateHistory("MODIFIER UN UTILISATEUR", user.F_NAME, user.L_NAME, user.CIN);

                    MessageBox.Show("Vos données personnelles modifiées avec succes");
                    UserInfos();
                    Pages.PageName = "tabPage1";
                }
            }
            else
            {
                // Fetch errors
                foreach (ValidationFailure failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage);
                }
            }
        }

        //
        // Return to home page
        //
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Pages.PageName = "tabPage1";
        }

        ///////////////////////////////////////////////////////////////////////////////////

        //
        // User Infos
        //
        public void UserInfos()
        {
            USER user = db.USERS.Find(help.Connected);

            FullName.Text   = user.F_NAME + " " + user.L_NAME;
            CINShow.Text    = user.CIN;
            EmailShow.Text  = user.EMAIL;
            PhoneShow.Text  = user.PHONE;
        }
    }
}
