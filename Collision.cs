using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork2D
{
    class Collision
    {
        //are bounding boxes colliding
        private bool AABBvsAABB(AABB a, AABB b)
        {
            if (a.max.x < b.min.x || a.min.x > b.max.y)
                return false;
            if (a.max.y < b.min.y || a.min.y > b.max.y)
                return false;

            return true;
        }

        private void CircleVsCircle(Manifold m, Body a, Body b)
        {
            Vector2 distance = b.transform.position - a.transform.position;
            Circle circleColA = a.shape as Circle;
            Circle circleColB = b.shape as Circle;

            float radius = circleColA.radius + circleColB.radius;

            //Math.Pow((a.position.x + b.position.x), 2) + Math.Pow((a.position.y + b.position.y), 2)
            if (distance.LengthSquared() > radius * radius)
                return;

            double aDistance = distance.Length();
            //m->contact_count = 1;
            m.contact_count = 1;

            if (aDistance == 0)
            {
                //distance is difference between radius and distance
                m.penetration = radius - aDistance;
                m.normal = new Vector2(1, 0);
                m.contacts[0] = a.transform.position;
                //utilise aDistance 
                //points from A to B and is a unit vector
            }
            else
            {
                m.penetration = radius - aDistance;
                m.normal = distance / aDistance; //faster then normalise
                //vec2 to double
                m.contacts[0] = m.normal * circleColA.radius + a.transform.position;
            }

            //Circles have collided
            //compute manifold
            //float aDistance = distance


            //float sumRadi = a.radius + b.radius;
            //sumRadi *= sumRadi; //instead of sqrt in distance since sqrt is very expensive
            //return sumRadi < Math.Pow((a.position.x + b.position.x), 2) + Math.Pow((a.position.y + b.position.y), 2);
            return;
        }

        private double Distance(Vector2 a, Vector2 b)
        {
            return Math.Sqrt(Math.Pow((a.x - b.x), 2) + Math.Pow((a.y - b.y), 2));
        }

        //change to body later
        private void ResolveCollision(Body a, Body b)
        {
            //calc velocity
            Vector2 relativeVel = b.velocity - a.velocity;
            Vector2 collisionNormal = b.transform.position - a.transform.position;
            double velAlongNormal = relativeVel * collisionNormal;

            //do not resolve if vel's are seperating
            if (velAlongNormal > 0)
                return;

            //calculate restitution
            double restitution = Math.Min(a.restitution, b.restitution);

            //calculate impulse scalar
            double impulseScalar = -(1 + restitution) * velAlongNormal;
            impulseScalar /= 1 / a.massData.mass + 1 / b.massData.mass;

            //apply impulse
            Vector2 impulse = collisionNormal * impulseScalar;
            a.velocity -= 1 / a.massData.mass * impulse;
            b.velocity += 1 / b.massData.mass * impulse;
        }
    }
}
