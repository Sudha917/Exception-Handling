using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        public static void Display(string s)
        {
            if (s == null)
            {
                throw new Exception("Argument Can not be null");
            }
        }
        
    }
    class Master:Program
    { 
        static void Main(string[] args)
        {
            string s = null;
            int x=100, y=0;

            try
            {
                Display(s);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(x/ y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", x);
            }
        
            Console.ReadLine();
        }
    }
}
