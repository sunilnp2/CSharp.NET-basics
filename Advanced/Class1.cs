using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    internal class Class1
    {
        public static void Main(string[] args)


        
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("*******************");
            numbers.Push("MCA");
            numbers.Push("BCA");
            numbers.Push("MBA");
            numbers.Push("BBA");
            numbers.Push("*******************");

            Console.WriteLine("The elements of Stacks are :");
            // A stack can be enumerated without disturbing its contents.
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            
          numbers.Pop();
          numbers.Pop();
            Console.WriteLine("The elements of Stacksn after removal  are :");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
