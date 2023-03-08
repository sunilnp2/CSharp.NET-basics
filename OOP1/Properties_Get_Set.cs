using System;


namespace OOP1
{
    public class Properties_Get_Set
    {
        string name = "Sunil Nepali";
        int age = 20;


        public string Name
        {
            get { return name; }
            set { this.name = value ; }
        }

        static void Main(string[] args)
        {
            Properties_Get_Set obj = new Properties_Get_Set();

            //to get value 
            Console.WriteLine(obj.Name);

            //to set value
            obj.Name = "Samir Neupane";
            Console.WriteLine(obj.Name);
        }
    }
    
}
