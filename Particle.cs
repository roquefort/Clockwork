using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Laws of motions
 * 
 * 1. An object continues with a constant velocity unless a force acts upon it
 * 2. A force acting on an object produces acceleration that is proportional to the objects mass
 * */

namespace Clockwork
{
    class Particle
    {
        //linear position in world space
        Vector3 position;

        //linear velocity in world space
        Vector3 velocity;

        //acceleration of the particle, can
        //be used to set acceleration due to
        //gravity. Its primary use or any other
        //constant acceleration
        Vector3 acceleration;

        //holds the amount of damping applied
        //to linear motion, damping is required
        //to remove energy added through
        //numerical instability in the integrator
        double damping;

        //more useful to hold the inverse mass
        //because integration is simpler and because in real
        //time sumulation it is easier to have objects with
        //infinite mass(immovable) then objects with zero mass
        //completely unstable in numerical situations
        double inverseMass;

        Vector3 forceAccum;

        /*integrates the particle forward in time by the given amount
         * uses newton-euler integration method, which is a linear 
         * approximation of the correct integral. may be innacurate in some cases 
         * */
        void Integrate(float duration)
        {
            if (duration > 0.0)
            {
                //update linear position
                position.AddScaledVector(velocity, duration);

                //work out the accelertation from the force
                //Vector3 forceAccum = new Vector3(0,0,0);
                Vector3 resultingAcc = acceleration;
                resultingAcc.AddScaledVector(forceAccum, inverseMass);

                //update linear velocity from the acceleration
                velocity.AddScaledVector(resultingAcc, duration);

                //impose drag
                //remove if wanting to simulate more particles
                velocity *= Math.Pow(damping, duration);
            }
        }
    }
}
