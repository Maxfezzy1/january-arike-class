using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace january_2024
{
   public enum DaysofTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Gender
    {
        Male,
        Female,
        Unknown,
        Others

    }

    public class Student : Circle // base class while the student class is called derived class
    {
        public Gender Gender {  get; set; }


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
            Console.WriteLine(Gender.Male);
            Console.WriteLine("his name is ude from math class");
        }
    }
}
