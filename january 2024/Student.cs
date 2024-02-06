using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace january_2024
{
  

    public  enum Gender
    {
        Male,
        Female,
        Unknown
    }
  
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class {  get; set; }
        public Gender Gender { get; set; }

      
    }

   
}
