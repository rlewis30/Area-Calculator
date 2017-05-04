using System;

namespace Areas
{
    public class Square : Shapes
    {
        private double _side;

        public Square(double _side)
        {
            this._side = _side;
        }

        public double side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
            }
        }

        public override double getArea(double a, double b)
        {
            return a * b;
        }
    }

    public class Triangle : Shapes
    {
        private double _base;
        private double _height;

        public Triangle(double _base, double _height)
        {
            this._base = _base;
            this._height = _height;
        }

        public double Base
        {
            get
            {
                return _base; 
            }

            set
            {
                _base = value;
            }
        }

        public double height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public override double getArea(double a, double b)
        {
            return 0.5 * (a * b);
        }
    }

    public class Circle : Shapes
    {
        private double _radius;

        public Circle(double _radius)
        {
            this._radius = _radius;
        }

        public double radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        public override double getArea(double a, double b)
        {
            return Math.PI * (a * b);
        }
    }
}
