using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp1
{
    class Employee
    {
        string firstName;
        string lastName;


        public string Name{
            set
            {
                if (firstName == 
                    "Alok")
                {
                    throw new Exception("Invalid Name Exception!!");
                }
                else
                {
                    this.firstName = value;
                }
            }


            get { return this.firstName; }
       }


        //public Employee() { Console.WriteLine("Employee Constructor"); }
        public void IntroduceEmployee()
        {
            Console.WriteLine($"Employee is ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Employee ee = new Employee();
            ee.Name = "Alok";
            
            Console.WriteLine($"{ee.Name}");

            Type type = typeof(Employee);


            //object[] arr = type.GetMembers();
            object[] arr = type.GetMethods();

            foreach (var temp in arr)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
           
        }
    }
}
