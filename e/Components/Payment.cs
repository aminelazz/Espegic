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
            var sy = Convert.ToInt32(year2.SelectedValue);
            var sm = Convert.ToInt32(month2.SelectedValue);
            List<PAYMENT> payment = db.PAYMENTs.Where(p => p.YEAR == sy && p.MONTH == sm).ToList();
            if (payment.Count() > 0)
            {
                var p = payment.First();
                yearShow.Text = year2.Text;
                MonthShow.Text = month2.Text;
                PriceShow.Text = p.PRICE + " DH";
                PayedAtShow.Text = string.Format("{0:MM.dd.yyyy HH:mm}", p.CREATED_AT);
                PayedShow.Text = p.PAYED.ToString();
                StillShow.Text = p.STILL.ToString();
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
            PayBtn.Enabled = price.Text != "" && ID.Text != "";
        }
    }
}
