using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary.Data
{
    public class Triangle : Figure
    {
        #region Properties
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _perimeter;
        private double[] _sides;

        /// <summary>
        /// The first side of triangle
        /// </summary>
        public double SideA
        {
            get { return _sideA; }
            private set { _sideA = value; }
        }

        /// <summary>
        /// The second side of triangle
        /// </summary>
        public double SideB
        {
            get { return _sideB; }
            private set { _sideB = value; }
        }

        /// <summary>
        /// The biggest side of triangle
        /// </summary>
        public double SideC
        {
            get { return _sideC; }
            private set { _sideC = value; }
        }

        /// <summary>
        /// The Perimeter of triangle
        /// </summary>
        public double Perimeter
        {
            get { return _perimeter; }
            private set { _perimeter = value; }
        }

        #endregion

        #region Constructor
        public Triangle(double a, double b, double c) : base(CalculateArea(a, b, c))
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Sides is less than zero or zero");
            else if (a + b <= c || b + c <= a || a + c <= b)
                throw new ArgumentException("This is not triangle");

            _sides = new double[3] { a, b, c };
            Array.Sort(_sides);

            SideA = _sides[0];
            SideB = _sides[1];
            SideC = _sides[2];

            Perimeter = SideA + SideB + SideC;
        }

        #endregion

        internal static double CalculateArea (double a, double b, double c)
        {
            if (IsRightTriangle(a, b, c)) 
            {
                var sides = new double[3] { a, b, c };
                Array.Sort(sides);

                return (sides[0] * sides[1]) / 2;
            }
            else
            {
                var p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }

        }

        internal static bool IsRightTriangle(double a, double b, double c)
        {
            var sides = new double[3] { a, b, c };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
