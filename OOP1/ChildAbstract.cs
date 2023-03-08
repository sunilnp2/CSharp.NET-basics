using System;


namespace OOP1
{
    public  class ChildAbstract : ParentAbstract
    {
        public ChildAbstract(int i, int j,int c)
        {
            this.a = i;
            this.b = j;
            this.c = c;
        }

        public override void OutPut()
        {
            
            Console.WriteLine(a*b);
        }

        public override int Sum()
        {
            return a * b * c;
        }

        static void Main(string[] args)
        {
            ChildAbstract c = new ChildAbstract(4, 6, 7);
            c.OutPut();
            Console.WriteLine(c.Sum()); 
        }
    }
}
