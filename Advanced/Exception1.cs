using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    public class Exception1
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter value a: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter value b: ");
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
                Console.WriteLine($"The result of a/b is: {result}");
            }

            catch (DivideByZeroException ex1)
            {
                Console.WriteLine("Can't divisible by 0");
                Console.WriteLine(ex1.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Code is finished here");
            }




        }
    }
}
