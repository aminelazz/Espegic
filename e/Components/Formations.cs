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
    public partial class Formations : UserControl
    {
        public Formations()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        //
        // Properties
        //
        readonly    Helpers help        = new Helpers();
        readonly    Espegic db          = new Espegic();
        protected   int     pageCount   = 0;
        protected   int     DID;

        //
        // Load
        //
        private void Formations_Load(object sender, EventArgs e)
        {
            // Selected ID on data grid view
            FormationSource();
            ModuleSource();
        }

        //
        // Return to formation page
        //
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Pages.PageName = "tabPage1";
        }

        //
        // Navigate to add formation
        //
        private void AddFormation_Click(object sender, EventArgs e)
        {
            FormationName.Clear();
            FormationDuration.Clear();
            FormationPrice.Clear();
            Pages.PageName = "tabPage2";
            CreateFormation.BringToFront();
        }

        //
        // Navigate to update formation
        //
        private void UpdateFormationBtn_Click(object sender, EventArgs e)
        {
            DID = Convert.ToInt32(ViewFormation.CurrentRow.Cells["ID_Formation"].Value);
            FORMATION formation = db.FORMATIONS.Find(DID);
            FormationName.Text = formation.NAME;
            FormationDuration.Text = formation.DURATION.ToString();
            FormationPrice.Text = formation.PRICE;

            Pages.PageName = "tabPage2";
            UpdateFormation.BringToFront();
        }

        //
        // Navigate to module
        //
        private void ModuleBtn_Click(object sender, EventArgs e)
        {
            Pages.PageName = "tabPage3";
        }

        //
        // Navigate to add module
        //
        private void AddModule_Click(object sender, EventArgs e)
        {
            ModuleName.Clear();
            ModuleFormationName.SelectedIndex = -1;

            Pages.PageName = "tabPage4";
            CreateModule.BringToFront();
        }

        //
        // Navigate to update module
        //
        private void UpdateModuleBtn_Click(object sender, EventArgs e)
        {
            DID = Convert.ToInt32(ViewFormation.CurrentRow.Cells["ID_Formation"].Value);
            MODULE module = db.MODULES.Find(DID);
            ModuleName.Text         = module.NAME;
            FormationDuration.Text  = db.FORMATIONS.Where(f => f.ID == module.FORMATION_ID).Select(f => f.NAME).First();

            Pages.PageName = "tabPage4";
            UpdateModule.BringToFront();
        }

        //
        // Save Formation
        //
        private void CreateFormation_Click(object sender, EventArgs e)
        {
            // Input text
            FORMATION formation = new FORMATION()
            {
                NAME        = FormationName.Text,
                DURATION    = int.Parse(FormationDuration.Text),
                PRICE       = FormationPrice.Text,
                ARCHIVE     = false,
                CREATED_BY  = help.Connected,
                UPDATED_BY  = help.Connected,
                CREATED_AT  = DateTime.Now,
                UPDATED_AT  = DateTime.Now
            };

            // Validate data
            FormationValidator  validator   = new FormationValidator();
            ValidationResult    results     = validator.Validate(formation);

            if (results.IsValid)
            { 
                // Check permission to create formation
                if (help.Permitted("WRITE FORMATION"))
                {
                    // Save formation
                    db.FORMATIONS.Add(formation);
                    db.SaveChanges();

                    // Create history
                    help.CreateHistory("AJOUTER UNE FORMATION", formation.NAME, "", "");

                    // Refrech data grid view
                    FormationSource();

                    MessageBox.Show("La formation ajoutée avec succés");
                    Pages.PageName = "tabPage1";
                }
                else
                {
                    MessageBox.Show("Tu n'a pas la permission pour créer une formation");
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
        // Update Formation
        //
        private void UpdateFormation_Click(object sender, EventArgs e)
        {
            DID = Convert.ToInt32(ViewFormation.CurrentRow.Cells["ID_Formation"].Value);
            FORMATION formation = new FORMATION()
            {
                ID          = DID,
                NAME        = FormationName.Text,
                DURATION    = int.Parse(FormationDuration.Text),
                PRICE       = FormationPrice.Text,
                ARCHIVE     = false,
                UPDATED_BY  = help.Connected,
                UPDATED_AT  = DateTime.Now
            };


            // Validate data
            FormationValidator  validator   = new FormationValidator();
            ValidationResult    results     = validator.Validate(formation);

            if (results.IsValid)
            {
                // Check permission to update formation
                if (help.Permitted("UPDATE FORMATION"))
                {
                    // Save formation
                    db.FORMATIONS.AddOrUpdate(f => f.ID, formation);
                    db.SaveChanges();

                    // Create history
                    help.CreateHistory("MODIFIER UNE FORMATION", formation.NAME, "", "");

                    // Refrech data grid view
                    FormationSource();

                    MessageBox.Show("La formation modifiée avec succés");
                    Pages.PageName = "tabPage1";
                }
                else
                {
                    MessageBox.Show("Tu n'a pas la permission pour modifier une formation");
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
        private void DeleteFormationBtn_Click(object sender, EventArgs e)
        {
            if (help.Permitted("DELETE FORMATION"))
            {
                if (MessageBox.Show($"Voulez vous vraiment supprimer cette formation ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DID = Convert.ToInt32(ViewFormation.CurrentRow.Cells["ID_Formation"].Value);
                    FORMATION formation = db.FORMATIONS.Find(DID);
                    formation.ARCHIVE = true;
                    db.SaveChanges();
                    FormationSource();

                    // Create history
                    help.CreateHistory("SUPPRIMER UNE FORMATION", formation.NAME, "", "");
                }
            }
            else
            {
                MessageBox.Show("Tu n'a pas la permission pour supprimmer une formation");
            }
        }

        //
        // Create Module
        //
        private void CreateModule_Click(object sender, EventArgs e)
        {
            // Extract Formation ID
            int FormationID = db.FORMATIONS.Where(f => f.NAME == FormationName.Text).Select(f => f.ID).First();

            // Input text
            MODULE module = new MODULE()
            {
                FORMATION_ID    = FormationID,
                NAME            = ModuleName.Text,
                ARCHIVE         = false,
                CREATED_BY      = help.Connected,
                UPDATED_BY      = help.Connected,
                CREATED_AT      = DateTime.Now,
                UPDATED_AT      = DateTime.Now
            };

            // Validate data
            ModuleValidator     validator   = new ModuleValidator();
            ValidationResult    results     = validator.Validate(module);

            if (results.IsValid)
            {
                // Check permission to create module
                if (help.Permitted("WRITE MODULE"))
                {
                    // Save module
                    var p = db.MODULES.Add(module);
                    db.SaveChanges();

                    // Create history
                    help.CreateHistory("AJOUTER UN MODULE", module.NAME, "", "");

                    // Refrech data grid view
                    ModuleSource();

                    MessageBox.Show("Le module ajouté avec succés");
                    Pages.PageName = "tabPage1";
                }
                else
                {
                    MessageBox.Show("Tu n'a pas la permission pour créer un module");
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
        // Update Module
        //
        private void UpdateModule_Click(object sender, EventArgs e)
        {
            // Extract Formation ID
            int FormationID = db.FORMATIONS.Where(f => f.NAME == FormationName.Text).Select(f => f.ID).First();

            DID = Convert.ToInt32(ViewFormation.CurrentRow.Cells["ID_Formation"].Value);

            // Input text
            MODULE module = new MODULE()
            {
                ID              = DID,
                FORMATION_ID    = FormationID,
                NAME            = ModuleName.Text,
                ARCHIVE         = false,
                UPDATED_BY      = help.Connected,
                UPDATED_AT      = DateTime.Now
            };

            // Validate data
            ModuleValidator     validator   = new ModuleValidator();
            ValidationResult    results     = validator.Validate(module);

            if (results.IsValid)
            {
                // Check permission to update module
                if (help.Permitted("UPDATE MODULE"))
                {
                    // Save formation
                    db.MODULES.AddOrUpdate(m => m.ID, module);
                    db.SaveChanges();

                    // Create history
                    help.CreateHistory("MODIFIER UN MODULE", module.NAME, "", "");

                    // Refrech data grid view
                    ModuleSource();

                    MessageBox.Show("Le module modifié avec succés");
                    Pages.PageName = "tabPage1";
                }
                else
                {
                    MessageBox.Show("Tu n'a pas la permission pour modifier un module");
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
        // Module to archive
        //
        private void DeleteModuleBtn_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ViewModule.CurrentRow.Cells["ID_MODULE"].Value);

            if (help.Permitted("DELETE MODULE"))
            {
                if (MessageBox.Show($"Voulez vous vraiment supprimer ce module ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MODULE module = db.MODULES.Find(ID);
                    module.ARCHIVE = true;
                    db.SaveChanges();
                    ModuleSource();

                    // Create history
                    help.CreateHistory("SUPPRIMER UN MODULE", module.NAME, "", "");
                }
            }
            else
            {
                MessageBox.Show("Tu n'a pas la permission pour supprimmer un module");
            }
        }

        //
        // Search Formation
        //
        private void SearchFormation_KeyUp(object sender, KeyEventArgs e)
        {
            if (SearchFormation.Text == "")
            {
                FormationSource();
            }
            else
            {
                ViewFormation.DataSource = (from f in db.FORMATIONS
                                   where f.ARCHIVE == false
                                   where f.NAME.Contains(SearchFormation.Text)
                                   || f.DURATION.ToString().Contains(SearchFormation.Text)
                                   || f.PRICE.Contains(SearchFormation.Text)
                                   orderby f.UPDATED_AT descending
                                   select new { f.ID, f.NAME, f.DURATION, f.PRICE }).Take(10).ToList();
            }
        }

        //
        // Paginate Next Formations
        //
        private void NextFormation_Click(object sender, EventArgs e)
        {
            try
            {
                if ((db.FORMATIONS.Count() - pageCount) > 10)
                {
                    pageCount += 10;
                    ViewFormation.DataSource = (from f in db.FORMATIONS
                                       where f.ARCHIVE == false
                                       orderby f.UPDATED_AT descending
                                       select new { f.ID, f.NAME, f.DURATION, f.PRICE }).Skip(pageCount).Take(10).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        // Paginate Previous Formations
        //
        private void PreviousFormation_Click(object sender, EventArgs e)
        {
            try
            {
                if (pageCount > 0)
                {
                    pageCount -= 10;
                    ViewFormation.DataSource = (from f in db.FORMATIONS
                                       where f.ARCHIVE == false
                                       orderby f.UPDATED_AT descending
                                       select new { f.ID, f.NAME, f.DURATION, f.PRICE }).Skip(pageCount).Take(10).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        // Search Module
        //
        private void SearchModule_KeyUp(object sender, KeyEventArgs e)
        {
            if (SearchModule.Text == "")
            {
                ModuleSource();
            }
            else
            {
                //ViewFormation.DataSource = (from m in db.MODULES
                //                            where m.ARCHIVE == false
                //                            where m.NAME.Contains(SearchModule.Text)
                //                            orderby m.UPDATED_AT descending
                //                            join FORMATIONS
                //                            select new { m.ID, m.NAME }).Take(10).ToList();
            }
        }

        //
        // Paginate Next Modules
        //
        private void NextModule_Click(object sender, EventArgs e)
        {
            try
            {
                if ((db.MODULES.Count() - pageCount) > 10)
                {
                    pageCount += 10;
                    //ViewFormation.DataSource = (from m in db.MODULES
                    //                            where m.ARCHIVE == false
                    //                            where m.NAME.Contains(SearchModule.Text)
                    //                            orderby m.UPDATED_AT descending
                    //                            join FORMATIONS
                    //                            select new { m.ID, m.NAME }).Skip(pageCount).Take(10).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        // Paginate Previous Modules
        //
        private void PreviousModule_Click(object sender, EventArgs e)
        {
            try
            {
                if (pageCount > 0)
                {
                    pageCount -= 10;
                    //ViewFormation.DataSource = (from m in db.MODULES
                    //                            where m.ARCHIVE == false
                    //                            where m.NAME.Contains(SearchModule.Text)
                    //                            orderby m.UPDATED_AT descending
                    //                            join FORMATIONS
                    //                            select new { m.ID, m.NAME }).Skip(pageCount).Take(10).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////

        //
        // Data source formation
        //
        private void FormationSource()
        {
            ViewFormation.DataSource = (from f in db.FORMATIONS
                                        where f.ARCHIVE == false
                                        orderby f.UPDATED_AT descending
                                        select new { f.ID, f.NAME, f.DURATION, f.PRICE }).Take(10).ToList();
        }

        //
        // Data source formation
        //
        private void ModuleSource()
        {
            //ViewFormation.DataSource = (from m in db.MODULES
            //                            where m.ARCHIVE == false
            //                            where m.NAME.Contains(SearchModule.Text)
            //                            orderby m.UPDATED_AT descending
            //                            join FORMATIONS
            //                            select new { m.ID, m.NAME }).Take(10).ToList();
        }
    }
}
