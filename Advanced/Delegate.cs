using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    public delegate void InfoDelegate(string name, int gaage);
    public delegate int AreaDelegate(int l, int b);
    public class Delegates
    {

        public void Info(string name, int age)
        {
            Console.WriteLine($"My nme is {name} i am  {age} years old. This is delegate");
        }
        public int Area(int l, int b)
        {
            return l * b;
        }

        public static void Main(string[] args)
        {
            Delegates obj = new Delegates();
            InfoDelegate del1 = obj.Info;
            AreaDelegate del2 = obj.Area;

            del1("Sunil", 20);
            Console.WriteLine(del2(5, 6));

        }
    }
}
