using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Application.Enum
{
     class Student
    {
        public string Fullname;
        public string GroupNo;
        public bool Type;

        public Student(string fullname,string groupno,bool type)
        {
            Fullname = fullname;
            GroupNo = groupno;
            Type = type;

           
        }
    }
}
