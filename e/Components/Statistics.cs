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
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
        }

        //
        // Properties
        //
        readonly Espegic db = new Espegic();

        //
        // Load
        //
        private void Statistics_Load(object sender, EventArgs e)
        {
            // Count of each table
            nbr_user.Text       = db.USERS.Count().ToString();
            nbr_prof.Text       = db.PROFESSORS.Count().ToString();
            nbr_student.Text    = db.STUDENTS.Count().ToString();
            nbr_formation.Text  = db.FORMATIONS.Count().ToString();
            nbr_module.Text     = db.MODULES.Count().ToString();

            // Date
            date.Text = "Date : " + DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
