using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace e
{
    public class Helpers
    {
        readonly Espegic db = new Espegic();

        //
        // Connected user
        //
        public int Connected
        {
            get { return Convert.ToInt32(db.HELPERS.Where(u => u.KEY == "CONNECTED").First().VALUE); }
        }

        //
        // Create history
        //
        public void CreateHistory(string action, string fname, string lname, string cin)
        {
            HISTORy history = new HISTORy
            {
                ACTION = $"{ db.USERS.Find(Connected).F_NAME } { db.USERS.Find(Connected).L_NAME } { action } ({ fname } { lname } - { cin })",
                BY = Connected,
                CREATED_AT = DateTime.Now
            };
            db.HISTORIES.Add(history);
            db.SaveChanges();
        }

        //
        // User permission
        //
        public bool Permitted(string pCase)
        {
            switch (pCase)
            {
                // User
                case "READ USER":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "READ" && p.USERS == true).Count() > 0;
                case "WRITE USER":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "WRITE" && p.USERS == true).Count() > 0;
                case "UPDATE USER":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "UPDATE" && p.USERS == true).Count() > 0;
                case "DELETE USER":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "DELETE" && p.USERS == true).Count() > 0;

                // Professor
                case "READ PROFESSOR":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "READ" && p.PROFESSORS == true).Count() > 0;
                case "WRITE PROFESSOR":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "WRITE" && p.PROFESSORS == true).Count() > 0;
                case "UPDATE PROFESSOR":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "UPDATE" && p.PROFESSORS == true).Count() > 0;
                case "DELETE PROFESSOR":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "DELETE" && p.PROFESSORS == true).Count() > 0;

                // Formation
                case "READ FORMATION":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "READ" && p.FORMATIONS == true).Count() > 0;
                case "WRITE FORMATION":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "WRITE" && p.FORMATIONS == true).Count() > 0;
                case "UPDATE FORMATION":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "UPDATE" && p.FORMATIONS == true).Count() > 0;
                case "DELETE FORMATION":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "DELETE" && p.FORMATIONS == true).Count() > 0;

                // Module
                case "READ MODULE":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "READ" && p.MODULES == true).Count() > 0;
                case "WRITE MODULE":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "WRITE" && p.MODULES == true).Count() > 0;
                case "UPDATE MODULE":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "UPDATE" && p.MODULES == true).Count() > 0;
                case "DELETE MODULE":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "DELETE" && p.MODULES == true).Count() > 0;

                // Student
                case "READ STUDENT":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "READ" && p.STUDENTS == true).Count() > 0;
                case "WRITE STUDENT":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "WRITE" && p.STUDENTS == true).Count() > 0;
                case "UPDATE STUDENT":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "UPDATE" && p.STUDENTS == true).Count() > 0;
                case "DELETE STUDENT":
                    return db.PERMISSIONS.Where(p => p.USER_ID == Connected && p.ACTION == "DELETE" && p.STUDENTS == true).Count() > 0;

                default:
                    return false;
            }
        }
    }
}
