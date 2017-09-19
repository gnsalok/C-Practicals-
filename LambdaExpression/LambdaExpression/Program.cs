using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudent = new List<Student>()
            {
            new Student{ ID = 101, Name = "Sam"},
            new Student{ ID = 102, Name = "John"},
            new Student{ ID = 103, Name = "Bob"},
            };

            //// To find an student with Id = 102, using anonymous method
            //Student student = listStudent.Find
            //    (delegate (Student Stu) { return Stu.ID == 102; });
            //Console.WriteLine($"The student with Id {student.ID} is {student.Name}");

            // To find an student with Id = 102, using lambda Expression 
            //=> operand called as Lambda Operand and it decides the type acco. to you type 
            //There is no need to define it explicitly..
            Student studentL = listStudent.Find(Stu => Stu.ID == 102);

            Console.WriteLine($"The student with Id {studentL.ID} is {studentL.Name}");

        }
    }


    public class Student
    {
        public int ID;
        public string Name;
    }
}
