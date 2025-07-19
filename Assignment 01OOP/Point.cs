using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01OOP
{
    internal struct Point
    {

        private double x;
        private double y;

        public double X
        {
            set { x = value; }
            get { return x; }   
        }

        public double Y
        {
            set { y = value; }
            get { return y; }    
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
