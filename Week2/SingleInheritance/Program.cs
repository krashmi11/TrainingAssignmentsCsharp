using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    class Person
    {
        string name;
        int age;

        internal Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void personInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
        }
    }
    class Student : Person
    {
        string grade;
        internal Student(string name,int age, string grade) : base(name, age)
        {
            this.grade = grade;
        }

        public void StudentInfo()
        {
            personInfo();
            Console.WriteLine("Grade Received:"+grade);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Rashmi", 21, "Excellent");
            student.StudentInfo();
            
            student = new Student("Sabby", 22, "Very Good");
            student.StudentInfo();
        }
    }
}
