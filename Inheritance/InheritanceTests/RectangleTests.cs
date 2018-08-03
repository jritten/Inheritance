using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestProperties()
        {
            // arrange
            var topLeft = new Inheritance.Point(1, 2);
            var height = 0.0;
            var width = 0.0;
            var expectedName = "Rectangle";
            // act 
            var rectangle = new Inheritance.Rectangle(topLeft, height, width);
            // assert
            Assert.AreEqual(rectangle.Name, expectedName);
            Assert.AreEqual(rectangle.TopLeft, topLeft);
            Assert.AreEqual(rectangle.Height, height);
            Assert.AreEqual(rectangle.Width, width);
        }
        [TestMethod]
        public void TestAreaSetProperly()
        {
            // arrange
            var topLeft = new Inheritance.Point(1, 2);
            var height = 0.0;
            var width = 0.0;
            var expectedArea = 0.0;
            // act 
            var rectangle = new Inheritance.Rectangle(topLeft, height, width);
            // assert
            Assert.AreEqual(rectangle.Area, expectedArea);
        }
        [TestMethod]
        public void TestEquals()
        {
            // arrange
            var pointObj = new Inheritance.Point(1, 1);
            var width = 1;
            var height = 2;
            var rectangle1 = new Inheritance.Rectangle(pointObj, width, height);
            var rectangleEqual = new Inheritance.Rectangle(pointObj, width, height);
            var rectangleNotEqual = new Inheritance.Rectangle(pointObj, width, width);
            // act
            var equalityCheckPass = rectangle1.Equals(rectangleEqual);
            var equalityCheckFail = rectangle1.Equals(rectangleNotEqual);
            // assert
            Assert.IsTrue(equalityCheckPass);
            Assert.IsFalse(equalityCheckFail);
        }
    }
}
