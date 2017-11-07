
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);

            string s = "Hello Extension Methods";
            int i = s.Length;
            Console.WriteLine( "Length of string is "+i);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
            var max = numbers.Max();

            Console.WriteLine("The Max number in the list is :"+max);






        }
    }
}
