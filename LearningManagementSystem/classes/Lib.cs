using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.classes
{
    internal class Lib
    {
        public static string GetAge(DateTime DateOfBirth)
        {

            int days = (DateTime.Now - DateOfBirth).Days;

            int year = (int)(days / 365.25);
            days -= (int)(year * 365.25);

            int month = (int)(days / 30.436875);
            days -= (int)(month * 30.436875);


            string age = year + " years " + month + " month" + ((month == 1) ? " " : "s ");
            age += "and " + days + " day" + ((days == 1) ? "" : "s");

            return age;

        }
        public static string GetGender(string cnic)
        {
            if (cnic.Length != 13)
            {
                return "unknown";
            }

            char ch = cnic[12];
            if (ch < '0' || ch > '9')
            {
                return "unknown";
            }

            if ((int)ch % 2 != 0)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }

    }
}
