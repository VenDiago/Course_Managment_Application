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
        public bool IsOnline;
        public int Limit;
        public  Student[,] Students;

        public Group(int fullname,int groupno, Categories category)   
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
            
            Students = new Student[fullname, groupno];


        }

       
    }
}
