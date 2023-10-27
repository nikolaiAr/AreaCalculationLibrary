using AreaCalculationLibrary.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void GetArea_TriangleAreaHasValue()
        {
            double a = 2.0, b = 3.0, c = 4.0;
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Triangle triangle = new Triangle(a, b, c);

            Assert.That(triangle.GetArea, Is.EqualTo(s));
        }

        [Test]
        public void GetArea_TriangleSideIsZero()
        {
            double a = 2.0, b = 0.0, c = 4.0;
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void GetArea_TriangleSideIsLessZero()
        {
            double a = 2.0, b = -3.0, c = 4.0;
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void GetArea_TriangleCheck()
        {
            double a = 2.0, b = 3.0, c = 5.0;
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void CalculateArea_HasValue()
        {
            double a = 2.0, b = 3.0, c = 4.0;
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Assert.That(Triangle.CalculateArea(a, b, c), Is.EqualTo(s));
        }

        [Test]
        public void CalculateArea_HasValueForRightTriangle()
        {
            double a = 2.1, b = 2.8, c = 3.5;
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Assert.That(Triangle.CalculateArea(a, b, c), Is.EqualTo(Math.Round(s, 2)));
        }

        [Test]
        public void IsRightTriangle_TriangleIsRightCheck()
        {
            double a = 2.1, b = 2.8, c = 3.5;

            Assert.That(Triangle.IsRightTriangle(a, b, c), Is.EqualTo(true));
        }

        [Test]
        public void IsRightTriangle_TriangleIsNotRightCheck()
        {
            double a = 2.0, b = 3.0, c = 5.0;

            Assert.That(Triangle.IsRightTriangle(a, b, c), Is.EqualTo(false));
        }

        [Test]
        public void SideA_HasValue()
        {
            double a = 4.0, b = 3.0, c = 5.0;

            Triangle triangle = new Triangle(a, b, c);

            Assert.That(triangle.SideA, Is.EqualTo(b));
        }

        [Test]
        public void SideB_HasValue()
        {
            double a = 4.0, b = 3.0, c = 5.0;

            Triangle triangle = new Triangle(a, b, c);

            Assert.That(triangle.SideB, Is.EqualTo(a));
        }

        [Test]
        public void SideC_HasValue()
        {
            double a = 4.0, b = 3.0, c = 5.0;

            Triangle triangle = new Triangle(a, b, c);

            Assert.That(triangle.SideC, Is.EqualTo(c));
        }

        [Test]
        public void Perimeter_HasValue()
        {
            double a = 4.0, b = 3.0, c = 5.0;

            Triangle triangle = new Triangle(a, b, c);

            Assert.That(triangle.Perimeter, Is.EqualTo(a+b+c));
        }
    }
}
