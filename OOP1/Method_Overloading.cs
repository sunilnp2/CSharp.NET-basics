using OOP1;
using System;


namespace OOP1
{
    public class Parent
    {

        public virtual void  Sum()
        {
            Console.WriteLine("This is method in Parent Class");
        }


    }
     
    public class Child : Parent
    {
        public override void Sum()
        {
            Console.WriteLine("This is method overriding !");
        }

       
    }

  


}
public class Program
{
    static void Main(string[] args)
    {
        Child obj = new Child();
        obj.Sum();

    }
}

