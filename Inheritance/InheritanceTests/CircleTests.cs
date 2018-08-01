using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestProperties()
        {
            // arrange
            var expectedCenter = new Inheritance.Point(1, 2);
            var expectedRadius = 0.0;
            var expectedName = "Circle";
            // act 
            var circle = new Inheritance.Circle(expectedCenter, expectedRadius);
            // assert
            Assert.AreEqual(circle.Name, expectedName);
            Assert.AreEqual(circle.Center, expectedCenter);
            Assert.AreEqual(circle.Radius, expectedRadius);
        }
        [TestMethod]
        public void TestAreaProperty()
        {
            // arrange
            var expectedCenter = new Inheritance.Point(1, 2);
            var expectedRadius = 0.0;
            var expectedArea = 0.0;
            // act 
            var circle = new Inheritance.Circle(expectedCenter, expectedRadius);
            // assert
            Assert.AreEqual(circle.Area, expectedArea);
        }
    }
}
