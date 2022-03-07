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
            Console.WriteLine("Please choose value case1(1)");
            int isonline;
            string isonStr = Console.ReadLine();
            bool resultIson = int.TryParse(isonStr, out isonline);

            Console.WriteLine("Please choos value case1(2)");
            int isoffline;
            string isoffStr = Console.ReadLine();
            bool resultIsoff = int.TryParse(isoffStr, out isoffline);



            //Console.WriteLine("Please choose (1)Online or (2)Offline");
            //int isonline;
            //int isoffline;
            //string str=Console.ReadLine();
            //bool iSon = false;
            //bool iSoff=false;
            ////if (str.ToLower().Trim() == "1")
            ////{
            ////    iSon = true;

            ////}
            ////bool resultIson = int.TryParse(str, out isonline)
            ////else if (str.ToLower().Trim() == "2")
            ////{
            ////    iSoff = true;
            ////    bool resultIsoff = int.TryParse(str, out isoffline);
            ////}
            ////Console.WriteLine("Please choose section:");
            ////string sectiom = Console.ReadLine();
            if (resultIson || resultIsoff)
            {
                Console.WriteLine("Please choose a Situation:");
                foreach (Situation c in System.Enum.GetValues(typeof(Situation)))
                {
                    Console.WriteLine($"{(int)c}. {c}");
                }
                int situation;
                string sitStr = Console.ReadLine();
                bool resultSit = int.TryParse(sitStr, out situation);
                if (resultSit)
                {
                    switch (situation)
                    {
                        case (int)Situation.Online:
                            string No = courseService.CreateGroup(isonline, isoffline, sectiom, Situation.Online);
                            Console.WriteLine($"{No} Online group is succesfully created");
                            break;
                        case (int)Situation.Offline:
                            No = courseService.CreateGroup(isonline, isoffline, sectiom, Situation.Offline);
                            Console.WriteLine($"{No} Offline group is succesfully created");
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

            }
            else
            {
                Console.WriteLine("Please choose correct value case1(3) else serti");
            }



























































            //    if (resultIsonn || resultIsoff)
            //    {
            //        Console.WriteLine("Please choose a Category:");
            //        foreach (Categories c in System.Enum.GetValues(typeof(Categories)))
            //        {
            //            Console.WriteLine($"{(int)c}. {c}");
            //        }
            //        int category;
            //        string catStr = Console.ReadLine();
            //        bool resultCat = int.TryParse(catStr, out category);
            //        if (resultCat)
            //        {
            //            switch (category)
            //            {
            //                case (int)Categories.Programming:
            //                     string No = courseService.CreateGroup(isonline, isoffline,sectiom, Categories.Programming);
            //                    Console.WriteLine($"{No} group succesfully created");
            //                    break;
            //                case (int)Categories.Desing:
            //                    No = courseService.CreateGroup(isonline, isoffline,sectiom, Categories.Desing);
            //                    Console.WriteLine($"{No} group succesfully created");
            //                    break;
            //                case (int)Categories.System_Adminstration:
            //                    No = courseService.CreateGroup(isonline, isoffline,sectiom, Categories.System_Adminstration);
            //                    Console.WriteLine($"{No} group succesfully created");
            //                    break;
            //                default:
            //                    Console.WriteLine("Please choose valid number");
            //                    break;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please choose valid category");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Please choose correct value case1(3) else serti");
            //    }
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
