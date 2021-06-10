using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e.Components
{
    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();

            // Fill year
            List<int> years = new List<int>();
            for (int i = 2016; i <= DateTime.Now.Year; i++)
            {
                years.Add(i);
            }

            // Bind years to combobox
            year.DataSource = years;
            year2.DataSource = years;

            // Default selected year
            year.SelectedItem = DateTime.Now.Year;
            year2.SelectedItem = DateTime.Now.Year;

            // Month
            Dictionary<string, int> m = new Dictionary<string, int>()
            {
                { "Janvier"  , 1 },
                { "Fevrier"  , 2 },
                { "Mars"     , 3 },
                { "Avril"    , 4 },
                { "Mai"      , 5 },
                { "Juin"     , 6 },
                { "Juilet"   , 7 },
                { "Aout"     , 8 },
                { "Septembre", 9 },
                { "Octobre"  , 10 },
                { "Novembre" , 11 },
                { "Decembre" , 12 }
            };

            // Bind month to combobox
            month.DataSource = new BindingSource(m, null);
            month.DisplayMember = "Key";
            month.ValueMember = "Value";
            month2.DataSource = new BindingSource(m, null);
            month2.DisplayMember = "Key";
            month2.ValueMember = "Value";

            // Default selected month
            month.SelectedItem = "Janvier";
            month2.SelectedItem = "Janvier";
        }
        

        //
        // Properties
        //
        readonly Helpers help = new Helpers();
        readonly Espegic db = new Espegic();

        //
        // Search
        //
        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (Search.Text == "")
            {
                ID.Clear();
                Cin.Clear();
                fullName.Clear();
                email.Clear();
            }
            else
            {
                var student = (from s in db.STUDENTS
                                   where s.ARCHIVE == false
                                   where s.CIN.Contains(Search.Text)
                                   || s.F_NAME.Contains(Search.Text)
                                   || s.L_NAME.Contains(Search.Text)
                                   || s.EMAIL.Contains(Search.Text)
                                   || s.PHONE.Contains(Search.Text)
                                   select s).ToList();
                // Fill text box
                if (student.Count() > 0)
                {
                    var s = student.FirstOrDefault();
                    ID.Text = s.ID.ToString();
                    Cin.Text = s.CIN.ToString();
                    fullName.Text = s.F_NAME.ToString() + " " + s.L_NAME.ToString();
                    email.Text = s.EMAIL.ToString();
                }
                else
                {
                    ID.Clear();
                    Cin.Clear();
                    fullName.Clear();
                    email.Clear();
                }
            }

            // Manage buttons
            if (ID.Text != "")
            {
                PayBtn.Enabled = price.Text != "";
                printBtn.Enabled = true;
                showBtn.Enabled = true;
            }
            else
            {
                PayBtn.Enabled = false;
                printBtn.Enabled = false;
                showBtn.Enabled = false;
            }
        }

        //
        // Buy new month
        //
        private void PayBtn_Click(object sender, EventArgs e)
        {
            // Input
            int monthT = Convert.ToInt32(month.SelectedValue);
            int priceT = Convert.ToInt32(price.Text);
            int yearT = Convert.ToInt32(year.SelectedValue);
            int id = Convert.ToInt32(ID.Text);

            // Student
            STUDENT student = db.STUDENTS.Find(id);

            // Reduction
            int reduction = Convert.ToInt32(student.REDUCTION);

            // Formation id
            int formationId = student.FORMATION_ID;

            // Formation
            FORMATION formation = db.FORMATIONS.Find(formationId);

            // formation price
            int formationPrice = Convert.ToInt32(formation.PRICE) - reduction;

            // Total payed
            int payed = Convert.ToInt32(db.PAYMENTs.Where(p => p.STUDENT_ID == id && p.YEAR == yearT).Sum(s => s.PRICE));

            // Total still
            int still = formationPrice - payed;

            // Model payment
            PAYMENT payment = new PAYMENT()
            {
                STUDENT_ID = student.ID,
                MONTH = monthT,
                PRICE = priceT,
                YEAR = yearT,
                CREATED_AT = DateTime.Now,
                PAYED = payed + priceT,
                STILL = formationPrice - (payed + priceT)
            };

            // Check if still anything to pay

            if (priceT <= still && still > 0)
            {
                // Check if selected month payed or no
                bool isPayed = db.PAYMENTs.Where(p => p.STUDENT_ID == id && p.MONTH == monthT && p.YEAR == yearT).Count() > 0;
                if (isPayed)
                {
                    MessageBox.Show($"Le mois { month.Text } est deja payer", "ESPEGIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.PAYMENTs.Add(payment);
                    db.SaveChanges();

                    // Create history
                    help.CreateHistory($"PAYER LE MOIS { month.Text.ToUpper() } POUR", student.F_NAME, student.L_NAME, student.CIN);
                    MessageBox.Show($"le mois { month.Text } payer avec success", "ESPEGIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Montant inccorect il reste { formationPrice - payed } DH a payer", "ESPEGIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //
        // Show tickit
        //
        private void showBtn_Click(object sender, EventArgs e)
        {
            int sy = Convert.ToInt32(year2.SelectedValue);
            int sm = Convert.ToInt32(month2.SelectedValue);
            int id = Convert.ToInt32(ID.Text);
            // Student
            STUDENT student = db.STUDENTS.Find(id);
            List<PAYMENT> payment = db.PAYMENTs.Where(p => p.STUDENT_ID == id && p.YEAR == sy && p.MONTH == sm).ToList();
            if (payment.Count() > 0)
            {
                var p = payment.First();
                yearShow.Text = year2.Text;
                MonthShow.Text = month2.Text;
                PriceShow.Text = p.PRICE + " DH";
                PayedAtShow.Text = string.Format("{0:MM.dd.yyyy HH:mm}", p.CREATED_AT);
                PayedShow.Text = p.PAYED.ToString();
                StillShow.Text = p.STILL.ToString();

                fullName2.Text = student.F_NAME + " " + student.L_NAME;
                Pages.PageName = "tabPage2";
            }
            else
            {
                MessageBox.Show($"Le mois { month2.Text } n'a pas encore payer", "ESPEGIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //
        // Return to home page
        //
        private void returnBtn_Click(object sender, EventArgs e)
        {
            Pages.PageName = "tabPage1";
        }

        //
        // Change statue of button
        //
        private void price_KeyUp(object sender, KeyEventArgs e)
        {
            PayBtn.Enabled = price.Text != "" && ID.Text != "" && price.Text.All(char.IsDigit);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;

            Dictionary<string, string> header = new Dictionary<string, string>();
            Dictionary<string, string> body = new Dictionary<string, string>();
            Dictionary<string, string> footer = new Dictionary<string, string>();
            Font font = new Font("Arial", 15 /*FontStyle.Bold*/);

            int marginY = 30;
            int marginX = 80;
            int spacing = 30;
            int top = marginY + 80;

            // Header
            header.Add("Khemisset", "0537558448");
            header.Add("Tiflet", "0537515542");
            header.Add("Roumani", "0537517920");
            header.Add("Email", "espegic@gmail.com");
            header.Add("Site", "www.espegic.ma");
            header.Add("Khemisset le", "30/06/2021");
            // Body
            body.Add("Reçu de M", "test");
            body.Add("Inscrit(e) sous N°", "test");
            body.Add("Classe", "test");
            body.Add("La somme de", "test");
            body.Add("Reste a payer", "test");
            // Footer
            footer.Add("Cachet et signature", "Khemisset le : 30/06/2021");
            footer.Add("N.B : Aucun remboursement ne sera accordé apres délivrance du recu", "");

            // Logo
            e.Graphics.DrawImage(Properties.Resources.espegic, marginX, marginY, 140, 60);

            // Header
            for (int i = 0; i < header.Count(); i++)
            {
  
                if (i < 3)
                {
                    marginY = i == 0 ? top : top + (i * spacing);

                    e.Graphics.DrawString(header.ElementAt(i).Key, font, Brushes.Black, marginX, marginY);
                    e.Graphics.DrawString(": " + header.ElementAt(i).Value, font, Brushes.Black, marginX + 120, marginY);
                }
                else if (i >= 3)
                {
                    marginY = i == 0 ? top : top + ((i-3) * spacing);
                    e.Graphics.DrawString(header.ElementAt(i).Key, font, Brushes.Black, marginX + 300, marginY);
                    e.Graphics.DrawString(": " + header.ElementAt(i).Value, font, Brushes.Black, marginX + 450, marginY);
                }

            }

            // body
            for (int i = 0; i < body.Count(); i++)
            {
                marginY = i == 0 ? top + 108 : top + 108 + (i * spacing);

                e.Graphics.DrawString(body.ElementAt(i).Key, font, Brushes.Black, marginX, marginY);
                e.Graphics.DrawString(": " + body.ElementAt(i).Value, font, Brushes.Black, marginX + 170, marginY);
            }

            // Footer
            for (int i = 0; i < footer.Count(); i++)
            {
                marginY = i == 0 ? top + 260 : top + 260 + (i * spacing);
                int x = marginX;
                if (i == 0)
                {
                    marginX = x + 100;
                }
                else
                {
                    marginX = 80;
                    marginY = top + 350;

                }

                e.Graphics.DrawString(footer.ElementAt(i).Key, font, Brushes.Black, marginX, marginY);
                e.Graphics.DrawString(footer.ElementAt(i).Value, font, Brushes.Black, marginX + 300, marginY);
            }

        }
    }
}