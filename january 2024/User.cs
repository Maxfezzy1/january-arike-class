using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace january_2024
{
    //static; everything in that class has to be static and to call a static class in your main method it is straight forward
    public static class User
    {
        public static decimal Age { get; set; }


        public static void UserInfo()
        {
            Console.WriteLine("this user is blessed");
        }
    }
}
