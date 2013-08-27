using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork
{
    public class Vector3
    {
        public double x;
        public double y;
        public double z;

        public Vector3()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //inverts the vector
        public void Invert()
        {
            x = -x;
            y = -y;
            z = -z;
        }

        //gets the magnitude of this vector
        public double Magnitude()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        //gets the square magnitude of this vector
        public double SquareMagnitude()
        {
            return (x * x + y * y + z * z);
        }

        //multiply vector by scalar
        /*
        public void Multiply(double scale)
        {
            x *= scale;
            y *= scale;
            z *= scale;
        }
        */  
         
        //multiply by scalar product
        public static Vector3 operator * (Vector3 vec3, double value)
        {
            vec3.x *= value;
            vec3.y *= value;
            vec3.z *= value;
            return vec3;
        }

        
        //scalar product of 2 vectors
        public static double operator * (Vector3 vec3a, Vector3 vec3b)
        {
            return vec3a.x * vec3b.x + vec3a.y * vec3b.y + vec3a.z * vec3b.z;
        }

        //adds two vectors
        public static Vector3 operator + (Vector3 vec3a, Vector3 vec3b)
        {
            vec3a.x += vec3b.x;
            vec3a.y += vec3b.y;
            vec3a.z += vec3b.z;
            return vec3a;
        }

        //subtracts two vectors
        public static Vector3 operator - (Vector3 vec3a, Vector3 vec3b)
        {
            vec3a.x -= vec3b.x;
            vec3a.y -= vec3b.y;
            vec3a.z -= vec3b.z;
            return vec3a;
        }

        public static Vector3 operator %(Vector3 vec3a, Vector3 vec3b)
        {
            return new Vector3(vec3a.y * vec3b.z - vec3a.z * vec3b.y,
                vec3a.z * vec3b.x - vec3a.x * vec3b.z,
                vec3a.x * vec3b.y - vec3a.y * vec3b.x);
        }

        //adds a vector scaled by amount
        public void AddScaledVector(Vector3 vec3, double scale)
        {
            x += vec3.x * scale;
            y += vec3.y * scale;
            z += vec3.z * scale;
        }

        //component product (the least useful, no real application)
        public void ComponentProduct(Vector3 vec3)
        {
            x *= vec3.x;
            y *= vec3.y;
            z *= vec3.z;
        }

        //calculates and returns the vector product of 
        //this vector with the given vector
        public Vector3 VectorProduct(Vector3 vec3)
        {
            return new Vector3(y * vec3.z - z * vec3.y, 
                z * vec3.x - x * vec3.z,
                x * vec3.y - y * vec3.x);
        }
        
        /*
        scalar product, same as * but long handed version
        scalar product is faster then vector
        It relates the scalar product to the length
        of the two vectors and the angle between them
         * */
        public double ScalarProduct(Vector3 vec3)
        {
            return x * vec3.x + y * vec3.y + z * vec3.z;
        }

        /*
        public static Vector3 Normalize(ref Vector3 vec3)
        {
            double mag = vec3.Magnitude();
            if (mag > 0)
                return vec3 *= ((double)1) / mag;
            return vec3;

        }
         **/

        /*
        public static Vector3 Normalize(this Vector3 vec3)
        {
            double mag = vec3.Magnitude();
            if (mag > 0)
                return vec3 *= ((double)1) / mag;
            return 0;
        }
         * */
    }
}
