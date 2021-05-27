using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e.Components
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        //
        // Properties
        //
        readonly Espegic db          = new Espegic();
        protected   int     pageCount   = 0;

        //
        // Load
        //
        private void Home_Load(object sender, EventArgs e)
        {
            View.DataSource  = (from h in db.HISTORIES
                                join u in db.USERS on h.BY equals u.ID
                                orderby h.CREATED_AT descending
                                select new { h.ACTION, h.CREATED_AT }).Take(11).ToList();
        }

        //
        // Paginate
        //
        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                if ((db.HISTORIES.Count() - pageCount) > 11)
                {
                    pageCount += 11;
                    View.DataSource = (from h in db.HISTORIES
                                       join u in db.USERS on h.BY equals u.ID
                                       orderby h.CREATED_AT descending
                                       select new { h.ACTION, h.CREATED_AT }).Skip(pageCount).Take(11).ToList();
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
                    pageCount -= 11;
                    View.DataSource = (from h in db.HISTORIES
                                       join u in db.USERS on h.BY equals u.ID
                                       orderby h.CREATED_AT descending
                                       select new { h.ACTION, h.CREATED_AT }).Skip(pageCount).Take(11).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
