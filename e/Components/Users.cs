using e.Validators;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace e.Components
{
    public partial class Users : UserControl
    {
        // Constructor
        public Users()
        {
            InitializeComponent();
        }

        //
        // Properties
        //
        readonly Helpers    help        = new Helpers();
        readonly Espegic    db          = new Espegic();
        protected int       pageCount   = 0;
        protected int       DID;

        //
        // Load
        //
        private void Users_Load(object sender, EventArgs e)
        {
            // Selected ID on data grid view
            this.Dock   = DockStyle.Fill;
            UserSource();
        }

        //
        // Return to home page
        //
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Pages.PageName = "tabPage1";
        }

        //
        // Navigate to add user
        //
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            CIN.Clear();
            L_Name.Clear();
            F_Name.Clear();
            Phone.Clear();
            Password.Clear();
            Email.Clear();

            ReadUser.Checked        = true;
            ReadProfessor.Checked   = true;
            ReadStudent.Checked     = true;
            ReadFormation.Checked   = true;
            ReadModule.Checked      = true;

            WriteUser.Checked       = true;
            WriteProfessor.Checked  = true;
            WriteStudent.Checked    = true;
            WriteFormation.Checked  = true;
            WriteModule.Checked     = true;

            UpdateUser.Checked      = true;
            UpdateProfessor.Checked = true;
            UpdateStudent.Checked   = true;
            UpdateFormation.Checked = true;
            UpdateModule.Checked    = true;

            DeleteUser.Checked      = true;
            DeleteProfessor.Checked = true;
            DeleteStudent.Checked   = true;
            DeleteFormation.Checked = true;
            DeleteModule.Checked    = true;

            Pages.PageName = "tabPage2";
            SaveBtn.BringToFront();
        }

        //
        // Navigate to update user
        //
        private void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            DID = Convert.ToInt32(View.CurrentRow.Cells["ID"].Value);
            USER user = db.USERS.Find(DID);
            // Fill input
            CIN.Text        = user.CIN;
            L_Name.Text     = user.L_NAME;
            F_Name.Text     = user.F_NAME;
            Phone.Text      = user.PHONE;
            Password.Text   = user.PASSWORD;
            Email.Text      = user.EMAIL;

            PERMISSION read     = db.PERMISSIONS.Where(us => us.USER_ID == DID && us.ACTION == "READ").Single();
            PERMISSION write    = db.PERMISSIONS.Where(us => us.USER_ID == DID && us.ACTION == "WRITE").Single();
            PERMISSION update   = db.PERMISSIONS.Where(us => us.USER_ID == DID && us.ACTION == "UPDATE").Single();
            PERMISSION delete   = db.PERMISSIONS.Where(us => us.USER_ID == DID && us.ACTION == "DELETE").Single();

            // Fill checkbox by selected user
            ReadUser.Checked        = Convert.ToBoolean(read.USERS);
            ReadProfessor.Checked   = Convert.ToBoolean(read.PROFESSORS);
            ReadStudent.Checked     = Convert.ToBoolean(read.STUDENTS);
            ReadFormation.Checked   = Convert.ToBoolean(read.FORMATIONS);
            ReadModule.Checked      = Convert.ToBoolean(read.MODULES);

            WriteUser.Checked       = Convert.ToBoolean(write.USERS);
            WriteProfessor.Checked  = Convert.ToBoolean(write.PROFESSORS);
            WriteStudent.Checked    = Convert.ToBoolean(write.STUDENTS);
            WriteFormation.Checked  = Convert.ToBoolean(write.FORMATIONS);
            WriteModule.Checked     = Convert.ToBoolean(write.MODULES);

            UpdateUser.Checked      = Convert.ToBoolean(update.USERS);
            UpdateProfessor.Checked = Convert.ToBoolean(update.PROFESSORS);
            UpdateStudent.Checked   = Convert.ToBoolean(update.STUDENTS);
            UpdateFormation.Checked = Convert.ToBoolean(update.FORMATIONS);
            UpdateModule.Checked    = Convert.ToBoolean(update.MODULES);

            DeleteUser.Checked      = Convert.ToBoolean(delete.USERS);
            DeleteProfessor.Checked = Convert.ToBoolean(delete.PROFESSORS);
            DeleteStudent.Checked   = Convert.ToBoolean(delete.STUDENTS);
            DeleteFormation.Checked = Convert.ToBoolean(delete.FORMATIONS);
            DeleteModule.Checked    = Convert.ToBoolean(delete.MODULES);

            Pages.PageName = "tabPage2";
            UpdateBtn.BringToFront();

        }

        //
        // Save new user
        //
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Input
            USER user = new USER()
            {
                CIN         = CIN.Text.ToUpper(),
                F_NAME      = L_Name.Text.ToUpper(),
                L_NAME      = F_Name.Text.ToUpper(),
                PHONE       = Phone.Text,
                EMAIL       = Email.Text.ToLower(),
                PASSWORD    = Password.Text,
                ARCHIVE     = false,
                CREATED_BY  = help.Connected,
                UPDATED_BY  = help.Connected,
                CREATED_AT  = DateTime.Now,
                UPDATED_AT  = DateTime.Now
            };

            // Validate data
            UserValidator       validator   = new UserValidator();
            ValidationResult    results     = validator.Validate(user);

            if (results.IsValid)
            {
                // Check if user exist
                if (db.USERS.Where(u => u.CIN == user.CIN || u.EMAIL == user.EMAIL).Count() > 0)
                {
                    MessageBox.Show("L'utilisateur est deja exist");
                }
                else
                {
                    // Check permission to create user
                    if (help.Permitted("WRITE USER"))
                    {
                        // Save user
                        var u = db.USERS.Add(user);
                        db.SaveChanges();

                        // Set permission
                        this.SetPermission(u.ID);

                        // Create history
                        help.CreateHistory("AJOUTER UN UTILISATEUR", user.F_NAME, user.L_NAME, user.CIN);

                        // Refrech data grid view
                        UserSource();

                        MessageBox.Show("L'utilisateur ajouter avec succes");
                        Pages.PageName = "tabPage1";
                    }
                    else
                    {
                        MessageBox.Show("Tu n'a pas la permission pour creer un utilisateur");
                    }
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
        // Update user
        //
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DID = Convert.ToInt32(View.CurrentRow.Cells["ID"].Value);
            // Input text
            USER user = new USER()
            {
                ID          = DID,
                CIN         = CIN.Text.ToUpper(),
                F_NAME      = F_Name.Text.ToUpper(),
                L_NAME      = L_Name.Text.ToUpper(),
                PHONE       = Phone.Text,
                EMAIL       = Email.Text.ToLower(),
                PASSWORD    = Password.Text,
                ARCHIVE     = false,
                CREATED_BY  = db.USERS.Where(u => u.ID == DID).Select(u => u.CREATED_BY).First(),
                CREATED_AT  = db.USERS.Where(u => u.ID == DID).Select(u => u.CREATED_AT).First(),
                UPDATED_BY  = help.Connected,
                UPDATED_AT  = DateTime.Now
            };

            // Validate data
            UserValidator       validator   = new UserValidator();
            ValidationResult    results     = validator.Validate(user);

            if (results.IsValid)
            {
                // Check if any one has same Cin or email
                if (db.USERS.Where(u => u.CIN == user.CIN && u.ID != user.ID).Count() > 0)
                {
                    MessageBox.Show("Vous avez utiliser un CIN qui exist dans un autre compte");
                }
                else if (db.USERS.Where(u => u.EMAIL == user.EMAIL && u.ID != user.ID).Count() > 0)
                {
                    MessageBox.Show("Vous avez utiliser un EMAIL qui exist dans un autre compte");
                }
                else
                {
                    // Check permission to update user
                    if (help.Permitted("UPDATE USER"))
                    {
                        // Update user
                        db.USERS.AddOrUpdate(u => u.ID, user);
                        db.SaveChanges();

                        // Set permission
                        this.UpdatePermission(user.ID);

                        // Create history
                        help.CreateHistory("MODIFIER UN UTILISATEUR", user.F_NAME, user.L_NAME, user.CIN);

                        // Refrech data grid view
                        UserSource();

                        MessageBox.Show("L'utilisateur modifier avec succes");
                        Pages.PageName = "tabPage1";
                    }
                    else
                    {
                        MessageBox.Show("Tu n'a pas la permission pour creer un utilisateur");
                    }
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
        // Archive
        //
        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (help.Permitted("DELETE USER"))
            {
                if (MessageBox.Show($"Voulez vous vraiment supprimer cette utilisateur ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DID = Convert.ToInt32(View.CurrentRow.Cells["ID_Formation"].Value);
                    USER user = db.USERS.Find(DID);
                    user.ARCHIVE = true;
                    db.SaveChanges();
                    UserSource();

                    // Create history
                    help.CreateHistory("SUPPRIMER UN UTILISATEUR", user.F_NAME, user.L_NAME, user.CIN);
                }
            }
            else
            {
                MessageBox.Show("Tu n'a pas la permission pour supprimmer un utilisateur");
            }
        }

        //
        // Search
        //
        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (Search.Text == "")
            {
                UserSource();
            }
            else
            {
                View.DataSource = (from u in db.USERS
                                   where u.ARCHIVE == false && u.ID != help.Connected
                                   where u.CIN.Contains(Search.Text)
                                   || u.F_NAME.Contains(Search.Text)
                                   || u.L_NAME.Contains(Search.Text)
                                   || u.EMAIL.Contains(Search.Text)
                                   || u.PHONE.Contains(Search.Text)
                                   orderby u.UPDATED_AT descending
                                   select new { u.ID, u.CIN, u.L_NAME, u.F_NAME, u.PHONE, u.EMAIL }).Take(10).ToList();
            }
        }

        //
        // Paginate
        //
        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (((db.USERS.Count() - 1) - pageCount) > 10)
                {
                    pageCount += 10;
                    View.DataSource = (from u in db.USERS
                                       where u.ARCHIVE == false && u.ID != help.Connected
                                       orderby u.UPDATED_AT descending
                                       select new { u.ID, u.CIN, u.L_NAME, u.F_NAME, u.PHONE, u.EMAIL }).Skip(pageCount).Take(10).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        // Paginate
        //
        private void Previous_Click(object sender, EventArgs e)
        {
            try
            {
                if (pageCount > 0)
                {
                    pageCount -= 10;
                    View.DataSource = (from u in db.USERS
                                       where u.ARCHIVE == false && u.ID != help.Connected
                                       orderby u.UPDATED_AT descending
                                       select new { u.ID, u.CIN, u.L_NAME, u.F_NAME, u.PHONE, u.EMAIL }).Skip(pageCount).Take(10).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /////////////////////////////////////////////////////////////////////////////

        //
        // Set permission
        //
        protected void SetPermission(int LastID)
        {
            // Read
            PERMISSION read = new PERMISSION()
            {
                USER_ID     = LastID,
                ACTION      = "READ",
                USERS       = ReadUser.Checked,
                PROFESSORS  = ReadProfessor.Checked,
                STUDENTS    = ReadStudent.Checked,
                FORMATIONS  = ReadFormation.Checked,
                MODULES     = ReadModule.Checked
            };

            // Write
            PERMISSION write = new PERMISSION()
            {
                USER_ID     = LastID,
                ACTION      = "WRITE",
                USERS       = WriteUser.Checked,
                PROFESSORS  = WriteProfessor.Checked,
                STUDENTS    = WriteStudent.Checked,
                FORMATIONS  = WriteFormation.Checked,
                MODULES     = WriteModule.Checked
            };

            // Update
            PERMISSION update = new PERMISSION()
            {
                USER_ID     = LastID,
                ACTION      = "UPDATE",
                USERS       = UpdateUser.Checked,
                PROFESSORS  = UpdateProfessor.Checked,
                STUDENTS    = UpdateStudent.Checked,
                FORMATIONS  = UpdateFormation.Checked,
                MODULES     = UpdateModule.Checked
            };

            // Delete
            PERMISSION delete = new PERMISSION()
            {
                USER_ID     = LastID,
                ACTION      = "DELETE",
                USERS       = DeleteUser.Checked,
                PROFESSORS  = DeleteProfessor.Checked,
                STUDENTS    = DeleteStudent.Checked,
                FORMATIONS  = DeleteFormation.Checked,
                MODULES     = DeleteModule.Checked
            };

            // Save permission
            db.PERMISSIONS.AddOrUpdate(us => us.USER_ID, read);
            db.PERMISSIONS.AddOrUpdate(us => us.USER_ID, write);
           db.PERMISSIONS.AddOrUpdate(us => us.USER_ID, update);
            db.PERMISSIONS.AddOrUpdate(us => us.USER_ID, delete);
            db.SaveChanges();
        }

        //
        // Set permission
        //
        protected void UpdatePermission(int userID)
        {
            // Read
            PERMISSION read = db.PERMISSIONS.Where(p => p.USER_ID == userID && p.ACTION == "READ").Single();
            read.USERS = ReadUser.Checked;
            read.PROFESSORS = ReadProfessor.Checked;
            read.STUDENTS = ReadStudent.Checked;
            read.FORMATIONS = ReadFormation.Checked;
           read.MODULES = ReadModule.Checked;

            // Write
            PERMISSION write = db.PERMISSIONS.Where(p => p.USER_ID == userID && p.ACTION == "WRITE").Single();
            write.USERS = WriteUser.Checked;
            write.PROFESSORS = WriteProfessor.Checked;
            write.STUDENTS = WriteStudent.Checked;
            write.FORMATIONS = WriteFormation.Checked;
            write.MODULES = WriteModule.Checked;

            // Update
            PERMISSION update = db.PERMISSIONS.Where(p => p.USER_ID == userID && p.ACTION == "UPDATE").Single();
            update.USERS = UpdateUser.Checked;
            update.PROFESSORS = UpdateProfessor.Checked;
            update.STUDENTS = UpdateStudent.Checked;
            update.FORMATIONS = UpdateFormation.Checked;
            update.MODULES = UpdateModule.Checked;

            // Delete
            PERMISSION delete = db.PERMISSIONS.Where(p => p.USER_ID == userID && p.ACTION == "DELETE").Single();
            delete.USERS = DeleteUser.Checked;
            delete.PROFESSORS = DeleteProfessor.Checked;
            delete.STUDENTS = DeleteStudent.Checked;
            delete.FORMATIONS = DeleteFormation.Checked;
            delete.MODULES = DeleteModule.Checked;

            // Update permission
            db.SaveChanges();
        }
      
        //
        // Data source
        //
        private void UserSource()
        {
            View.DataSource = (from u in db.USERS
                               where u.ARCHIVE == false && u.ID != help.Connected
                               orderby u.UPDATED_AT descending
                               select new { u.ID, u.CIN, u.L_NAME, u.F_NAME, u.PHONE, u.EMAIL }).Take(10).ToList();
        } 
    }
}
