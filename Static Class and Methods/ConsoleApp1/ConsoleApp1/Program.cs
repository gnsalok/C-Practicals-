using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    public static class MyClass
    {
       

        static MyClass()
        {
            Console.WriteLine("Constructor is fired");

        }
        public static void ShowMethod()
        {
            Console.WriteLine($"Showing the static method");
        }
    }

        class Program
        {

            static void Main(string[] args)
            {
                MyClass.ShowMethod();
                MyClass.ShowMethod();
            }
       
    }
}

