using january_2024;
using Microsoft.VisualBasic;

internal class Program

{
    //types of datatypes
    //integer int
    //string
    //float
    //bool boolean
    //decimal
    //double
    //long
    //byte

    static int v = 56;
    static string firstname = "Ifenna";
    static string lastname = "Ezeh";
    float x = 6754657;
    bool y = false;
    decimal values = 899.7879m;
    double numerical = 755676.89678;
    static  DateTime dateonly = DateTime.Now;

    private static void Main(string[] args)
    {
        //Console.WriteLine(v);

        // Console.WriteLine("Hello"+" "+lastname+" "+firstname);

        //Console.WriteLine(dateonly);

        // const int data = 6464;

        //Console.WriteLine(data);
       // welcomememo();


    }
    //conversion
    //implicit casting
    //explicit casting
    static void welcomememo()
    {
        //implicit = increasing
        int data1 = 78;
        double data2 = data1;
        Console.WriteLine(data2);

        //explicit = decreasing a datatype
        double v = 456.22;
        int v2 = (int)v;
        Console.WriteLine(v2);

      
    }

    

}