using january_2024;
using Microsoft.VisualBasic;
using System.Reflection.Emit;

internal class Program
{
    // assignment operators =, +=, -=, *=, /=, &=, %=
    // logical operators &&, ||, ! 
    // comparison operators ==, !=, >, <, >=, <=
    // statement;conditional statement & looping
    // conditional statement ; if&else-statement, switch case
    //   || this means OR
    //   != this means NOT EQUAL TO
    //   == this means 
    //   && this means AND
    // looping
    //while
    //dowhile
    //for
    //foreach

    private static void Main(string[] args)
    {
        int y = 25;
        y += 23;
        y -= 10;
        y *= 10;
        y /= 2;
        //Console.WriteLine(y);
        //ConditionalStatement();
        //CombinedMethod();
        //CombinedMethod2();
        SwitchCaseMethod();
    }
    static void ConditionalStatement()
    {
        int x = 245;     int b = 90;
        int v = 654;     int c = 76;

        if(x == v)
        {
            Console.WriteLine("the result is correct");
        }
        else
        {
            Console.WriteLine("the result is not correct");
        }

        if (b != v)
        {
            Console.WriteLine("the result is correct");
        }
        else
        {
            Console.WriteLine("the result is not correct");
        }
        if (b > 100)
        {
            Console.WriteLine("B is greater");
        }
        else
        {
            Console.WriteLine("B is not greater");
        }
    }
    static void CombinedMethod()
    {
        Console.WriteLine("Hello what would you like to get");
        Console.WriteLine("select 1. for coffee, 2. for bread, 3. for tea");
        int result = int.Parse(Console.ReadLine());
        // Parse is used for converting string datatype to int datatype

        int x = 1;
        int b = 2;
        int v = 3;

        if(result == x || result == b || result == v)
        {
            Console.WriteLine("thank you for your patronage");
        }
        else
        {
            Console.WriteLine("Please select the right value");
        }
    }
    static void CombinedMethod2()
    {
        Console.WriteLine("Hello what would you like to get");
        Console.WriteLine("select 2. for bread");
        int result = int.Parse(Console.ReadLine());
        Console.WriteLine("please input 3 for your budget price");
        int result2 = int.Parse(Console.ReadLine());

        int b = 2;
        int v = 3;
        if (result == b && result2 == v)
        {
            Console.WriteLine("thank you for your patronage");
        }
        else
        {
            Console.WriteLine("please select the right value");
        }
    }
    static void SwitchCaseMethod()
    {
        Label:
        Console.WriteLine("please select days of the week in Numerical Format");
        int result = int.Parse(Console.ReadLine());
        switch(result)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
                default:
                Console.WriteLine("the value does not exist");
                goto Label;
        }
    }






}