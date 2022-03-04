using Course_Managment_Application.Enum;
using Course_Managment_Application.Interfaces;
using Course_Managment_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Application.Services
{
    class CourseService : ICourseManagmentService
    {
        List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        List<Student> _students = new List<Student>();
        public List<Student> Students => _students;

        public string CreateGroup(int fullname, int groupno, Categories category)
        {
            if (fullname <= 0 || groupno <= 0)
            {
                return "Please choose valid fullname or groupno";
            }

            Group group = new Group(fullname, groupno, category);
            _groups.Add(group);
            return group.No;
            //return fullname.ToString();
            //sehv kod /\
        }

        public string CreateStudent(int fullname, int groupno)
        {
            if (fullname <= 0 || groupno <= 0)
            {
                return "Please choose valid fullname or groupno";
            }

            Student student = new Student(fullname, groupno, type: false);
            _students.Add(student);
            return CreateStudent(fullname, groupno);
            //Yoxla bunu /\
        }

        public void GetAllGroups()
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("There is no group in Course");
                return;
            }
            foreach (Group group in _groups)
            {
                Console.WriteLine(group);
            }
        }

        public void GetAllGroupStudents()
        {

        }

        public void GetAllStudents(string no)
        {
            Group group = FindGroup(no);
            if (group == null)
            {
                Console.WriteLine("Please choose valid hall no");
                return;
            }
            foreach (Student student in group.Students)
            {
                Console.WriteLine(student);
            }
        }

        public void GroupEdit(string no, string newNo)
        {
            Group existedGroup = FindGroup(no);
            if (existedGroup != null)
            {
                Console.WriteLine("Please choose correct Group no");
                return;
            }
            foreach (Group group in _groups)
            {
                if (group.No.ToLower().Trim() == newNo.ToLower().Trim())
                {
                    Console.WriteLine($"{newNo} group already exist");
                    return;
                }
            }
            existedGroup.No = newNo.ToUpper();
        }


        public Group FindGroup(string no)
        {
            foreach (Group group in _groups)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }
        //public Group FindStudent(string no)
        //{
        //    foreach (Student student in Group)
        //    {
        //        if (Group.No.ToLower().Trim() == no.ToLower().Trim())
        //        {
        //            return Group;
        //        }
        //    }
        //    return null;
        //}
    }
}
         

