using System;
using System.Collections.Generic;
using System.Collections;

namespace ListGenericCollection
{

    class MyClass<Type>
    {
        List<Type> ll = new List<Type>();

        public void insert(Type value)
        {
            ll.Add(value);
        }
        public void show()
        {
            Console.WriteLine("List of items is : ");
            //    foreach (object temp in ll)
            //    {
            //        Console.WriteLine(temp);
            //    }

            //Accessing the list using Ienumerable/Ienumerator

            //IEnumerable<Type> ienum =  (IEnumerable<Type>)(ll);
            //Console.WriteLine("List is:");
            //foreach(Type i in ll)
            //{
            //    Console.WriteLine(i);
            //}

            //Accessing the list using Ienumerable/Ienumerator

            IEnumerator<Type> enmentr = ll.GetEnumerator();

            while(enmentr.MoveNext())
            {
                Console.WriteLine(enmentr.Current.ToString());
                
            }
        }


    }
    class main
    {
        static void Main(string[] args)
        {
            MyClass<string> obj1 = new MyClass<string>();
            Console.WriteLine("How many items you want to insert :");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                obj1.insert((Console.ReadLine()));
            }
            obj1.show();

            Console.ReadLine();
        }
    }
}
