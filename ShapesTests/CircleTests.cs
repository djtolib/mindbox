using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Shapes.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void SquareTest()
        {
            Circle cr = new Circle(2);
            double expected = Math.PI * 2 * 2;
            double actual = cr.Square();
            Assert.AreEqual(expected, actual);
        }
    }
}