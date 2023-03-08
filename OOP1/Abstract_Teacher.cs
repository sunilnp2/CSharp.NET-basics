using System;
using System.Security.Policy;

namespace OOP1
{
    internal class Abstract_Teacher:Abstract_Inheritance
    {
        public Abstract_Teacher()
        {
            Console.WriteLine("Enter Collge Name : ");
            string collge = Console.ReadLine();
            Console.WriteLine("Enter Teacher Name : ");
            string t_name = Console.ReadLine();
            Console.WriteLine("Enter Teacher Subject : ");
            string t_subject = Console.ReadLine();
            Console.WriteLine("Enter Teacher Address : ");
            string add = Console.ReadLine();
            Console.WriteLine("Enter Teacher Salary : ");
            int salary  = Convert.ToInt32(Console.ReadLine()); ;

           
            this.teacher_name= t_name;
            this.collge_name = collge; 
            this.address = add;
            this.teacher_subject = t_subject;
            this.salary = salary;

           
        }

        public override void Info()
        {
            string info = $"{teacher_name} is {teacher_subject} subject Teacher of {collge_name} Collge who live in {address}.\n He earn Rs.{salary} per month for teaching {teacher_subject}. ";
            Console.WriteLine(info);
        }

        static void Main(string[] args)
        {
            Abstract_Teacher obj = new Abstract_Teacher();
            obj.Info();
        }


    }
}
