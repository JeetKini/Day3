using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_seriesPart_2
{
    public class Student
    {
        public String name;
        public  void Introduce(String s)
        {
            Console.WriteLine("Hii {0},my name is{1} ", s, name);
        }
        public static Student Parse(String s) { 
        var stud=new Student();
            stud.name = s;  
            return stud;

        }

    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
          
           var p= Student.Parse("jeet");
           
            p.Introduce("jay");
        }
    }
}
