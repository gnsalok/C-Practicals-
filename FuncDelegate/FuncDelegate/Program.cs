using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<string, string> convert = s => s.ToUpper();

            //string name = "Sample Text";

            //Console.WriteLine(convert(name));


            Func<string, string> convert = delegate (string s)
            { return s.ToUpper(); };

            string name = "Dakota";
            Console.WriteLine(convert(name));



            Func<int, int> cube = delegate (int c)
               {
                   return c * c * c;
               };

            Console.WriteLine("Enter a value to find cube?");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The cube is :"+cube(3));
            
            
        }
    }
}
