using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork2D
{
    struct MassData
    {
        public double mass;
        public double inv_mass;

        //for rotations
        float inertia;
        float inverse_inertia;
    }
}
