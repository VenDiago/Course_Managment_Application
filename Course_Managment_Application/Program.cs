using System;

namespace Course_Managment_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Course Managment Application\n");
            int selection=0;
            do
            {
                Console.WriteLine("1. Create Group");
                Console.WriteLine("2. Get All Groups");
                Console.WriteLine("3. Edit Group");
                Console.WriteLine("4. Get All Group Students");
                Console.WriteLine("5. Get All Students");
                Console.WriteLine("6. Create Student");
                Console.WriteLine("0. Exit");
                string strSelection=Console.ReadLine();
                bool bRet = int.TryParse(strSelection, out selection);

                if (bRet)
                {
                    
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("Please choose  value");
                            break;
                        default:
                            break;
                    }
                }
            } while (selection!=0);
            







        }
    }
}
