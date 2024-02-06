using january_2024;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    private static void Main(string[] args)//method
    {
      List<Student> studentlist = new List<Student>();
        studentlist.Add(new Student() { Id = 001, Name = "Ben", Age = 10,Gender = Gender.Male, Class = "Jss1"});
        studentlist.Add(new Student() { Id = 002, Name = "Grace", Age = 48,Gender = Gender.Female, Class = "Jss2" });
        studentlist.Add(new Student() { Id = 003, Name = "Todd", Age = 78, Gender =  Gender.Female, Class = "Jss3" });
        studentlist.Add(new Student() { Id = 004, Name = "Mart", Age = 40,Gender = Gender.Male, Class = "Jss1" });
        studentlist.Add(new Student() { Id = 005, Name = "Precious", Age = 12,Gender = Gender.Male, Class = "Jss2" });
        studentlist.Add(new Student() { Id = 006, Name = "Victor", Age = 15,Gender = Gender.Female, Class = "Jss3" });
        studentlist.Add(new Student() { Id = 007, Name = "Ifenna", Age = 17,Gender = Gender.Male, Class = "Jss1" });
        studentlist.Add(new Student() { Id = 008, Name = "Chika", Age = 18,Gender = Gender.Female, Class = "Jss2" });
        studentlist.Add(new Student() { Id = 009, Name = "Ude", Age = 19,Gender = Gender.Male, Class = "Jss3" });
        studentlist.Add(new Student() { Id = 010, Name = "Mary", Age = 45,Gender = Gender.Female, Class = "Jss1" });
        studentlist.Add(new Student() { Id = 011, Name = "chibuzor", Age = 50, Gender = Gender.Female, Class = "Jss 3" });

        var result = studentlist.Select(em  => em.Name).ToList();
        foreach (var student in result)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("SPACE........");

        var data = studentlist.Sum(x => x.Age * x.Id);//Lambda experssion
        Console.WriteLine(data);

        // LambdaMethod();

    }
   
    public static void LambdaMethod()
    {

        List<int> numericalValues = new List<int>() { 34, 5, 6, 89, 90, 75, 7, 8, 9, 0, 8, 12, 14, 24};
        var evenNumber = numericalValues.FindAll(x => (x%2)==0);

        foreach (var x in evenNumber)
        {
            Console.WriteLine(x);
        }
        Console.Read();
    }





}