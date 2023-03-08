using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
   
    internal class Generic_Class<T>
    {
        T[] t = new T[5];
        int count = 0;  
        public void addItem(T item)
        {
            if (count <  5)
            {
                t[count] = item;  
                count++;
            }
            else
            {
                Console.WriteLine("Overflow exists ");
            }
        }

        public void DisplayItem() { 
        for (int i=0; i<count; i++) { 
            Console.WriteLine("Item at index {0} is {1}.", i, t[i]);
            }
        }

    }

    public class GenericEx
    {

        public GenericEx() { }  
        static void Main(string[] args)
        {
            Generic_Class<int> obj = new Generic_Class<int>();
            obj.addItem(10); 
            obj.addItem(20);
            obj.addItem(30);
            obj.addItem(40);
            obj.addItem(50);
            obj.addItem(60);
            obj.DisplayItem();
            Console.ReadKey();
        }
    }
}
