using january_2024;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    private static void Main(string[] args)
    {

        int[] Numerical1 = { 1, 2, 3, 4, 5,5,6,6,7,7 };
        int[] Numerical2 = { 7,7,8,9,10,11,12,12,89};
        int[] Numerical3 = { };
        string[] words = { };

        //quantifiers
        var anyMethod = Numerical2.Any(x => x % 2 == 0);//checking if there is any even numbers
        Console.WriteLine(anyMethod);

        var allMethod = Numerical2.All(x => x % 2 == 0);//checkig if all of the value are evennumbers
        Console.WriteLine(allMethod);

        var containMethod = Numerical2.Contains(5);//checking is N2 has the value 5
        Console.WriteLine(containMethod);




        //aggregate operators
        var result = Numerical1.ToList();
        var counteven = result.Count(x => x % 2 == 0);
        Console.WriteLine(counteven);

        var sumValue = result.Sum();
        Console.WriteLine(sumValue);

        var maxValue = result.Max();
        Console.WriteLine(maxValue);

        var minValue = result.Min();
        Console.WriteLine(minValue);

        var averageValue = result.Average();
        Console.WriteLine(averageValue);







        var distinctMethod = Numerical1.Distinct();//this distinct method basically print all the duplicates as one
        foreach (int i in distinctMethod)
        {
            Console.WriteLine(i);
        }

        var unionMethod = Numerical1.Union(Numerical2);

        foreach (int v in unionMethod)
        {
            Console.WriteLine("union :" + string.Join(",", v));


        }

        var intersectMethod = Numerical1.Intersect(Numerical2);//intersect method shows u what appear in both sequence

        foreach (int v in intersectMethod)
        {
            Console.WriteLine("intersect :" + string.Join(",", v));


        }

        var expectMethod = Numerical1.Except(Numerical2);// expect method shows you what is in 1 but doesnt appear in 2

        foreach (int v in expectMethod)
        {
            Console.WriteLine("expect :" + string.Join(",", v));


        }

        var concatMethod = Numerical1.Concat(Numerical2);//this concat methods prints everthing in the two data source

        foreach (int v in concatMethod)
        {
            Console.WriteLine("Concat :" + string.Join(",", v));

        }



    }






}


    
