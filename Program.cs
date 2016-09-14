using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method named "Double" to calculate and return an integer number doubled. For example. Double(7) should return 14.
            int num = 6;
            Console.WriteLine(Double(num));
        }
        static int Double(int num)
        {
            int num2 = num * 2;
            return num2;
          
        }
        
    }
}
