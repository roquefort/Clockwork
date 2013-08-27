using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork
{
    class Test
    {
        static void Main()
        {
            Vector3 vec3 = new Vector3(1, 1, 1);
            vec3.x = 2;
            vec3.y = 6;
            vec3.z = 12;
            //vec3 *= 5;
            Console.WriteLine(vec3.x + " " + vec3.y + " " + vec3.z);
            //Vector3.Normalize(ref vec3);
            vec3.Normalize();
            Console.WriteLine(vec3.x + " " + vec3.y + " " + vec3.z);

            Vector3 vec3b = new Vector3(3, 2, 5);
            vec3b.Normalize();
            Console.WriteLine(vec3b.x + " " + vec3b.y + " " + vec3b.z);
            Vector3 vec3c = vec3 + vec3b;
            Console.WriteLine(vec3.x + " " + vec3.y + " " + vec3.z);
            Console.ReadLine();
        }
    }
}
