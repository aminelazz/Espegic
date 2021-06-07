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
        readonly Espegic db = new Espegic();

        private void UserProfile_Load(object sender, EventArgs e)
        {
            USER user = db.USERS.Find(help.Connected);

            FullName.Text   = user.F_NAME + " " + user.L_NAME;
            CINShow.Text    = user.CIN;
            EmailShow.Text  = user.EMAIL;
            PhoneShow.Text  = user.PHONE;
        }
    }
}
