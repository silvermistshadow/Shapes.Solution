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
            //Assert
            Assert.AreEqual(result, expectedResult);
            
        }

        [TestMethod]
        public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
        {
            //Arrange
            Sphere newSphere = new Sphere(new Circle(4));
            double expectedResult = Math.Round((4 * Circle.Pi * (4 * 4)), 5);
            //Act
            double result = newSphere.getSurfaceArea();
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}