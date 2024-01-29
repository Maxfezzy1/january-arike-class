using january_2024;
using Microsoft.VisualBasic;
using System.Reflection.Emit;

internal class Program
{
    //looping
    //while
    //dowhile
    //for
    //foreach

    private static void Main(string[] args)
    {
        //how to declare more values to a variable... use of an array[]
        //foreach-loop
        int[] numbers = { 1, 2, 3, 89, 4, 5, 6, 7, 8, 9, 98};
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        //Forloop
        for (int i = 0; i <= 10; i++)
        {
           Console.WriteLine(i);
        }

        //do while
        int y = 0;
        do
        {
            Console.WriteLine("do while result is "+" "+y);
            y++;
        }
        while (y < 20);

        //while
        int x = 0;
        while (x < 20)
        {
            Console.WriteLine("while result is"+" "+x);
            x++;
        }


    }
   






}