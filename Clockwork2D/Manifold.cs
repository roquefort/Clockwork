using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork2D
{
    public class Manifold
    {
        public Body A;
        public Body B;
        public double penetration; //depth of penetration
        public Vector2 normal; //from A to B
        public Vector2[] contacts; //points of contact during collision
        public double restitution;
        public int contact_count;
    }
}
