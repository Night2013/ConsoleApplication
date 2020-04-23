using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Colton Craig";
            var location = "Auburn, California";

            Console.WriteLine($"My name is: " + name);
            Console.WriteLine($"My location is: " + location);


            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }
}
