using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork
{
    static class Vector3Extensions
    {
        public static Vector3 Normalize(this Vector3 vec3)
        {
            double mag = vec3.Magnitude();
            if (mag > 0)
                return vec3 *= ((double) 1) / mag;
            //unable to normalize
            return vec3;
        }
    }
}
