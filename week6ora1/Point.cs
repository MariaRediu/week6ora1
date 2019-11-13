using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6ora1
{
    public class Point
    {
        double x;
        double y;

        public Point(double a, double b)
        {
            this.x = a;
            this.y = b;

        }
        public static Point operator + (Point p1,Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);

        }
        public static Point operator ++(Point p1)
        {
            return new Point(p1.x+1, p1.y+1);

        }
        public override string ToString()
        {
            return $"Pct: x {this.x}, y: {this.y}";
        }

    }

}
