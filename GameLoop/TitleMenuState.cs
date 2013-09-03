using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using Clockwork2D;

namespace GameLoop
{
    class TitleMenuState : IGameObject
    {
        double _currentRotation = 0;
        Sphere s1;
        List<IGameObject> drawObjects = new List<IGameObject>();
        //Sphere s1;

        public TitleMenuState()
        {
            //s1 = new Sphere(50, 32, 32);
            drawObjects.Add(new Sphere(50, 32, 32,  new Vector2(-400, 0), DrawStyle.GLU_LINE));
            drawObjects.Add(new Sphere(30, 32, 32, new Vector2(100, 0), DrawStyle.GLU_LINE));    
        }

        public void Update(double elapsedTime)
        {
            foreach (IGameObject drawable in drawObjects)
            {
                drawable.Update(elapsedTime);
            }
            s1 = drawObjects[0] as Sphere;
            s1.transform.position.x += 100.0f * elapsedTime;

        }

        public void Render()
        {
            //Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glPointSize(5.0f);

            drawObjects[0].Render();
            drawObjects[1].Render();

            Gl.glFinish();
        }

        private void DrawTriangle()
        {
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor4d(0.0, 1.0, 0.0, 0.5);
            Gl.glVertex2d(-50, 0);
            Gl.glVertex2d(50, 0);
            Gl.glVertex2d(0, 50);
            Gl.glEnd();
        }
    }

    /*
Gl.glColor4d(1.0, 0.0, 0.0, 0.5);
Gl.glVertex3d(-50, 0, 0);
Gl.glColor3d(0.0, 1.0, 0.0);
Gl.glVertex3d(50, 0, 0);
Gl.glColor3d(0.0, 0.0, 1.0);
Gl.glVertex3d(0, 50, 0);
*/
    //Gl.glTranslatef(200, 0, 0);
    //Gl.glTranslatef(20, 10000, 0);
}
