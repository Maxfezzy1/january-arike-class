using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace january_2024
{
   //generic means something that is not specific to a particular datatype in C# until u declare them urself
   //generic <T> put this in front and it makes either the method or class generic
    public class Student
    {
        public static void Ifenna<T>(T value1, T value2)
        {
            Console.WriteLine("value 1 = {0} and Value2 = {1}", value1, value2);

        }
      
    }
}
