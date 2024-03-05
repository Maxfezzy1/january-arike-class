using january_2024;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    private static void Main(string[] args)
    {
        int[] numbs = new int[] { 2, 12, 5, 8, 10, 15, 21, 23, 34, 54, 67, 1 };
        //query syntax
        var res = from a in numbs where a > 3 orderby a select a;
        foreach (int i in res)
            Console.WriteLine(i);


        IList<CarModule> list = new List<CarModule>()
        {
            new CarModule() { CarId = 101, Model = 2001, Name = "SUV", Price = 10000000 },
            new CarModule() { CarId = 102, Model = 2002, Name = "Toyota", Price = 20000000 },
            new CarModule() { CarId = 103, Model = 2003, Name = "Camary", Price = 30000000 },
            new CarModule() { CarId = 104, Model = 2004, Name = "Tesla", Price = 40000000 },
            new CarModule() { CarId = 105, Model = 2005, Name = "Bugatii", Price = 50000000 }
        };



    }



    
