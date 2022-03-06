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
        public Categories Category;
        public int IsOnline;
        public int IsOffline;
        public int Limit;
        //public  Student[,] Students;
        public Group[,] Groups;
        public Group(int isonline , int isoffline, Categories category)   
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

            Groups = new Group[isonline, isoffline];

            for (int i = 0; i < isonline; i++)
            {
                for (int j = 0; j < isoffline; j++)
                {
                    Group group = new Group(isonline + 1, isoffline + 1,category);
                    Groups[i, j] = group;




                }
            }
            count++;

            
            


            


        }

       
    }
}
