using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter angle: ");
            float angle=float.Parse(Console.ReadLine());
            float angleRad = angle * (float)Math.PI / 180;
            float cosine = (float)Math.Cos(angleRad);
            float sine = (float)Math.Sin(angleRad);
            Console.WriteLine("Cosine: " + cosine);
            Console.WriteLine("Sine: " + sine);
        }
    }
}
