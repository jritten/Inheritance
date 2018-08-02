using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceTests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void TestToStringMethod()
        {
            // act 
            var shape = new Inheritance.Shape();
            var stringReturn = shape.ToString();
            // assert
            Assert.AreEqual(stringReturn, null);
        }
    }
}
