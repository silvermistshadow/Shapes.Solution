using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shapes.Models;

namespace ShapesTests
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void Sphere_GetVolume_VolumeOfSphere()
        {
            //Arrange
            Circle newCircle = new Circle(4);
            Sphere newSphere = new Sphere(newCircle);
            double expectedResult = Math.Round(((4 * Circle.Pi * (4 * 4 * 4)) / 3), 5);
            //Act
            double result = newSphere.getVoulume();
            Console.WriteLine(result);
            //Assert
            Assert.AreEqual(result, expectedResult);
            
        }
    }
}