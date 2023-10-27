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
    public class CircleTest
    {
        [Test]
        public void GetArea_CircleAreaHasValue()
        {
            double r = 3.0;

            Circle circle = new Circle(r);

            Assert.That(circle.GetArea, Is.EqualTo(Math.PI * r * r));
        }

        [Test]
        public void GetArea_CircleRadiusIsZero()
        {
            Circle circle = new Circle(0.0);

            Assert.That(circle.GetArea, Is.EqualTo(0.0));
        }

        [Test]
        public void GetArea_CircleRadiusIsLessZero()
        {
            Assert.Throws<ArgumentException>(() =>  new Circle(-3.0));
        }

        [Test]
        public void Radius_HasValue()
        {
            double r = 4.0;

            Circle circle = new Circle(r);

            Assert.That(circle.Radius, Is.EqualTo(r));
        }
    }
}
