using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Student
    {
        private int Id { get; set; }
     
        private  string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        private string Gender { get; set; }
        private Char Grade { get; set; }
        public Student(int Id,string FirstName,string LastName,int Age, string Gender, Char Grade)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Gender = Gender;
            this.Grade = Grade;
        }
    }
}
