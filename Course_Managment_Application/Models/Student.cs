using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Application.Enum
{
    class Student
    {
        public int count = 1;
        public string Tp;
        public string Fullname;
        public string GroupNo;
        public Type type;
        public Student(string fullname, string groupno, Type type)
        {
            Fullname = fullname;
            GroupNo = groupno;

            switch (type)
            {
                case Type.Zemanetli:
                    Tp = $"Zemanetli";
                    break;
                case Type.Zemanetsiz:
                    Tp = $"Zemanetsiz";
                    break;
                default:
                    break;
            }

        }
        public override string ToString()
        {
            
            return $"Fullname:{Fullname},Groupno:{GroupNo},Type {Tp}";
        }
    }

}
