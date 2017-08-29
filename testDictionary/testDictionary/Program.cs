using System;
using System.Collections.Generic;
using System.Collections;

namespace ListGenericCollection
{

    class MyClass<T1,T2>
    {
        Dictionary<T1,T2> dic = new Dictionary<T1, T2>();

        public void insert(T1 k, T2 v)
        {
            dic.Add(k,v);
        }
        public void show()
        {
            Console.WriteLine("List of items is : ");
            Console.WriteLine("Keys are :");
            foreach (object temp in dic.Keys)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("Values are :");
            foreach (object temp in dic.Values)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("Both are :");

            foreach(KeyValuePair<int,string> temp1 in dic)
            {
                Console.WriteLine(dic.Keys);
                
            }

        }


    }
    class main
    {
        static void Main(string[] args)
        {
            MyClass<int,string> obj1 = new MyClass<int,string>();
            Console.WriteLine("How many items you want to insert :");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                obj1.insert(i,(Console.ReadLine()));
            }
            obj1.show();

            Console.ReadLine();
        }
    }
}

