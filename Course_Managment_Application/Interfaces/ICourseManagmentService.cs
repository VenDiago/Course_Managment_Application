using Course_Managment_Application.Enum;
using Course_Managment_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Type = Course_Managment_Application.Enum.Type;

namespace Course_Managment_Application.Interfaces
{
    interface ICourseManagmentService
    {
        public List<Group> Groups { get; }
        public string CreateGroup(Situation situation, Categories category);
        public void GetAllGroups();
        public void GroupEdit(string no, string newNo);
        public void GetAllGroupStudents(string no);
        public void GetAllStudents();
        public string CreateStudent(string fullname, string groupno, Type type);
    }
}
