using System;
using System.Security.AccessControl;

namespace OOP1
{
   // public delegate string InfoDel(string name);
    public class Anonymous_Method_Delegate
    {
        /* public string Info(string name)
       {
           return "My name is "+ name;
       }*/

        public static void Main(string[] args)
       {
           Anonymous_Method_Delegate obj  = new Anonymous_Method_Delegate();



            /* anonynous method used from here -----------------------------------------------------------
             In this method we don't need to create a method outside 
            we can create method with help of delegate key----------------------------------------- */

            /* InfoDel info = delegate (string name)
            {
                return "My name is " + name;
            };
            */

           // string myname = "Sunil Nepali ";
            // Console.WriteLine(info(myname));


            // Anonymnous functioin using Func method-------------------------------------------------------


            Func<string, string> info = delegate (string name)

            {
                return "My name is" + name ; };


           string myname = "Sunil Nepali ";
           Console.WriteLine(info(myname));
        }

    }
}
