using Course_Managment_Application.Enum;
using Course_Managment_Application.Interfaces;
using Course_Managment_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Type = Course_Managment_Application.Enum.Type;

namespace Course_Managment_Application.Services
{
    class CourseService : ICourseManagmentService
    {
        private List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        private List<Student> _students = new List<Student>();
        public List<Student> Students => _students;

        public string CreateGroup(Situation situation, Categories category)
        {
            Group group = new Group(situation, category);
            _groups.Add(group);
            return group.No;
        }

        public string CreateStudent(string fullname, string groupno, Type type)
        {
            Student student = new Student(fullname, groupno, type);
            if (groupno != null)
            {
               Group _group=FindGroup(groupno);
                if (_group != null)
                {
                    Students.Add(student);
                    Console.WriteLine("Student Created.");
                }
                else
                {
                    Console.WriteLine("Group not existed");
                    return "";
                }
            }
            return student.GroupNo;
            
        }

        public void GetAllGroups()
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("There is no group in Course.");
                return;
            }
            foreach (Group group in _groups)
            {
                Console.WriteLine(group);
            }
        }

        public void GetAllGroupStudents(string no)
        {
            Group group = FindGroup(no);
            if (group == null)
            {
                Console.WriteLine("Please choose valid group no:");
                return;
            }
            else if (Students.Count == 0)
            {
                Console.WriteLine("Empty group");
            }
            else
            {
                foreach (Student student in Students)
                {
                    Console.WriteLine(student);
                }
            }

            
        }

        public void GetAllStudents()
        {
            if (_students.Count == 0)
            {
                Console.WriteLine("There is no student in Course");
                return;
            }
            foreach (Student student in _students)
            {
                Console.WriteLine(student);
            }
        }

        public void GroupEdit(string no, string newNo)
        {
            Group existedGroup = FindGroup(no);
            if (existedGroup == null)
            {
                Console.WriteLine("Please choose correct Group no:");
                return;
            }
            foreach (Group group in _groups)
            {
                if (group.No.ToLower().Trim() == newNo.ToLower().Trim())
                {
                    Console.WriteLine($"{newNo} group already exist.");
                    return;
                }
            }
            existedGroup.No = newNo.ToUpper();
            Console.WriteLine($"{no} group succesfully change to {newNo}");
        }


        public Group FindGroup(string no)
        {
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }
    }
}



