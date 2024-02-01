using january_2024;
using Microsoft.VisualBasic;
using System.Reflection.Emit;

internal class Program
{
    int v = 78; //this is called a field
    int age { get; set; } = 67;//properties ; used when u want to send something to your database

    private static void Main(string[] args)//method
    {
        User.UserInfo();
        User.Age = 88;

        Student.StudentInfo();
        

        //instatiation; used to call out the nonstatic in another class
        //the object known as stud can change into any name of your choice

        Student stud = new Student(101, "grace",22 , "chemistry");
        stud.StudentDetails();
        


    }
   
}