using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace ShapesTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_GetDiameter_DiameterOfCircle()
        {
            //Arrange
            Circle newCircle = new Circle(4);
            //Act
            int result = newCircle.getDiameter();
            //Assert
            Assert.AreEqual(result, 8);
        }
    }
}