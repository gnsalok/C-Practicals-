using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class D
    {
        public virtual void DoWork()
        {
            Console.WriteLine("Oringinal Implementation");
        }
    }


    public abstract class E : D
    {
        public abstract override void DoWork();         //only declare it 
    }

    public class F : E
    {
        public  override void DoWork() { Console.WriteLine("New implementation"); }

    }
    //public class F : E
    //{
    //    public sealed  override void DoWork()       //now here you cannt override it more cause its sealed now
    //    {
    //        Console.WriteLine("New Implementation");
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //E ee= new E();
            F ff = new F();
            ff.DoWork();

            D dd = new D();
            dd.DoWork();

        }
    }
}
