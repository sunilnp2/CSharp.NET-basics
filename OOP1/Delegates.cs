using System;
using System.Data;

namespace OOP1
{
    public delegate void InfoDelegate(string name, int gaage);
    public delegate int AreaDelegate(int l, int b);
    public  class Delegates
    {

        public void Info(string name, int age)
        {
            Console.WriteLine($"Hello welcome  {name} College");
        }
        public int Area(int l, int b)
        {
            return l*b;
        }

        public static void Main(string[] args)
        {
            Delegates obj  = new Delegates();
            InfoDelegate del1 = obj.Info;
            AreaDelegate del2 = obj.Area;

            del1("Triton", 20);
            Console.WriteLine(del2(5, 6));

        }
    }
}
