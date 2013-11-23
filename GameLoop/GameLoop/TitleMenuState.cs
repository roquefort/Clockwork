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
        private List<Pair> contactingBodies;

        public TitleMenuState()
        {
            //initalise lists
            drawBodies = new List<Body>();
            contactingBodies = new List<Pair>();

            //Add bodies
            AddBody(new Transform(new Vector2(-200, -30)), 60f);
            AddBody(new Transform(new Vector2(-200, 200)), 60f);
            AddBody(new Transform(new Vector2(200, 200)), 40f);

            //create collision pairs
            CreatePairs();
        }

        public void Update(double elapsedTime)
        {
            CheckCollisionPairs();
            drawBodies[1].transform.position.y -= 20.0f * elapsedTime;
            Console.WriteLine(elapsedTime);
        }

        public void Render()
        {
            //m_drawBodies[0].shape.Render(new Transform(new Vector2(0, 0)));

            //TODO causing render error
            RenderBody();
        }

        //add a circle to the scene
        public void AddBody()
        {
            Body body = new Body();
            body.shape = new Circle(15f);
            drawBodies.Add(body);
        }

        //add body at location
        public void AddBody(Transform _transform)
        {
            Body body = new Body();
            body.shape = new Circle();
            body.transform = _transform;
            drawBodies.Add(body);
        }

        public void AddBody(Transform _transform, float _radius)
        {
            Body body = new Body();
            body.shape = new Circle(_radius);
            body.transform = _transform;
            drawBodies.Add(body);
        }

        //render all objects in the scene
        public void RenderBody()
        {
            foreach (Body body in drawBodies)
            {
                body.RenderBody();
            }
        }

        //creates pairs between possible collision objects
        public void CreatePairs()
        {
            for (int i = 0; i < drawBodies.Count; i++)
            {
                Body bodyA = drawBodies[i];
                for (int j = i + 1; j < drawBodies.Count; j++)
                {
                    Body bodyB = drawBodies[j];
                    //check if object is moving, if it isn't ignore it
                    Pair pairs = new Pair(bodyA, bodyB);
                    contactingBodies.Add(pairs);
                }
            }
        }

        //detect collision between objects on the scene
        public void DetectCollisions()
        {
            for (int i = 0; i < contactingBodies.Count; ++i)
            {
                //calculate collisions between the pairs
                //contactingBodies[i]
            }
        }

        //prints out the pairs of collisions that could occur
        private void DisplayCollisionPairs()
        {
            foreach (Pair pair in contactingBodies)
            {
                Console.WriteLine(pair);
            }
        }

        //checks collisions between pairs
        private void CheckCollisionPairs()
        {
            foreach (Pair pair in contactingBodies)
            {
                pair.SolveCollision();
            }
        }
    }
}
