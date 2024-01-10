using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Elijah Foard";
            string city = "Rexburg";

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am currently in {city}");

            DateTime currentDate = DateTime.Now;
            DateTime christmasDay = new DateTime(currentDate.Year, 12, 25);

            int daysUntilChristmas = (int)(christmasDay - currentDate).TotalDays;


            Console.WriteLine($"Today is {currentDate.ToString("MM/dd/yyyy")}.");
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas.");



            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Enter the width of the window (ft): ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter the height of the window (ft): ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.ReadKey();

        }
    }
}
