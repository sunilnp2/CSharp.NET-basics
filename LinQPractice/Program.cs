using System;
using System.Collections.Generic;
using System.Linq;


namespace LinQPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] names = {"Sunil Nepali" , "Anil", "Asmit", "Ram", "Shyam"};

            var a = from i in names where i.StartsWith("S") select i;

            foreach(var name in a)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
           
        }
    }
}
