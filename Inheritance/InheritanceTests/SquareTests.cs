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
        [TestMethod]
        public void TestEquals()
        {
            // arrange
            var pointObj = new Inheritance.Point(1, 1);
            var length1 = 1;
            var length2 = 2;
            var square1 = new Inheritance.Square(pointObj, length1);
            var squareEqual = new Inheritance.Square(pointObj, length1);
            var squareNotEqual = new Inheritance.Square(pointObj, length2);
            // act
            var equalityCheckPass = square1.Equals(squareEqual);
            var equalityCheckFail = square1.Equals(squareNotEqual);
            // assert
            Assert.IsTrue(equalityCheckPass);
            Assert.IsFalse(equalityCheckFail);
        }
    }
}
