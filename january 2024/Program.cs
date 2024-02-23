using january_2024;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

   private static void Main(string[] args)
   {
        //List
        List <int> Numbers = new List <int> ();
        Numbers.Add (17);
        Numbers.Add(18);
        Numbers.Add (19);
        Numbers.Add(34);
        Numbers.Add(65);

        foreach (int i in Numbers)
        {
            Console.WriteLine (  i   );
        }


        //Queue
        Queue <string> words = new Queue <string> ();
        words.Enqueue("chalk");
        words.Enqueue("Board");
        words.Enqueue("Purse");
        words.Enqueue("Bag");
        words.Enqueue("Chair");
        words.Enqueue("Table");

        Console.WriteLine("Total Elements : {0}", words.Count());//this simply counts the total elements

        var Data = words.Dequeue ();//this prints and remove the first elements
        Console.WriteLine (Data);

        Console.WriteLine("Total Elements : {0}", words.Count());

        if(words.Count() > 0)
        {
            Console.WriteLine (words.Peek ());//this prints and do not remove the first element
        }
        Console.WriteLine("Total Elements : {0}", words.Count());

        var data = words.Dequeue ();
        Console.WriteLine (data);

        Console.WriteLine("Total Elements : {0}", words.Count());



        //Stacks
        Stack<int> stacklist = new Stack<int> ();
        stacklist.Push (1);
        stacklist.Push (2);
        stacklist.Push (3);
        stacklist.Push (4);
        stacklist.Push (5);
        stacklist.Push (6);
        stacklist.Push (7);

        Console.WriteLine("Numbers of elements in stack :{0}", stacklist.Count());

        while (stacklist.Count > 0)
        {
            Console.Write(stacklist.Pop() + " , ");
        }
        Console.WriteLine("Numbers of elements in stack :{0}", stacklist.Count());

    } 

      
     

    


}