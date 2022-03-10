using Course_Managment_Application.Enum;
using Course_Managment_Application.Models;
using Type = Course_Managment_Application.Enum.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Application.Services
{
    static class MenuService
    {
        public static CourseService courseService = new CourseService();

        public static void CreateGroupMenu()
        {
            int situation;
            int Limit;
            Console.WriteLine("Are you Online Group? yes/no");
            string str = Console.ReadLine();
            bool isOnline = false;



            Console.WriteLine("Please choose a Category:");
            foreach (Categories c in System.Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)c}. {c}");
            }


            string sitStr = Console.ReadLine();
            bool resultSit = int.TryParse(sitStr, out situation);


            if (str.ToLower().Trim() == "yes")
            {
                isOnline = true;
                Limit = 15;

                switch (situation)
                {
                    case (int)Categories.Programming:

                        string No = courseService.CreateGroup(Situation.Online, Categories.Programming);
                        Console.WriteLine($"{No} Online group is succesfully created\n");
                        break;
                    case (int)Categories.Desing:
                        No = courseService.CreateGroup(Situation.Online, Categories.Desing);
                        Console.WriteLine($"{No} Online group is succesfully created\n");
                        break;
                    case (int)Categories.System_Adminstration:
                        No = courseService.CreateGroup(Situation.Online, Categories.System_Adminstration);
                        Console.WriteLine($"{No} Online group is succesfully created\n");

                        break;
                    default:
                        Console.WriteLine("Please choose valid number");
                        break;
                }

            }
            else if (str.ToLower().Trim() == "no")
            {
                Limit = 10;


                switch (situation)
                {
                    case (int)Categories.Programming:

                        string No = courseService.CreateGroup(Situation.Offline, Categories.Programming);
                        Console.WriteLine($"{No} Offline group is succesfully created\n");
                        break;
                    case (int)Categories.Desing:
                        No = courseService.CreateGroup(Situation.Offline, Categories.Desing);
                        Console.WriteLine($"{No} Offline group is succesfully created\n");
                        break;
                    case (int)Categories.System_Adminstration:
                        No = courseService.CreateGroup(Situation.Offline, Categories.System_Adminstration);
                        Console.WriteLine($"{No} Offline group is succesfully created\n");

                        break;
                    default:
                        Console.WriteLine("Please choose valid number");
                        break;
                }
            }
        }

        public static void GroupEditMenu()
        {
            Console.WriteLine("Please choose group no");
            string no = Console.ReadLine();
            Console.WriteLine("Please choose new group no");
            string newNo = Console.ReadLine();
            courseService.GroupEdit(no, newNo);
        }

        public static void GetAllGroupStudentsMenu()
        {
            Console.WriteLine("Please choose group no");
            string no = Console.ReadLine();
            courseService.GetAllGroupStudents(no);
        }

        public static void GetAllGroupsMenu()
        {
            courseService.GetAllGroups();
        }

        public static void GetAllStudentsMenu()
        {
            courseService.GetAllStudents();
        }

        public static void CreateStudentMenu()
        {
            Console.WriteLine("Please enter Name:");
            string fullname = Console.ReadLine();
            Console.WriteLine("Please enter GroupNo:");
            string groupno = Console.ReadLine();


            bool type0 = false;

            Console.WriteLine("Are you Zemanetli Student? yes/no");
            string str = Console.ReadLine();
            if (fullname.Length > 6 && str.ToLower().Trim() == "yes")
            {
                type0 = true;
                string Tp = courseService.CreateStudent(fullname, groupno, Type.Zemanetli);
                Console.WriteLine($"{Tp} Successfully created ");

            }
            else if (str.ToLower().Trim() == "no")
            {
                type0 = false;
                string Tp = courseService.CreateStudent(fullname, groupno, Type.Zemanetsiz);
                Console.WriteLine($"{Tp} Successfully created ");
            }
        }

    }
}

