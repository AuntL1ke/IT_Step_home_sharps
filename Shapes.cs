using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp20
{
    internal abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    internal class Triangle:Shape
    {
        private double a, b, c;
        public Triangle(double s1, double s2, double s3)
        {
            a = s1;
            b = s2;
            c = s3;
        }
        public override double GetArea()
        {
            if(a>0&&b>0&&c>0)
            {
                double p = (a + b + c) / 2;
                double s = (p * (p - a) * (p - b) * (p - c));
                return Math.Pow(s, 0.5);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public override double GetPerimeter()
        {
            if (a > 0 && b > 0 && c > 0)
            {
                return (a + b + c);
            }
            else { throw new NotImplementedException(); }
            
        }
    }

    internal class Square:Shape
    {
        private double a;
        public Square(double s)
        {
            a = s;
        }

        public override double GetArea()
        {
            if(a>0)
            {
                return a * a;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public override double GetPerimeter()
        {
            if (a > 0)
            {

                return a * 4;
            }
            else { throw new NotImplementedException(); }
        }
    }
    internal class Rect : Shape
    {
        private double a, b;

        public Rect(double s1, double s2) {
            a = s1;
            b = s2;
        }
        public override double GetArea()
        {
            if((a > 0) && (b > 0))
            {
                return (a * b);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public override double GetPerimeter()
        {
            if (a > 0 && b > 0)
            {
                return (a * b) * 2;
            }
            else { throw new NotImplementedException(); }
        }

    }
    internal class Romb:Shape
    {
        private double a, b, c, d;
        public Romb(double s1, double s2, double s3, double s4) {
            a = s1;
            b = s2;
            c = s3;
            d = s4;
        }

        public override double GetArea()
        {
            if (a > 0 && b > 0 && c > 0 && d > 0)
            {
                double d1 = 2 * Math.Pow(a * a + b * b, 0.5);
                double d2 = 2 * Math.Pow(c * c + d * d, 0.5);
                return (d1 + d2) / 2;
            }
            else { throw new NotImplementedException(); }
        }
        public override double GetPerimeter()
        {
            if (a > 0 && b > 0 && c > 0 && d > 0)
            {
                return a + b + c + d;
            }
            else { throw new NotImplementedException(); }
        }
    }

    internal class Paralel:Shape
    {
        private double a, b, h;
        public Paralel(double s1, double s2, double h1) {
            a = s1;
            b = s2;
            h = h1;
        }
        public override double GetArea()
        {
            if (a > 0 && b > 0 && h > 0)
            {
                return b * h;
            }
            else { throw new NotImplementedException(); }
        }

        public override double GetPerimeter()
        {
            if(a > 0 && b > 0 && h > 0)
            {
                return 2 * (a + b);
            }
            else { throw new NotImplementedException(); }
        }
    }

    internal class Traps:Shape
    {
        private double a, b, c, d, h;
        public Traps(double s1, double s2, double s3, double s4, double h1)
        {
            a = s1;
            b = s2;
            c = s3;
            d = s4;
            h = h1;

        }
        public override double GetArea()
        {
            if(a > 0 && b > 0 && c > 0 && d > 0 && h > 0)
            {
                return (a + b) * h;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public override double GetPerimeter() {
            if (a > 0 && b > 0 && c > 0 && d > 0 && h > 0)
            {
                return a + b + c + d;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class Circle : Shape
    {
        private double r;
        public Circle(double R)
        {
            r = R;
        }
        public override double GetArea()
        {
            if (r > 0)
            {
                return 3.14 * r * r;
            }
            else { throw new NotImplementedException(); }
        }
        public override double GetPerimeter()
        {
            if(r>0)
            {
                return 2 * 3.14 * r;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class Elips:Shape
    {
        private double a,b;
        public Elips(double r1, double r2)
        {
            a = r1;
            b = r2;
        }
        public override double GetArea()
        {
            if (a > 0 && b > 0)
            {
                return 3.14 * a * b;
            }
            else { throw new NotImplementedException(); }
        }
        public override double GetPerimeter()
        {
            if (a > 0 && b > 0)
            {
                return 3.14 * Math.Pow(2 * (a * a + b * b), 2) * (1 - 1 / Math.Pow(2, 10));
            }
            else { throw new NotImplementedException(); }
        }

    }

    internal class MixShape:Shape
    {
        private Shape[] shapes;
        public MixShape(params Shape[] input)
        {
            shapes = input;
        }
        public override double GetArea()
        {
            double total = 0;
            foreach (var item in shapes)
            {
                total += item.GetArea();
            }
            return total;
        }
        public override double GetPerimeter()
        {
            double total = 0;
            foreach (var item in shapes)
            {
                total += item.GetPerimeter();
            }
            return total;   
        }
    }
}
