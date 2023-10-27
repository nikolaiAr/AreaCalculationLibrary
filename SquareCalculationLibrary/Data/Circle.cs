using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary.Data
{
    public class Circle : Figure
    {
        private double _radius;

        /// <summary>
        /// The radius of circle
        /// </summary>
        public double Radius
        {
            get { return _radius; }
            private set { _radius = value; }
        }

        public Circle(double radius) : base(Math.PI * radius * radius)
        {
            if (radius < 0.0)
                throw new ArgumentException("Radius is less than zero");

            Radius = radius;
        }
    }
}
