using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void SquareTest()
        {
            double expected = 6;
            Triangle tr = new Triangle(3, 4, 5);
            double actual = tr.Square();
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod()]
        public void isRigthTest()
        {
            bool expected = true;
            Triangle tr = new Triangle(3, 4, 5);
            bool actual = tr.isRight();
            Assert.AreEqual(expected, actual);
        }
    }
}