using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstAltitude, secondAltitude, diffAltitude;
            Console.Write("Enter first altitude: ");
            firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Enter second altitude: ");
            secondAltitude = int.Parse(Console.ReadLine());
            diffAltitude = Math.Abs(firstAltitude - secondAltitude);
            Console.WriteLine("Difference between altitudes is " + diffAltitude);

        }
    }
}
