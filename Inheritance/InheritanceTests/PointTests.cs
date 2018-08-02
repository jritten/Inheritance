using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceTests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void TestEquals()
        {
            // arrange
            var pointequal1 = new Inheritance.Point(1, 1);
            var point2 = new Inheritance.Point(1, 1);
            var pointNotEqual = new Inheritance.Point(2, 1);
            // act
            var equalityCheckPass = pointequal1.Equals(point2);
            var equalityCheckFail = point2.Equals(pointNotEqual);
            // assert
            Assert.IsTrue(equalityCheckPass);
            Assert.IsFalse(equalityCheckFail);
        }
    }
}
