using NUnit.Framework;
using Sqaures.Exceptions;
using Sqaures.Models;

namespace SquaresTests
{
    class TriangleTest
    {
        [Test]
        public void IsTriangle_1_2_3_Not_Valid()
        {
            Assert.Throws<FigureNotValidException>(() => new Triangle(1, 2, 3));
        }

        [Test]
        public void IsTriangle_10_7_5_Is_Valid()
        {
            Assert.DoesNotThrow(() => new Triangle(10, 7, 5));
        }

        [Test]
        public void IsTriangle_4_5_3_Right()
        {
            Assert.IsTrue(new Triangle(4, 5, 3).IsRight);
        }

        [Test]
        public void IsTriangle_10_7_5_Not_Right()
        {
            Assert.IsFalse(new Triangle(4, 5, 6).IsRight);
        }

        [Test]
        public void IsTriangle_10_7_5_Area_With_Accuracy_3_Is_Valid()
        {
            Assert.AreEqual(16.248, new Triangle(10, 7, 5).CalculateArea(), 0.1 * 3);
        }
    }
}
