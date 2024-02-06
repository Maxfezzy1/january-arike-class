using january_2024;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    private static void Main(string[] args)//method
    {
        IList<Student> studentlist = new List<Student>();
        {
            new Student() { Id = 1, Name = "Ifenna", Age = 23 };
            new Student() { Id = 2, Name = "Ude", Age = 18 };
            new Student() { Id = 3, Name = "Ben", Age = 15 };
            new Student() { Id = 4, Name = "Kelvin", Age = 12 };
            new Student() { Id = 5, Name = "Mary", Age = 20 };

            

        }

        var students = from s in studentlist
                      select new Student() { Id = s.Id, Name = s.Name, Age = s.Age };

        foreach (var student in students ) 
        {
            Console.WriteLine(student.Id + " " + student.Name + " " + student.Age);
        }
       
     

    }


}