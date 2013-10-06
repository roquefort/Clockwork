using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace Clockwork2D
{
    public class Circle : Shape
    {
        private float m_radius;
        public float Radius
        {
            get 
            { 
                return m_radius; 
            }
        }

        public Circle()
        {
            this.m_radius = 10;
        }

        public Circle(float radius) : this()
        {
            this.m_radius = radius;
        }

        public override void Render(Transform transform)
        {
            Gl.glPushMatrix();

            //set position

            Gl.glTranslatef((float)transform.position.x, (float)transform.position.y, 0.0f);

            Gl.glBegin(Gl.GL_POLYGON);
            {
                Glu.GLUquadric quadric = Glu.gluNewQuadric();
                Glu.gluQuadricDrawStyle(quadric, Glu.GLU_LINE);
                Glu.gluPartialDisk(quadric, 0, this.m_radius, 32, 32, 0, 360);
            }
            Gl.glPopMatrix();
        }
    }
}
