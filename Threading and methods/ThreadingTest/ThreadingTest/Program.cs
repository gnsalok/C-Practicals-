using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingTest
{
    class Abc
    {

        public void method1()
        {
            for (int i = 0; i <= 40; i++)
            {
                Thread.Sleep(5000);
                Console.WriteLine($"calling loop 1 {i}");
            }
        }

    }
    class Xyz
    {

        public void method2()
        {
            for (int i = 40; i <= 60; i++)
            {
                Thread.Sleep(10000);
                Console.WriteLine($"calling loop 2 {i}");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Abc aa = new Abc();
            //aa.method1();

            Xyz bb = new Xyz();
            //bb.method2();

            Thread th = new Thread(aa.method1);
            th.Start();
            th.Priority = ThreadPriority.Highest;

            Thread th1 = new Thread(bb.method2);
            th1.Start();
            //th1.Priority = ThreadPriority.AboveNormal;




        }
    }
}
