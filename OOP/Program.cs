using System;


namespace OOP
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("This is Abstract Override class");
        }
        public static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle();
            rectangle.Draw(); // Output: Drawing a rectangle


        }
    }

  


}

