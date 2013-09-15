using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork2D
{
    public class Vector2
    {
        private double _x;
        public double x
        {
            get { return _x; }
            set { _x = value; }
        }

        private double _y;
        public double y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Vector2()
        {
            this._x = 0;
            this._y = 0;
        }

        public Vector2(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        //distance between 2 vectors
        public static double Distance(Vector2 a, Vector2 b)
        {
            return Math.Sqrt(Math.Pow((a.x - b.x), 2) + Math.Pow((a.y - b.y), 2));
        }

        //length of the vector
        public double Magnitude()
        {
            return Math.Pow(_x * _x + _y * _y, 0.5);
        }

        //square magnitude (for speedy calculations)
        public double SquareMagnitude()
        {
            return (_x * _x + _y * _y);
        }

        //gets the vetor angle
        public double GetAngle()
        {
            //Atan2 takes in (y,x) not (x,y)
            return Math.Atan2(_y, _x);
        }

        //set the angle of the vector
        public void SetAngle(double angle)
        {
            _x = Math.Cos(angle);
            _y = Math.Sin(angle);
        }

        //also known as unit vector, resets magnitude
        //scale to 1
        public Vector2 Normalise()
        {
            double _magnitude = Magnitude();
            return new Vector2(_x / _magnitude, _y / _magnitude);
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", _x, _y);
        }

        #region operatorOverrides

        //multiply by scalar
        public static Vector2 operator *(Vector2 vec3, double value)
        {
            vec3.x *= value;
            vec3.y *= value;
            return vec3;
        }

        public static Vector2 operator *(double value, Vector2 vec3)
        {
            vec3.x *= value;
            vec3.y *= value;
            return vec3;
        }

        //product of 2 vectors
        //the value is the cosine of the angle between the two input vectors, 
        //multiplied by the lengths of those vectors.
        //can easily calculate the cosine of the angle
        //by either, making sure that your two vectors are both of lenth 1,
        //or dividing the dot product by the lengths
        //values range from 1 to -1
        //1 means pointing in the same direction
        //-1 means pointing in the opposite direction
        //0 means perpendicular
        //how similar vecotrs are

        //aka dot product
        public static double operator *(Vector2 vec2a, Vector2 vec2b)
        {
            return (vec2a.x * vec2b.x + vec2a.y * vec2b.y);
        }

        //adding 2 vectors
        public static Vector2 operator +(Vector2 vec2a, Vector2 vec2b)
        {
            vec2a.x += vec2b.x;
            vec2a.y += vec2b.y;
            return vec2a;
        }

        //subtracting 2 vectors
        public static Vector2 operator -(Vector2 vec2a, Vector2 vec2b)
        {
            vec2a.x -= vec2b.x;
            vec2a.y -= vec2b.y;
            return vec2a;
        }

        public static Vector2 operator /(Vector2 vec2a, double value)
        {
            vec2a.x /= value;
            vec2a.y /= value;
            return vec2a;
        }

        #endregion 


    }
}
