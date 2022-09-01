using NUnit.Framework;
using Sqaures.Models;
using System;

namespace SquaresTests
{
    public class CircleTest
    {
        [Test]
        public void Circle_Area_With_Radius_9_and_Accuracy_3_Is_Valid()
        {
            Assert.AreEqual(254.469, new Circle(9).CalculateArea(), 0.1 * 3);
        }

        [Test]
        public void Circle_Area_With_Radius_1_Is_Pi()
        {
            Assert.IsTrue(new Circle(1).CalculateArea() == Math.PI);
        }
    }
}