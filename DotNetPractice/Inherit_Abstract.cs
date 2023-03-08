using System;
using System.Collections.Generic;


namespace DotNetPractice
{
    internal class Inherit_Abstract:AbstractClass
    {
        public Inherit_Abstract()
        {
            Console.WriteLine("Hello this is constructor in Inherit_Abstract");
        }

        public override int OutPut(int a, int b)
        {
            return a * b;
        }

        static void main(string[] args)
        {
            Inherit_Abstract obj = new Inherit_Abstract();
            int result = obj.OutPut(4, 5);
            Console.WriteLine(result);
        }
    }
}
