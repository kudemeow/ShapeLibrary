using NUnit.Framework.Legacy;

namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            ClassicAssert.AreEqual(Math.PI * 25, circle.CalculateArea(), 1e-10);
        }

        [Test]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            ClassicAssert.AreEqual(6, triangle.CalculateArea(), 1e-10);
        }

        [Test]
        public void RightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            ClassicAssert.IsTrue(triangle.IsRightTriangle());
        }

        [Test]
        public void NonRightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 6);
            ClassicAssert.IsFalse(triangle.IsRightTriangle());
        }

        [Test]
        public void InvalidCircleTest()
        {
            ClassicAssert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Test]
        public void InvalidTriangleTest()
        {
            ClassicAssert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }
    }
}