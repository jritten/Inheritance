using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceTests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TestProperties()
        {
            // arrange
            var expectedTopLeft = new Inheritance.Point(1, 2);
            var expectedLength = 0.0;
            var expectedName = "Square";
            // act
            var square = new Inheritance.Square(expectedTopLeft, expectedLength);
            // assert
            Assert.AreEqual(square.TopLeft, expectedTopLeft);
            Assert.AreEqual(square.Name, expectedName);
        }
        [TestMethod]
        public void TestAreaProperty()
        {
            // arrange
            var expectedTopLeft = new Inheritance.Point(1, 2);
            var expectedLength = 0.0;
            var expectedArea = 0.0;
            // act
            var square = new Inheritance.Square(expectedTopLeft, expectedLength);
            // assert
            Assert.AreEqual(square.Area, expectedArea);
        }
    }
}
