using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Clockwork2D;

namespace GameLoop.Clockwork2DTests
{
    class TestPair
    {
        Pair pair;

        [SetUp]
        public void GenerateCollisionPairs()
        {
            Body bodyA = new Body();
            Body bodyB = new Body();
            pair = new Pair(bodyA, bodyB); 
        }

        [Test]
        public void GenerateContactPoints()
        {
            pair.GenerateContacts();
        }

        [Test]
        public void SolveCollision()
        {
            Body a = new Body();
            Body b = new Body();

            a.shape = new Circle();
            b.shape = new Circle();

            Pair _pair = new Pair(a, b);

            _pair.SolveCollision();
        }
    }
}
