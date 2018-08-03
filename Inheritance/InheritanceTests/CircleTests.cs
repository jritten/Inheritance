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
        [TestMethod]
        public void TestEquals()
        {
            // arrange
            var pointObj = new Inheritance.Point(1, 1);
            var radiusNum1 = 1;
            var radiusNum2 = 0;
            var circle1 = new Inheritance.Circle(pointObj, radiusNum1);
            var circle1Equal = new Inheritance.Circle(pointObj, radiusNum1);
            var circleUnequal = new Inheritance.Circle(pointObj, radiusNum2);
            // act
            var equalityCheckPass = circle1.Equals(circle1Equal);
            var equalityCheckFail = circle1.Equals(circleUnequal);
            // assert
            Assert.IsTrue(equalityCheckPass);
            Assert.IsFalse(equalityCheckFail);
        }
    }
}
