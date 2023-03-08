using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{

    internal class LinqPrint
    {
        static void Main(string[] args)
        {
            string[] names = { "Sunil Nepali", "Anil", "Asmit", "Ram", "Shyam" };

            var a = from i in names where i.StartsWith("S") select i;

            Console.WriteLine("LINQ name starts with s are :");
            foreach (var name in a)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
