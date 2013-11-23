using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork2D
{
    public class Pair
    {
        private Body m_bodyA;
        public Body bodyA
        {
            get 
            { 
                return m_bodyA; 
            }
        }

        private Body m_bodyB;
        public Body bodyB
        {
            get
            {
                return m_bodyB;
            }
        }

        public double penetration; //depth of penetration
        public Vector2 normal; //from A to B
        public Vector2[] contacts; //points of contact during collision
        public double restitution;
        public int contact_count;

        public Pair(Body bodyA, Body bodyB)
        {
            this.m_bodyA = bodyA;
            this.m_bodyB = bodyB;
        }

        public void GenerateContacts()
        {

        }

        public void SolveCollision()
        {
            Console.WriteLine("Running SolveCollision()");
            //for the case of a circle
            Circle circleA = m_bodyA.shape as Circle;
            Circle circleB = m_bodyB.shape as Circle;

            float addedRadi = circleA.Radius + circleB.Radius;

            double distance = Vector2.Distance(m_bodyA.transform.position, m_bodyB.transform.position);
            double collision = distance - addedRadi;
            Console.WriteLine(string.Format("Added Radi is {0} and distance is {1}", addedRadi, distance));

            if (collision < 0)
            {
                //resolve collsions
                //Console.WriteLine(string.Format("collision occuring between Body {0} and Body {1} \n", m_bodyA.id, m_bodyB.id)); 
            }
            else if (collision == 0)
            {
                //on collision
                //Console.WriteLine(string.Format("Body {0} and Body {1} have just collided \n", m_bodyA.id, m_bodyB.id)); 
            }
            else
            {
                //no collision and skip
                //Console.WriteLine(string.Format("There is no collisions between Body {0} and Body {1} \n", m_bodyA.id, m_bodyB.id)); 
            }

            #region psuedcodeForCollision
            //get the radi of each circle
            //determine the distance between each circles
            //subtract the added radi from the distance
            //if answer is negative then penetration has happened
            //if positive, no penetration
            //if 0 contact is exactly on
            #endregion
        }

        public override string ToString()
        {
            return string.Format("Body A is {0} and Body B is {1}", this.m_bodyA, this.m_bodyB);
        }
    }
}
