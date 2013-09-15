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
        private List<Body> drawBodies;

        public TitleMenuState()
        {
            drawBodies = new List<Body>();

            AddBody();
        }

        public void Update(double elapsedTime)
        {
            drawBodies[0].transform.position.y -= 35.0f * elapsedTime;
        }

        public void Render()
        {
            RenderBody();
        }

        private void GenerateCollisionInformation()
        {
            /*
            for (int i = 0; i < drawCircles.Count; ++i)
            {
                Circle circleA = drawCircles[i];

                for (int j = i + 1; j < drawCircles.Count; ++j)
                {
                }
                
            }
             * */
        }

        private void DrawTriangle()
        {
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor4d(0.0, 1.0, 1.0, 0.5);
            Gl.glVertex2d(-50, 0);
            Gl.glColor4d(0.0, 1.0, 0.5, 0.5);
            Gl.glVertex2d(50, 0);
            Gl.glColor4d(1.0, 0.0, 0.0, 0.5);
            Gl.glVertex2d(0, 50);
            Gl.glEnd();
        }

        public void AddBody()
        {
            Body body = new Body();
            Transform transform = new Transform();
            body.shape = new Circle(15f);
            drawBodies.Add(body);
        }

        public void RenderBody()
        {
            foreach (Body body in drawBodies)
            {
                body.RenderBody();
            }
        }
    }
}
