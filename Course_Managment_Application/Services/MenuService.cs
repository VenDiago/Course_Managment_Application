using Course_Managment_Application.Enum;
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

            Console.WriteLine("Please choose a Situation:");
            foreach (Situation s in System.Enum.GetValues(typeof(Situation)))
            {
                Console.WriteLine($"{(int)s}. {s}");
            }
            int situation;
            string sitStr = Console.ReadLine();
            
            bool resultSit = int.TryParse(sitStr, out situation);
            switch (situation)
            {
                case  (int)Situation.Online:
                    
                    string Nom = courseService.CreateSituation( Situation.Online);
                    Console.WriteLine($"{Nom} Online group is succesfully created\n");
                    break;
                case (int)Situation.Offline:
                    Nom = courseService.CreateSituation( Situation.Offline);
                    Console.WriteLine($"{Nom} Offline group is succesfully created\n");
                    break;
                default:
                    Console.WriteLine("Please choose valid number");
                    break;
            }
            
            Console.WriteLine("Please choose a Category:");
            foreach (Categories c in System.Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)c}. {c}");
            }
            int category;
            string catStr = Console.ReadLine();
            bool resultCat = int.TryParse(catStr, out category);
            switch (category)
            {
                case (int)Categories.Programming:
                    
                    
                    string No = courseService.CreateGroup(Categories.Programming);
                    Console.WriteLine($"{No}  group succesfully created");
                    break;
                case (int)Categories.Desing:
                    No = courseService.CreateGroup(Categories.Desing);
                    Console.WriteLine($"{No} group succesfully created");
                    break;
                case (int)Categories.System_Adminstration:
                    No = courseService.CreateGroup(Categories.System_Adminstration);
                    Console.WriteLine($"{No} group succesfully created");
                    break;
                default:
                    Console.WriteLine("Please choose valid number");
                    break;
            }
            
           
        }
        public static void GetAllGroupsMenu()
        {
            courseService.GetAllGroups();
        }
    }
}
