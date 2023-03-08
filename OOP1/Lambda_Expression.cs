using System;

namespace OOP1
{
        public delegate string InfoLambda(string name);
    public class Lambda_Expression
    {

        static void Main(string[] args)
        {
            Lambda_Expression obj = new Lambda_Expression();
            InfoLambda info = (name) =>
            {
                return "Hello My name is" + name;
            };

            string myname = "Sunil Nepali In Lambda Expression";
            Console.WriteLine(myname);
        }
    }
}
