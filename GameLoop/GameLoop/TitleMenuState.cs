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
        private List<Circle> drawCircles;
        private List<Body> drawBodies;

        public TitleMenuState()
        {
            drawCircles = new List<Circle>();
            drawBodies = new List<Body>();

            AddCircle();
            AddBody();

            //circle 2
            Transform circle2Transform = new Transform();
            circle2Transform.position = new Vector2(3, 80);
            AddCircle(25.2f, circle2Transform);

            Transform circle3trans = new Transform();
            circle3trans.position = new Vector2(500, 300);
            AddCircle(40.5f, circle3trans);
        }

        public void Update(double elapsedTime)
        {
            drawCircles[2].transform.position.y -= 35.0f * elapsedTime;
        }

        public void Render()
        {
            RenderCircle();
            RenderBody();
        }

        private void GenerateCollisionInformation()
        {
            for (int i = 0; i < drawCircles.Count; ++i)
            {
                Circle circleA = drawCircles[i];

                for (int j = i + 1; j < drawCircles.Count; ++j)
                {
                }
                
            }
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

        //adds a circle to the screen
        public void AddCircle()
        {
            Circle circle = new Circle(20.0f);
            drawCircles.Add(circle);
        }

        //add circle with radius and transform
        public void AddCircle(float radius, Transform transform)
        {
            Circle circle = new Circle(radius);
            circle.transform = transform;
            drawCircles.Add(circle);
        }

        public void AddCircle(float radius, Vector2 position)
        {
            Circle circle = new Circle(radius, position);
            drawCircles.Add(circle);
        }

        //renders all circles to the screen
        public void RenderCircle()
        {
            foreach (Circle circle in drawCircles)
            {
                circle.Render();
            }
        }

        public void AddBody()
        {
            Body body = new Body();
            body.shape = new Circle(15f, new Vector2(20,-20));
            drawBodies.Add(body);
        }

        public void RenderBody()
        {
            foreach (Body body in drawBodies)
            {
                body.shape.Render();
            }
        }
    }
}
