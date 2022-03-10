using Course_Managment_Application.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Application.Models
{
    class Group
    {
        public static int count = 1;
        public string No;
        public string Nom;
        public int Limit;
        public Categories Category;
        public Student[,] Students;
        public Group(Situation situation, Categories category)
        {
            switch (category)
            {
                case Categories.Programming:
                    No = $"P-{count}";
                    break;
                case Categories.Desing:
                    No = $"D-{count}";
                    break;
                case Categories.System_Adminstration:
                    No = $"SA-{count}";
                    break;
                default:
                    break;
            }

            Category = category;
            count++;
            switch (situation)
            {
                case Situation.Online:
                    Nom = $"On";
                    break;
                case Situation.Offline:
                    Nom = $"Off";
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {
            return $"No: {No}, Situation:{Nom}, Category: {Category}";
        }
    }
}


