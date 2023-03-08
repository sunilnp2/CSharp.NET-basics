using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Construct
    {

        public Construct(int i, int j)
        {
            Console.WriteLine($"This is sum =  {i + j}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Code Running ....!");
            Construct obj = new Construct(4, 5);
            Console.ReadKey();
        }
    }


}
