using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace e
{
    static class Program
    {
        //public static int CONID = 1;
        public static Espegic db = new Espegic();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool connected = db.HELPERS.Where(c => c.KEY == "CONNECTED" && c.VALUE != "0").Count() > 0;
            if (connected)
            {
                Application.Run(new Main());
            }
            else
            {
                Application.Run(new Login());
            }
        }

    }
}
