using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace january_2024
{
    public delegate bool Ispromotable(Student student);//delegate

    public  enum Gender
    {
        Male,
        Female,
        Unknown
    }
  
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class {  get; set; }
        public Gender Gender { get; set; }

        public static void PromoteStudent(List<Student> students, Ispromotable isactive)
        {
            foreach (var student in students)
            {
                if (isactive(student))
                {
                    Console.WriteLine(student.Name + " " + "Promoted");
                }
            }
        }
    }

   
}
