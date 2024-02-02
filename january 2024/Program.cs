
using Microsoft.VisualBasic;
using System.Reflection.Emit;

internal class Program
{
    //escape sequence
    // \'
    // \"
    // \n = new line before the next word
    // \r
    // \t
    // \0
    // \b
  
    private static void Main(string[] args)
    {
        string sample = "Hello\nVictor";
        string sample2 = "c:\\codebuns\\file.cs";
        string sample3 = "i am a \"junior developer\".";
        Console.WriteLine(sample);
        Console.WriteLine(sample2);
        Console.WriteLine(sample3);

    }
   
}