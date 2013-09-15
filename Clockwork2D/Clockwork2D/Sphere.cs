using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace Clockwork2D
{
    public enum DrawStyle
    {
        GLU_FILL = 100012,
        GLU_LINE = 100011
    }

    public class Sphere : Shape
    {
        private float radius;
        private int slices;
        private int stacks;

        private DrawStyle drawStyle;

        public Sphere(float radius, int slices, int stacks, DrawStyle drawStyle = DrawStyle.GLU_FILL)
        {
            this.radius = radius;
            this.slices = slices;
            this.stacks = stacks;
            this.drawStyle = drawStyle;

            //this.transform = new Transform();
            //transform.position = position;
        }

        public void Update(double elapsedTime)
        {
            //Console.WriteLine("This position is: " + this.transform.position);  
        }

        public void Render()
        {
            Gl.glPushMatrix();
            Gl.glColor3d(0.0f, 1.0f, 0.0f);
            //object location
            //Gl.glTranslatef((float)transform.position.x, (float)transform.position.y, 0f);

            Gl.glBegin(Gl.GL_POLYGON);
            {
                Glu.GLUquadric gQ;
                gQ = Glu.gluNewQuadric();
                Glu.gluQuadricDrawStyle(gQ, (int)drawStyle);
                Glu.gluQuadricTexture(gQ, Glu.GLU_TRUE);
                Glu.gluSphere(gQ, radius, slices, stacks);
            }

            Gl.glPopMatrix();
        }
    }
}
