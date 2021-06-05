﻿using e.Validators;
using System;
using FluentValidation.Results;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace e.Components
{
    public partial class Students : UserControl
    {
        public Students()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        //
        // Properties
        //
        readonly    Helpers help   = new Helpers();
        readonly    Espegic db     = new Espegic();
        protected   int pageCount   = 0;
        protected   int DID;

        //
        // Load
        //
        private void Students_Load(object sender, EventArgs e)
        {
            StudentSource();
            FormationName.DataSource = (from f in db.FORMATIONS
                                        select new { f.NAME }).ToList();

            FormationName.DisplayMember = "NAME";

        }

        //
        // Navigate to add student
        //
        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            CIN.Clear();
            L_Name.Clear();
            F_Name.Clear();
            Establishment.Clear();
            Sex.SelectedIndex = -1;
            FormationName.SelectedIndex = -1;
            Nationality.Clear();
            Province.Clear();
            Commune.Clear();
            Massar_ID.Clear();
            Reduction.Clear();
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
        // Return to profile page
        //
        private void ReturnProfileBtn_Click(object sender, EventArgs e)
        {
            Pages.PageName = "tabPage3";
        }

        //
        // Navigate to update student
        //
        private void UpdateStudentBtn_Click(object sender, EventArgs e)
        {
            DID = Convert.ToInt32(View.CurrentRow.Cells["ID"].Value);
            STUDENT student = db.STUDENTS.Find(DID);
            CIN.Text            = student.CIN;
            //FormationName.Text  = db.FORMATIONS.Where(f => f.ID == student.FORMATION_ID).Select(f => f.NAME).First();
            L_Name.Text         = student.L_NAME;
            F_Name.Text         = student.F_NAME;
            Establishment.Text  = student.ESTABLISHEMENT;
            Sex.Text            = student.SEX;
            Nationality.Text    = student.NATIONALITY;
            Province.Text       = student.PROVINCE;
            Commune.Text        = student.COMMUN;
            Massar_ID.Text      = student.MASSAR;
            Reduction.Text      = "";
            Birth.Value         = DateTime.Parse(student.BIRTH.ToString());
            Phone.Text          = student.PHONE;
            Address.Text        = student.ADRESS;
            Email.Text          = student.EMAIL;
            Pages.PageName = "tabPage2";
            UpdateBtn.BringToFront();
        }

        //
        // Save new student
        //
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Extract Formation ID
            int FormationID = db.FORMATIONS.Where(f => f.NAME == FormationName.Text).Select(f =>f.ID).First();

            // Input text
            STUDENT student = new STUDENT()
            {
                //FORMATION_ID    = FormationID,
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
                MASSAR          = Massar_ID.Text.ToUpper(),
                ADRESS          = Address.Text.ToUpper(),
                BIRTH           = Birth.Value,
                ARCHIVE         = false,
                CREATED_BY      = help.Connected,
                UPDATED_BY      = help.Connected,
                CREATED_AT      = DateTime.Now,
                UPDATED_AT      = DateTime.Now
            };

            // Validate data
            StudentValidator validator  = new StudentValidator();
            ValidationResult results    = validator.Validate(student);

            if (results.IsValid)
            {
                // Check if student exist
                if (db.STUDENTS.Where(s => s.CIN == student.CIN || s.EMAIL == student.EMAIL).Count() > 0)
                {
                    MessageBox.Show("L'étudiant existe déjà");
                }
                else
                {
                    // Check permission to create student
                    if (help.Permitted("WRITE STUDENT"))
                    {
                        // Save student
                        db.STUDENTS.Add(student);
                        db.SaveChanges();

                        // Create history
                        help.CreateHistory("AJOUTER UN ETUDIANT", student.F_NAME, student.L_NAME, student.CIN);

                        // Refrech data grid view
                        StudentSource();

                        MessageBox.Show("L'étudiant ajouté avec succés");
                        Pages.PageName = "tabPage1";
                    }
                    else
                    {
                        MessageBox.Show("Tu n'a pas la permission pour créer un étudiant");
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
        // Update Student
        //
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Extract Formation ID
            int FormationID = db.FORMATIONS.Where(f => f.NAME == FormationName.Text).Select(f => f.ID).First();
            DID = Convert.ToInt32(View.CurrentRow.Cells["ID"].Value);
            // Input text
            STUDENT student = new STUDENT()
            {
                ID                = DID,
                FORMATION_ID      = FormationID,
                CIN               = CIN.Text.ToUpper(),
                F_NAME            = L_Name.Text.ToUpper(),
                L_NAME            = F_Name.Text.ToUpper(),
                PHONE             = Phone.Text,
                EMAIL             = Email.Text.ToLower(),
                SEX               = Sex.Text.ToUpper(),
                ESTABLISHEMENT    = Establishment.Text.ToUpper(),
                NATIONALITY       = Nationality.Text.ToUpper(),
                PROVINCE          = Province.Text.ToUpper(),
                COMMUN            = Commune.Text.ToUpper(),
                MASSAR            = Massar_ID.Text.ToUpper(),
                ADRESS            = Address.Text.ToUpper(),
                BIRTH             = Birth.Value,
                ARCHIVE           = false,
                CREATED_BY        = db.STUDENTS.Where(s => s.ID == DID).Select(s => s.CREATED_BY).First(),
                CREATED_AT        = db.STUDENTS.Where(s => s.ID == DID).Select(s => s.CREATED_AT).First(),
                UPDATED_BY        = help.Connected,
                UPDATED_AT        = DateTime.Now
            };
          

            // Validate data
            StudentValidator validator  = new StudentValidator();
            ValidationResult results    = validator.Validate(student);

            if (results.IsValid)
            {
                // Check if any one has same Cin or email
                if (db.STUDENTS.Where(s => s.CIN == student.CIN && s.ID != student.ID).Count() > 0)
                {
                    MessageBox.Show("Vous avez utilisé un CIN qui existe dans un autre compte");
                }
                else if (db.STUDENTS.Where(s => s.EMAIL == student.EMAIL && s.ID != student.ID).Count() > 0)
                {
                    MessageBox.Show("Vous avez utilisé un EMAIL qui existe dans un autre compte");
                }
                else
                {
                    // Check permission to create student
                    if (help.Permitted("UPDATE STUDENT"))
                    {
                        // Save student
                        db.STUDENTS.AddOrUpdate(s => s.ID, student);
                        db.SaveChanges();

                        // Create history
                        help.CreateHistory("MODIFIER UN ETUDIANT", student.F_NAME, student.L_NAME, student.CIN);

                        // Refrech data grid view
                        StudentSource();

                        MessageBox.Show("L'étudiant modifié avec succés");
                        Pages.PageName = "tabPage1";
                    }
                    else
                    {
                        MessageBox.Show("Tu n'a pas la permission pour modifier un étudiant");
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
        // Student to archive
        //
        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            // Check permission
            if (help.Permitted("DELETE STUDENT"))
            {
                if (MessageBox.Show($"Voulez vous vraiment supprimer cet étudiant ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DID = Convert.ToInt32(View.CurrentRow.Cells["ID"].Value);
                    STUDENT student = db.STUDENTS.Find(DID);
                    student.ARCHIVE = true;
                    db.SaveChanges();
                    StudentSource();

                    // Create history
                    help.CreateHistory("SUPPRIMER UN ETUDIANT", student.F_NAME, student.L_NAME, student.CIN);
                }
            }
            else
            {
                MessageBox.Show("Tu n'a pas la permission pour supprimmer un étudiant");
            }
        }

        //
        // Search
        //
        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (Search.Text == "")
            {
                StudentSource();
            }
            else
            {
                View.DataSource = (from s in db.STUDENTS
                                   where s.ARCHIVE == false
                                   where s.CIN.Contains(Search.Text)
                                   || s.F_NAME.Contains(Search.Text)
                                   || s.L_NAME.Contains(Search.Text)
                                   || s.EMAIL.Contains(Search.Text)
                                   || s.PHONE.Contains(Search.Text)
                                   orderby s.UPDATED_AT descending
                                   select new { s.ID, s.CIN, s.L_NAME, s.F_NAME, s.PHONE, s.EMAIL }).Take(10).ToList();
            }
        }

        //
        // Paginate
        //
        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                if ((db.STUDENTS.Count() - pageCount) > 10)
                {
                    pageCount += 10;
                    View.DataSource = (from s in db.STUDENTS
                                       where s.ARCHIVE == false
                                       orderby s.UPDATED_AT descending
                                       select new { s.ID, s.CIN, s.L_NAME, s.F_NAME, s.PHONE, s.EMAIL }).Skip(pageCount).Take(10).ToList();
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
                    View.DataSource = (from s in db.STUDENTS
                                       where s.ARCHIVE == false
                                       orderby s.UPDATED_AT descending
                                       select new { s.ID, s.CIN, s.L_NAME, s.F_NAME, s.PHONE, s.EMAIL }).Skip(pageCount).Take(10).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        // Show student informations
        //
        private void View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DID = Convert.ToInt32(View.CurrentRow.Cells["ID"].Value);
            STUDENT student = db.STUDENTS.Find(DID);

            CINShow.Text            = student.CIN;
            FullName.Text           = student.F_NAME + " " + student.L_NAME;
            PhoneShow.Text          = student.PHONE;
            SexShow.Text            = student.SEX;
            EstablishmentShow.Text  = student.ESTABLISHEMENT;
            NationalityShow.Text    = student.NATIONALITY;
            ProvinceShow.Text       = student.PROVINCE;
            MassarShow.Text         = student.MASSAR;
            CommuneShow.Text        = student.COMMUN;
            AddressShow.Text        = student.ADRESS;
            EmailShow.Text          = student.EMAIL;
            BirthShow.Text          = student.BIRTH.ToString();
            FormationNameShow.Text  = db.FORMATIONS.Where(f => f.ID == student.FORMATION_ID).Select(f => f.NAME).First();

            IsEnabled();

            Pages.PageName = "tabPage3";
        }

        //
        // Show payment informations
        //
        private void Month_Click(object sender, EventArgs e)
        {
            // Button btn = sender as Button;
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;

            switch (btn.Text)
            {
                // mois => combobox
                // change color when year changed
                // print recu after buying

                case "Janvier":
                    Payment(1);
                    break;

                case "Fevrier":
                    Payment(2);
                    break;

                case "Mars":
                    Payment(3);
                    break;

                case "Avril":
                    Payment(4);
                    break;

                case "Mai":
                    Payment(5);
                    break;

                case "Juin":
                    Payment(6);
                    break;

                case "Juillet":
                    Payment(7);
                    break;

                case "Aout":
                    Payment(8);
                    break;

                case "Septembre":
                    Payment(9);
                    break;

                case "Octobre":
                    Payment(10);
                    break;

                case "Novembre":
                    Payment(11);
                    break;

                case "Decembre":
                    Payment(12);
                    break;
                default:
                    break;
            }

        }

        //
        // Go to payment page
        //
        private void PayBtn_Click(object sender, EventArgs e)
        {
            Pages.PageName = "tabPage5";
        }

        //
        // Enable / Disable buttons
        //
        private void Year_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IsEnabled();
        }

        ///////////////////////////////////////////////////////////////////////////////////

        //
        // Data source
        //
        private void StudentSource()
        {
            View.DataSource = (from s in db.STUDENTS
                               where s.ARCHIVE == false
                               orderby s.UPDATED_AT descending
                               select new { s.ID, s.CIN, s.L_NAME, s.F_NAME, s.PHONE, s.EMAIL }).Take(10).ToList();
        }

        //
        // Payment source
        //
        private void Payment (int month)
        {

            if (IsPayed(month).Count() > 0)
            {
                MonthShow.Text      = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
                PriceShow.Text      = IsPayed(month).Select(p => p.PRICE).First().ToString() + " DH";
                PayedAtShow.Text    = IsPayed(month).Select(p => p.CREATED_AT).First().ToString();
                PayedShow.Text      = IsPayed(month).Select(p => p.PAYED).First().ToString();
                StillShow.Text      = IsPayed(month).Select(p => p.STILL).First().ToString();

                Pages.PageName = "tabPage4";
            }
        }

        //
        // Check button
        //
        private void IsEnabled()
        {
            Janvier.Enabled     = IsPayed(1).Count() > 0;
            Fevrier.Enabled     = IsPayed(2).Count() > 0;
            Mars.Enabled        = IsPayed(3).Count() > 0;
            Avril.Enabled       = IsPayed(4).Count() > 0;
            Mai.Enabled         = IsPayed(5).Count() > 0;
            Juin.Enabled        = IsPayed(6).Count() > 0;
            Juillet.Enabled     = IsPayed(7).Count() > 0;
            Aout.Enabled        = IsPayed(8).Count() > 0;
            Septembre.Enabled   = IsPayed(9).Count() > 0;
            Octobre.Enabled     = IsPayed(10).Count() > 0;
            Novembre.Enabled    = IsPayed(11).Count() > 0;
            Decembre.Enabled    = IsPayed(12).Count() > 0;
        }

        //
        // Check if current month payed
        //
        public IQueryable<PAYMENT> IsPayed(int month = 0)
        {
            int YearToInt = Convert.ToInt32(Year.Text);
            DID = Convert.ToInt32(View.CurrentRow.Cells["ID"].Value);
            return from p in db.PAYMENTs
                   where p.MONTH == month
                   where p.YEAR == YearToInt
                   where p.STUDENT_ID == DID
                   select p;
        }


    }
}   
