using System;

namespace OOP1
{
    public delegate void ValueDelegates(double width, double height);
    public  class Multicast_Delegates
    {
        public void Area(double width, double height)
        {
            Console.WriteLine($"area of rectange is :" + width * height);
        }
        public void Parameter(double width, double height)
        {
            Console.WriteLine($"Parameter of rectange is :" + 2*(width + height));
        }

        static void Main(string[] args)
        {
            Multicast_Delegates obj = new Multicast_Delegates();

            ValueDelegates del = obj.Area;
            del += obj.Parameter;

            del(5.55, 4.55);
           
        }
    }
}
