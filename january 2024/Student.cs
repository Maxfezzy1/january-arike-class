using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace january_2024
{
    //access modifiers
    //types of access modifiers
    //public
    //private
    //internal
    //protected

    //nonstatic; a non-static class accomodates both a static and non static.
    public class Student : Circle // base class while the student class is called derived class
    {
        int Id;
        String Name;
        int Age;
        String Department;

        public Student(int id, string name, int age, string dept)
        {
            Id = id;
            Name = name;
            Age = age;
            Department = dept;

        }

        public void StudentDetails()
        {
            Console.WriteLine("his name is {0} from {1} Class,i'm {2}", Name, Department, Age);
        }

        public static void StudentInfo()
        {
            Console.WriteLine("his name is ude from math class");
        }
    }
}
