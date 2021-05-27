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
using System.Windows.Forms;

namespace e.Components
{
    public partial class Professors : UserControl
    {
        public Professors()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        //
        // Properties
        //
        readonly    Helpers help = new Helpers();
        readonly    Espegic db = new Espegic();
        protected   int     pageCount = 0;
        protected   int     DID;

        //
        // Load
        //
        private void Professors_Load(object sender, EventArgs e)
        {
            ProfessorSource();
        }

        //
        // Navigate to add professor
        //
        private void AddProfessorBtn_Click(object sender, EventArgs e)
        {
            CIN.Clear();
            L_Name.Clear();
            F_Name.Clear();
            Establishment.Clear();
            Nationality.Clear();
            Province.Clear();
            Commune.Clear();
            Phone.Clear();
            Address.Clear();
            Email.Clear();
            Pages.PageName = "tabPage2";
            SaveBtn.BringToFront();
        }

        //
        // Return to home page
        //
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Pages.PageName = "tabPage1";
        }

        //
        // Navigate to update professor
        //
        private void UpdateProfessorBtn_Click(object sender, EventArgs e)
        {
            DID = Convert.ToInt32(View.CurrentRow.Cells["ID"].Value);
            PROFESSOR professor = db.PROFESSORS.Find(DID);
            CIN.Text            = professor.CIN;
            L_Name.Text         = professor.L_NAME;
            F_Name.Text         = professor.F_NAME;
            Phone.Text          = professor.PHONE;
            Sex.Text            = professor.SEX;
            Establishment.Text  = professor.ESTABLISHEMENT;
            Nationality.Text    = professor.NATIONALITY;
            Province.Text       = professor.PROVINCE;
            Commune.Text        = professor.COMMUN;
            Birth.Value         = DateTime.Parse(professor.BIRTH.ToString());
            Address.Text        = professor.ADRESS;
            Email.Text          = professor.EMAIL;

            Pages.PageName = "tabPage2";
            UpdateBtn.BringToFront();
        }

        //
        // Save new professor
        //
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Input text
            PROFESSOR professor = new PROFESSOR()
            {
                CIN             = CIN.Text.ToUpper(),
                F_NAME          = L_Name.Text.ToUpper(),
                L_NAME          = F_Name.Text.ToUpper(),
                PHONE           = Phone.Text,
                EMAIL           = Email.Text.ToLower(),
                SEX             = Sex.Text.ToUpper(),
                ESTABLISHEMENT  = Establishment.Text.ToUpper(),
                NATIONALITY     = Nationality.Text.ToUpper(),
                PROVINCE        = Province.Text.ToUpper(),
                COMMUN          = Commune.Text.ToUpper(),
                ADRESS          = Address.Text.ToUpper(),
                BIRTH           = Birth.Value,
                ARCHIVE         = false,
                CREATED_BY      = help.Connected,
                UPDATED_BY      = help.Connected,
                CREATED_AT      = DateTime.Now,
                UPDATED_AT      = DateTime.Now
            };


            // Validate data
            ProfessorValidator  validator   = new ProfessorValidator();
            ValidationResult    results     = validator.Validate(professor);

            if (results.IsValid)
            {
                // Check if professor exist
                if (db.PROFESSORS.Where(p => p.CIN == professor.CIN || p.EMAIL == professor.EMAIL).Count() > 0)
                {
                    MessageBox.Show("Le professeur existe déjà");
                }
                else
                {
                    // Check permission to create professor
                    if (help.Permitted("WRITE PROFESSOR"))
                    {
                        // Save professor
                        var p = db.PROFESSORS.Add(professor);
                        db.SaveChanges();

                        // Create history
                        help.CreateHistory("AJOUTER UN PROFESSEUR", professor.F_NAME, professor.L_NAME, professor.CIN);

                        // Refrech data grid view
                        ProfessorSource();

                        MessageBox.Show("Le professeur ajouté avec succés");
                        Pages.PageName = "tabPage1";
                    }
                    else
                    {
                        MessageBox.Show("Tu n'a pas la permission pour créer un professeur");
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
        // Update Professor
        //
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DID = Convert.ToInt32(View.CurrentRow.Cells["ID"].Value);

            // Input text
            PROFESSOR professor = new PROFESSOR()
            {
                ID              = DID,
                CIN             = CIN.Text.ToUpper(),
                F_NAME          = L_Name.Text.ToUpper(),
                L_NAME          = F_Name.Text.ToUpper(),
                PHONE           = Phone.Text,
                EMAIL           = Email.Text.ToLower(),
                SEX             = Sex.Text.ToUpper(),
                ESTABLISHEMENT  = Establishment.Text.ToUpper(),
                NATIONALITY     = Nationality.Text.ToUpper(),
                PROVINCE        = Province.Text.ToUpper(),
                COMMUN          = Commune.Text.ToUpper(),
                ADRESS          = Address.Text.ToUpper(),
                BIRTH           = Birth.Value,
                ARCHIVE         = false,
                UPDATED_BY      = help.Connected,
                UPDATED_AT      = DateTime.Now
            };


            // Validate data
            ProfessorValidator  validator   = new ProfessorValidator();
            ValidationResult    results     = validator.Validate(professor);

            if (results.IsValid)
            {
                // Check if any one has same Cin or email
                if (db.PROFESSORS.Where(p => p.CIN == professor.CIN && p.ID != professor.ID).Count() > 0)
                {
                    MessageBox.Show("Vous avez utilisé un CIN qui existe dans un autre compte");
                }
                else if (db.PROFESSORS.Where(p => p.EMAIL == professor.EMAIL && p.ID != professor.ID).Count() > 0)
                {
                    MessageBox.Show("Vous avez utilisé un EMAIL qui existe dans un autre compte");
                }
                else
                {
                    // Check permission to update professor
                    if (help.Permitted("UPDATE PROFESSOR"))
                    {
                        // Update professor
                        db.PROFESSORS.AddOrUpdate(p => p.ID, professor);
                        db.SaveChanges();

                        // Create history
                        help.CreateHistory("MODIFIER UN PROFESSEUR", professor.F_NAME, professor.L_NAME, professor.CIN);

                        // Refrech data grid view
                        ProfessorSource();

                        MessageBox.Show("Le professeur modifié avec succés");
                        Pages.PageName = "tabPage1";
                    }
                    else
                    {
                        MessageBox.Show("Tu n'a pas la permission pour modifier un professeur");
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
        // Professor to archive
        //
        private void DeleteProfessor_Click(object sender, EventArgs e)
        {
            if (help.Permitted("DELETE PROFESSOR"))
            {
                if (MessageBox.Show($"Voulez vous vraiment supprimer ce professeur ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DID = Convert.ToInt32(View.CurrentRow.Cells["ID"].Value);
                    var professor = db.PROFESSORS.Find(DID);
                    professor.ARCHIVE = true;
                    db.SaveChanges();
                    ProfessorSource();

                    // Create history
                    help.CreateHistory("SUPPRIMER UN PROFESSEUR", professor.F_NAME, professor.L_NAME, professor.CIN);
                }
            }
            else
            {
                MessageBox.Show("Tu n'a pas la permission pour supprimmer un professeur");
            }
        }

        //
        // Search
        //
        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (Search.Text == "")
            {
                ProfessorSource();
            }
            else
            {
                View.DataSource = (from p in db.PROFESSORS
                                   where p.ARCHIVE == false
                                   where p.CIN.Contains(Search.Text)
                                   || p.F_NAME.Contains(Search.Text)
                                   || p.L_NAME.Contains(Search.Text)
                                   || p.EMAIL.Contains(Search.Text)
                                   || p.PHONE.Contains(Search.Text)
                                   orderby p.UPDATED_AT descending
                                   select new { p.ID, p.CIN, p.L_NAME, p.F_NAME, p.PHONE, p.EMAIL }).Take(10).ToList();
            }
        }

        //
        // Paginate
        //
        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                if ((db.PROFESSORS.Count() - pageCount) > 10)
                {
                    pageCount += 10;
                    View.DataSource = (from p in db.PROFESSORS
                                       where p.ARCHIVE == false
                                       orderby p.UPDATED_AT descending
                                       select new { p.ID, p.CIN, p.L_NAME, p.F_NAME, p.PHONE, p.EMAIL }).Skip(pageCount).Take(10).ToList();
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
                    View.DataSource = (from p in db.PROFESSORS
                                       where p.ARCHIVE == false
                                       orderby p.UPDATED_AT descending
                                       select new { p.ID, p.CIN, p.L_NAME, p.F_NAME, p.PHONE, p.EMAIL }).Skip(pageCount).Take(10).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        // Show professor informations
        //
        private void View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DID = Convert.ToInt32(View.CurrentRow.Cells["ID"].Value);

            PROFESSOR professor = db.PROFESSORS.Find(DID);

            CINShow.Text            = professor.CIN;
            FullName.Text           = professor.F_NAME + " " + professor.L_NAME;
            PhoneShow.Text          = professor.PHONE;
            SexShow.Text            = professor.SEX;
            EstablishmentShow.Text  = professor.ESTABLISHEMENT;
            NationalityShow.Text    = professor.NATIONALITY;
            ProvinceShow.Text       = professor.PROVINCE;
            CommuneShow.Text        = professor.COMMUN;
            AddressShow.Text        = professor.ADRESS;
            EmailShow.Text          = professor.EMAIL;
            BirthShow.Text          = professor.BIRTH.ToString();

            Pages.PageName = "tabPage3";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////

        //
        // Data source
        //
        private void ProfessorSource()
        {
            View.DataSource = (from p in db.PROFESSORS
                               where p.ARCHIVE == false
                               orderby p.UPDATED_AT descending
                               select new { p.ID, p.CIN, p.L_NAME, p.F_NAME, p.PHONE, p.EMAIL }).Take(10).ToList();
        }
    }
}
