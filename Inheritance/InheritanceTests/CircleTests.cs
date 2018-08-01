using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestSetNameProperty()
        {
            // arrange
            var expectedCenter = new Inheritance.Point(1, 2);
            var expectedRadius = 0.0;
            var expectedName = "Circle";
            // act 
            var circle = new Inheritance.Circle(expectedCenter, expectedRadius);
            // assert
            Assert.AreEqual(circle.Name, expectedName);
        }
    }
}
