using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! -  changed on the server");

            Console.WriteLine("Another line added by the client");
            
            Console.WriteLine("There you go! There is another modification");

            for(int i=1; i<=10; i++)
            {
                int k = 5 * i;
                Console.WriteLine(k);
            }
           
        }
    }
}
