using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork2D
{
    public class Body
    {
        public Shape shape;
        public Transform transform;
        public Material material;
        public MassData massData;
        public Vector2 velocity;
        public Vector2 force;
        public double gravityScale;
        public double restitution;
        //shape center?

        public Body()
        {
        }

        public Body(Shape shape, Transform transform, MassData massData)
        {
            this.shape = shape;
            this.transform = transform;
            this.massData = massData;
            this.velocity = new Vector2(0, 0);
        }
    }
}
