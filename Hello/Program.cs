using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name:");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get lats night?");
            int hoursOfSleep = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}", name);

            if (hoursOfSleep < 8)
            {
                Console.WriteLine("You didn't get very much sleep last night.");
            }
            else
            {
                Console.WriteLine("You are well rested.");
            }
        }
    }
}
