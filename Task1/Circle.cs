using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Circle
    {
        static public double GetLength(double r)
        { 
            return 2 * Math.PI * r;
        }
        static public double GetArea(double r)
        {
            return Math.PI * r*r;
        }
        static public bool PointBelongs(double r, double x, double y)
        {
            double l = Math.Sqrt(x * x + y * y);
            if (l<=r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
