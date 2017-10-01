using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructor
{

    //Now this class is gonna to work like utility class
    class FirstClass
    {
        private FirstClass() { }

        public static int Add(int num1,  int num2)
        {
            return num1 + num2;
        }
    }
    //you cannt inherite this class
    //class SecondClass : FirstClass
    //{

    //}

    class Program
    {
        static void Main(string[] args)
        {

            int Result = FirstClass.Add(12, 13);
            Console.WriteLine($"Your result is:  {Result}");


            //FirstClass F1 = new FirstClass();
            Console.ReadKey();
        }
    }
}
