using System;

namespace Shapes.Models
{
    public class Sphere
    {
        public Circle Disk { get; set; }
        
        public Sphere (Circle inner)
        {
            Disk = inner;
        }
        public double getVoulume()
        {
            int radius = Disk.Radius;
            double result = (4 * Circle.Pi * (radius * radius * radius)) / 3;
            result = Math.Round(result, 5);
            return result;
        }

        public double getSurfaceArea()
        {
            int radius = Disk.Radius;
            double result = (4 * Circle.Pi * (radius * radius));
            result = Math.Round(result, 5);
            return result;
        }
    }
}