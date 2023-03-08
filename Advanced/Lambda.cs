using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    public delegate string InfoLambda(string name);
    public class Lambda
    {

        static void Main(string[] args)
        {
            Lambda obj = new Lambda();
            InfoLambda info = (name) =>
            {
                return "Hello My name is" + name;
            };

            string myname = "This is Program in Lambda Expression";
            Console.WriteLine(myname);
        }
    }
}
