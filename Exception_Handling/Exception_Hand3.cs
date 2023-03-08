using System;


namespace Exception_Handling
{
    public class Exception_Hand3
    {
        public void DivideTwo()
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
            Exception_Hand3 obj = new Exception_Hand3();


            try
            {
                obj.DivideTwo();
            }

            catch (FormatException)
            {
                Console.WriteLine("Value must be input in integer");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Value can't be zero");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Integer takes only 32 bits");
            }
            finally
            {
                Console.WriteLine("Code is completed here");
            }
        }
    }
}
