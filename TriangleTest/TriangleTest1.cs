using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace TriangleTest
{
    [TestClass]
    public class TriangleTest1
    {
        [TestMethod]
        public void RightAreaTest()
        {
            RightTriangle triangle=new RightTriangle(3,4,5);

            double area = triangle.Area;

            Assert.AreEqual(6,area,"Right Area");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionTest()
        {
            RightTriangle triangle = new RightTriangle(3, 4, 6);
        }
    }
}
