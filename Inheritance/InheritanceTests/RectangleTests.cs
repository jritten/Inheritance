using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestNameSetProperly()
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
    }
}
