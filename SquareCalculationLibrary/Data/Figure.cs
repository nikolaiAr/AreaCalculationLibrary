using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary.Data
{
    public class Figure 
    {
        private double _area;

        public double GetArea => _area;

        public Figure (double area) => this._area = area;

    }
}
