using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    public class Program
    {

        public virtual void BaseMethod()
        {
            Console.WriteLine("I am inside base class ");
        }
        

       
    }

    public class Child : Program
    {
        public override void BaseMethod()
        {
           Console.WriteLine("I am inside Child Class ");
        }
    }


    public class final
    {
        public static void Main(string[] args)
        {
            Child obj = new Child();
           obj.BaseMethod();
            
        }
    }
}
