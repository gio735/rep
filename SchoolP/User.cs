using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    public class User
    {
        public int Id;
        public string Username;
        public string Name;
        public string Lastname;
        public string Password;
        public string Status;
        public string Course;
        public List<Grade> Grades = new List<Grade>();
        
    }
    public class Grade
    {
        public int UserId;
        public string Course;
        public int Mark;

        public Grade(int id, string course, int mark)
        {
            UserId = id;
            Course = course;
            Mark = mark;
        }
    }
}