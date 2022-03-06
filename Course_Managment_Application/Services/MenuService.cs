//using Course_Managment_Application.Enum;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Course_Managment_Application.Services
//{
//    static class MenuService
//    {
//        public static CourseService courseService=new CourseService();

//        public static void CreateGroupMenu()
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
//    }
//}
