using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    internal class List
    {

        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            Console.WriteLine("The list emelemts of Integers ");
            foreach (int dinosaur in numbers)
            {
                Console.WriteLine(dinosaur);
            } 
            
            List<string> str = new List<string>();

            str.Add("Mahesh Chand");
            str.Add("Samir Prasad");
            str.Add("Naveen Sharma");
            str.Add("Sachin Majarna");
            str.Add("Ram");
            Console.WriteLine("The list emelemts of strings ");
            foreach (string dinosaur in str)
            {
                Console.WriteLine(dinosaur);
            }
        }
    }
}
