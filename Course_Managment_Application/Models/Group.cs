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
        public Categories Category;
        public Situation Situation;
        public int IsOnline;
        public int IsOffline;


        //public int Limit;
        public Student[,] Students;
        public Group[,] Groups;
        public Group(Categories category)
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
        }
        public Group(int isonline, int isoffline, Situation situation)
        {
            switch (situation)
            {
                case Situation.Online:
                    Nom = $"On-{count}";
                    break;
                case Situation.Offline:
                    Nom = $"Off-{count}";
                    break;
                default:
                    break;
            }
            Situation = situation;
            //count++;
        }
        public Group(int isonline, int isoffline)
        {
            Groups = new Group[isonline, isoffline];

            for (int i = 0; i < isonline; i++)
            {
                for (int j = 0; j < isoffline; j++)
                {
                    Group group = new Group(i + 1, j + 1);
                    Groups[i, j] = group;
                }
            }
        }

        public override string ToString()
        {
            return $"No: {No}, Category: {Category}";
        }




    }
}

            
