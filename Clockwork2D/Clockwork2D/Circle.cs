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

        private Transform m_transform;
        public Transform transform
        {
            set
            {
                m_transform = value;
            }

            get
            {
                return m_transform;
            }
        }

        public Circle()
        {
            this.m_radius = 10;
            m_transform = new Transform();
            m_transform.position = new Vector2();
        }

        public Circle(float radius) : this()
        {
            this.m_radius = radius;
        }

        public Circle(float radius, Vector2 position) : this()
        {
            this.m_radius = radius;
            this.m_transform.position = position;
        }

        public override void Render()
        {
            Gl.glPushMatrix();

            //set position

            Gl.glTranslatef((float)m_transform.position.x, (float)m_transform.position.y, 0.0f);

            Gl.glBegin(Gl.GL_POLYGON); ;
            {
                Glu.GLUquadric quadric = Glu.gluNewQuadric();
                Glu.gluQuadricDrawStyle(quadric, Glu.GLU_LINE);
                Glu.gluPartialDisk(quadric, 0, this.m_radius, 32, 32, 0, 360);
            }
            Gl.glPopMatrix();
        }
    }
}
