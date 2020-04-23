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
            string location = "Auburn, California";

            Console.WriteLine($"My name is: {name}");
            Console.WriteLine($"My location is: {location}");

            /* Date */

            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is: {currentDate.ToShortDateString()}");

            /* Christmas */
            var christmasDay = new DateTime(currentDate.Year, 12, 25);
            Console.WriteLine($"Christmas is on: {christmasDay}");

            var timeSpan = christmasDay - currentDate;
            var numberOfDaysUntilChristmas = timeSpan.Days;
            Console.WriteLine($"The number of days until Christmas: {numberOfDaysUntilChristmas}");

            /* Code from textbook */

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter a width (in meters): ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter a height (in meters): ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }
}
