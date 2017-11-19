using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate void TestDelegate(string s);

        static void M(string s)
        {
            Console.WriteLine(s);
        }


        static void Main(string[] args)
        {
            //old
            //type safe function pointer
            TestDelegate testDelA = new TestDelegate(M);

            //c# 2.0
            //achieve by delegate keyword
            TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };

            //c# 3.0
            //Ananymous Function
            //Lambda expression
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };

            // Invoke the delegates.
            testDelA("Hello. My name is M and I write lines.");
            testDelB("That's nothing. I'm anonymous and ");
            testDelC("I'm a famous author.");


            /// Note : Func<in, out> is also a delegate (return the value and take the parameter)
            /// and Action<in> is also a delegate (returns void and take the single parameter)
            /// Predicate<>  is also a delegate that return boolean value when given condition is satisfied
            
     


        }
        
    }
}
