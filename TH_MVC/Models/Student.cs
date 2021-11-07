using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TH_MVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public Student(int studentid, string studentname, int age)
        {
            this.StudentId = studentid;
            this.StudentName = studentname;
            this.Age = age;
        }
    }
}