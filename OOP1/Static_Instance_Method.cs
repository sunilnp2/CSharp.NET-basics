using System;
using System.Reflection.Emit;

namespace OOP1
{
    public class Static_Instance_Method
    {

        //constructor
        public Static_Instance_Method() {
            Console.WriteLine("This is constructor ");

        }

        /* static  and instance method
       <modifier> Return type<Method_name>(Parameter) { //code } return garnu xa vney 
       public int Info(string name){
        return name;}
        if don't want to  return just display ------------------------------ 
        public void Display(string name) {
        Console.WriteLine(name); }
        */

        //static method ---------------------------------------------------------
        public static void Info(string name)
        {
            Console.WriteLine("My name is in static method "+ name);
        }

        //instance method ---------------------------------------------------------
        public void Display(string name)
        {
            Console.WriteLine("My name is in instance method 0"+ name);
        }

        public static void Main(string[] args)
        {

            //to call static method
            Static_Instance_Method.Info("Sunil Nepali");


            // to call instance method we need to create instance / object of class
            Static_Instance_Method obj = new Static_Instance_Method();
            obj.Display("Sunil Nepali");
        }
    


    }
}
