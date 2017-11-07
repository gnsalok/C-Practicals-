
namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 5;
            //dynamic d = i;
            //long l = d;


            ///var keyworld resolves the types at compile time 
            ///while, dynamic resolves at the run time

            dynamic name = "Alok Tripathi";
            name += " Bansgaon";
            System.Console.WriteLine(name);



        }


    }
}
