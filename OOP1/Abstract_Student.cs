using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Abstract_Student:Abstract_Inheritance
    {
        public Abstract_Student()
        {
            Console.WriteLine("Enter Collge Name : ");
            string collge = Console.ReadLine();
            Console.WriteLine("Enter Student Name : ");
            string s_name = Console.ReadLine();
            Console.WriteLine("Enter Student Faculty : ");
            string s_faculty = Console.ReadLine();
            Console.WriteLine("Enter Student Address : ");
            string add = Console.ReadLine();
            Console.WriteLine("Enter Student Fee : ");
            int fee = Convert.ToInt32(Console.ReadLine()); 

            this.collge_name = collge;
            this.student_name= s_name;
            this.faculty = s_faculty;
            this.address = add;
            this.fee = fee;

        }

        public override void Info()
        {
            string info = $"{student_name} is a {faculty} Faculty student of {collge_name}. \n He lives in {address}. He paid Rs.{fee} for {faculty}.";
            Console.WriteLine(info);
        }

        public static void Main(string[] args)
        {
            Abstract_Student obj = new Abstract_Student();
            obj.Info();
        }
    }
}
