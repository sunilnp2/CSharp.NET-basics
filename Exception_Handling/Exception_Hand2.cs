using System;


namespace Exception_Handling
{
    public class Exception_Hand2
    {
        static void DivTwo()
        {
            Console.WriteLine("Enter value a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value b: ");
            int b = int.Parse(Console.ReadLine());

            int result = a / b;
            Console.WriteLine($"The result of a/b is: {result}");
        }

        public static void Main(string[] args)
        {
            try
            {
                Exception_Hand2.DivTwo();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Code is finished here.");
            }
        }
    }
}
