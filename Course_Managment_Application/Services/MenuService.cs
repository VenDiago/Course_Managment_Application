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
            //Console.WriteLine("Please choose value case1(1)");
            //int isonline;
            //string isonStr = Console.ReadLine();
            //bool resultIson = int.TryParse(isonStr, out isonline);

            //Console.WriteLine("Please choos value case1(2)");
            //int isoffline;
            //string isoffStr = Console.ReadLine();
            //bool resultIsoff = int.TryParse(isoffStr, out isoffline);


           
            //bool iSon = false;
            //bool iSoff = false;
            //string strOn;
            //string strOff ;
            //bool resultIson = int.TryParse(strOn, out isonline);
            //bool resultIsoff = int.TryParse(strOff, out isoffline);
            


            Console.WriteLine("Please choose a Situation:");
                foreach (Situation s in System.Enum.GetValues(typeof(Situation)))
                {
                    Console.WriteLine($"{(int)s}. {s}");
                }
                int isonline;
                int isoffline;
                int situation;
                string sitStr = Console.ReadLine();
                bool resulSitOn = int.TryParse(sitStr, out isonline);
                bool resulSitOff = int.TryParse(sitStr, out isoffline);
                bool resultSit = int.TryParse(sitStr, out situation);
                if (resultSit && resulSitOn && resulSitOff )
                {
                    switch (situation)
                    {
                        case (int)Situation.Online:
                            string Nom = courseService.CreateSituation(isonline, isoffline, Situation.Online);
                            Console.WriteLine($"{Nom} Online group is succesfully created");
                            break;
                        case (int)Situation.Offline:
                            Nom = courseService.CreateSituation(isonline, isoffline, Situation.Offline);
                            Console.WriteLine($"Offline group is succesfully created");
                            break;
                        default:
                            Console.WriteLine("Please choose valid number");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please choose valid situation");
                }
            if (resultSit && resulSitOn && resulSitOff)
            {
                Console.WriteLine("Please choose a Category:");
                foreach (Categories c in System.Enum.GetValues(typeof(Categories)))
                {
                    Console.WriteLine($"{(int)c}. {c}");
                }
                int category;
                string catStr = Console.ReadLine();
                bool resultCat = int.TryParse(catStr, out category);
                if (resultCat)
                {
                    switch (category)
                    {
                        case (int)Categories.Programming:
                            string No = courseService.CreateGroup( Categories.Programming);
                            Console.WriteLine($"{No}  group succesfully created");
                            break;
                        case (int)Categories.Desing:
                            No = courseService.CreateGroup(Categories.Desing);
                            Console.WriteLine($"{No} group succesfully created");
                            break;
                        case (int)Categories.System_Adminstration:
                            No = courseService.CreateGroup( Categories.System_Adminstration);
                            Console.WriteLine($"{No} group succesfully created");
                            break;
                        default:
                            Console.WriteLine("Please choose valid number");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please choose valid category");
                }

            }
            else
            {
                Console.WriteLine("Please choose correct value case1(3) else serti");
            }
        }

        public static void GetAllGroupsMenu()
        {
            courseService.GetAllGroups();
        }




        //        {
        //            Console.WriteLine("Please choose (1)Online or (2)Offline");
        //            int total = 0;
        //            bool online = false;
        //            bool offline = false;
        //            string ofStr=Console.ReadLine();
        //            bool bRet = int.TryParse(ofStr, out total);
        //            int limit;
        //            if (total == '1')
        //            {
        //                online = true;
        //                Console.WriteLine(online);

        //            }
        //            else if (total == '2')
        //            {
        //                offline = true;
        //                Console.WriteLine(offline);
        //            }
        //            if (bRet)
        //            {
        //                Console.WriteLine("Please choose category");
        //                foreach (Categories c in System.Enum.GetValues(typeof(Categories)))
        //                {
        //                    Console.WriteLine($"{(int)c}. {c}");
        //                }
        //                int category;
        //                string catStr = Console.ReadLine();
        //                bool resultCat = int.TryParse(catStr, out category);
        //                if (resultCat)
        //                {
        //                    switch (category)
        //                    {
        //                        case (int)Categories.Programming:
        //                            //string No = CourseService.CreateGroup(Categories.Programming);
        //                            //Console.WriteLine($"{No} group succesfully created");
        //                            break;
        //                        //case (int)Categories.Thriller:
        //                        //    No = cinemaServices.CreateHall(row, col, Categories.Thriller);
        //                        //    Console.WriteLine($"{No} hall succesfully created");
        //                        //    break;
        //                        //case (int)Categories.Drama:
        //                        //    No = cinemaServices.CreateHall(row, col, Categories.Drama);
        //                        //    Console.WriteLine($"{No} hall succesfully created");
        //                        //    break;
        //                        //default:
        //                        //    Console.WriteLine("Please choose valid number");
        //                        //    break;
        //                    }
        //                }
        //            }
        //        }
    }
}
