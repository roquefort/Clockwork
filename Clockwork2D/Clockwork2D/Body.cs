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

        public Body()
        {
            this.transform = new Transform();
            this.transform.position = new Vector2();
            this.velocity = new Vector2();
        }

        public Body(Shape shape) : this()
        {
            this.shape = shape;
        }

        public Body(Shape shape, Transform transform, MassData massData) : this()
        {
            this.shape = shape;
            this.transform = transform;
            this.massData = massData;
        }
        public void RenderBody()
        {
            shape.Render(transform);
        }
    }
}
