using Course_Managment_Application.Enum;
using Course_Managment_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Application.Interfaces
{
     interface ICourseManagmentService
    {
        public List<Group> Groups { get; }
        public string CreateGroup(Categories category);
        public string CreateSituation(int isonline, int isoffline, Situation situation);
        public void GetAllGroups();
        public void GroupEdit(string no, string newNo);
        public void GetAllGroupStudents();
        public void GetAllStudents(string no);
        public string CreateStudent(string fullname, string groupno);
        

    }
}
