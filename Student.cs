using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class Student : Human
    {
        public string Grade { get; set; }

        public Student(string name, string surname, int age, string grade) : base(name, surname, age) 
        {
            Grade = grade;
        }
    }

}
