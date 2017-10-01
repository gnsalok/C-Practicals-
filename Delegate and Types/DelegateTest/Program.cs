using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
   public delegate int myDelegate(int n1, int n2);
    class Program
    {
        static void Main(string[] args)
        {
            //myDelegate del = new myDelegate(Add);   //nulticast and single delegate
            //del += new  myDelegate(Sub);
            //del.Invoke();
           

            myDelegate del = delegate (int n1, int n2)
             {
                 return n1 + n2;
             };
            Console.WriteLine($" Addition is : {del.Invoke(12,13).ToString()}");

            Console.WriteLine($" Addition is : {del.Invoke(12, 13)}");
        }
    }

        //public static void Add()
        //{
        //    Console.WriteLine("Enter two no. to add");
        //    int num1 = Convert.ToInt16(Console.ReadLine());
        //    int num2 = Convert.ToInt16(Console.ReadLine());
        //    int result = num1 + num2;
        //    Console.WriteLine($"Sum is : {result}");
        //}
        //public static void Sub()
        //{
        //    Console.WriteLine("Enter two no. to add");
        //    int num1 = Convert.ToInt16(Console.ReadLine());
        //    int num2 = Convert.ToInt16(Console.ReadLine());
        //    int result = num1 - num2;
        //    Console.WriteLine($"Subtraction is : {result}");
        //}
    }
