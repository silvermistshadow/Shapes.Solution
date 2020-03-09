using System;
using Shapes.Models;

namespace Shapes
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("This program does some math with certain shapes.");
            Console.WriteLine("To start with, specify a shape. Choose from circle, cube, rectangle or sphere.");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "circle":
                    {
                        Console.WriteLine("Input circle radius (must be a whole number, digits only)");
                        Circle newCircle = new Circle(circleRadius: Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine($"The diameter of this circle is {newCircle.getDiameter().ToString()} and the circumference is {newCircle.getCircumference().ToString()}.");
                        break;
                    }

                case "cube":
                    {
                        Console.WriteLine("First, put in a value for the length and width of each face of the cube (single whole number, digits only)");
                        int tempFace = Convert.ToInt32(Console.ReadLine());
                        Cube newCube = new Cube(new Rectangle(tempFace, tempFace));
                        Console.WriteLine($"The volume of the cube is {newCube.GetVolume().ToString()} and the surface area is {newCube.GetSurfaceArea().ToString()}. ");
                        break;
                    }

                case "rectangle":
                    {

                        Console.WriteLine("Input length (whole number, digits only)");
                        int tempLength = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input width (whole number, digits only)");
                        int tempWidth = Convert.ToInt32(Console.ReadLine());
                        Rectangle newRectangle = new Rectangle(tempLength, tempWidth);
                        Console.WriteLine($"The area of the rectangle is {newRectangle.GetArea().ToString()} and it {(newRectangle.IsSquare() ? "is" : "is not")} a square.");
                        break;
                    }

                case "sphere":
                    {
                        Console.WriteLine("Input the radius (whole number, digits only)");
                        Sphere newSphere = new Sphere(new Circle(Convert.ToInt32(Console.ReadLine())));
                        Console.WriteLine($"The volume of the sphere is {newSphere.getVoulume().ToString()} and the surface area is {newSphere.getSurfaceArea().ToString()}.");
                        break;
                    }

                default:
                    Console.WriteLine("I'm sorry, Dave, I'm afraid I can't do that.");
                    break;
            }
        }
    }
}