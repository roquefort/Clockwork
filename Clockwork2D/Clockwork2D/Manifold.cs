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
    }
}
