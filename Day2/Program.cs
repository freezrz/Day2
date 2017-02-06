using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, t=2;
            int a = 5, b = 10;
            int result=0;
            result = i + t;
            System.Console.WriteLine(result);
            System.Console.WriteLine("say \"HELLO\"");
            System.Console.WriteLine('a');
            System.Console.WriteLine(a+"+"+b+"="+(a+b));
            double d = 12345.456494;
            Console.WriteLine("${0:00,00.00}",d);
    
        }
    }
}
