using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Program for calc distance and angle between two points
/// </summary>
namespace _1weekFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization module
            float aX, aY, bX, bY; //input variables

            float dist, angle; //output variables

            float dX, dY; //temp variables

            //Welcoming user
            Console.WriteLine("Welcome.");
            Console.WriteLine("This application will calculate distance and angle between two points");
            //Input module
            Console.Write("Point 1 X:");
            aX = float.Parse(Console.ReadLine());
            Console.Write("Point 1 Y:");
            aY = float.Parse(Console.ReadLine());
            Console.Write("Point 2 X:");
            bX = float.Parse(Console.ReadLine());
            Console.Write("Point 2 Y:");
            bY = float.Parse(Console.ReadLine());

            //temp calculation module
            dX = aX - bX;
            dY = aY - bY;

            //distance module
            dist = (float)Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            //angle module
            angle = (float)(Math.Atan2((double)dY, (double)dX) * 180 / Math.PI);
            //Output module
            Console.WriteLine("With those inputs, the expected outputs are:");
            Console.WriteLine("Distance between points: " + dist);
            Console.WriteLine("Angle between points: " + angle + " degrees");
        }
    }
}
