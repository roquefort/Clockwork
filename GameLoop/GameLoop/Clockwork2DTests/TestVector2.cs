using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Clockwork2D;

namespace GameLoop
{
    [TestFixture]
    class TestVector2
    {
        [Test]
        public void CreateVector2()
        {
            Vector2 vec2 = new Vector2();
        }

        [TestCase(5,7,3,16)]
        [TestCase(42, 4, 17, 6)]
        public void DistanceTest(double xa, double ya,double xb, double yb)
        {
            Vector2 vec2a = new Vector2(xa, ya);
            Vector2 vec2b = new Vector2(xb, yb);

            double sum = Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2));
            Assert.AreEqual(sum, Vector2.Distance(vec2a, vec2b));
        }

        [TestCase(10, 7)]
        [TestCase(3, 19)]
        public void MagnitudeTestVector2(double x, double y)
        {
            Vector2 vec2 = new Vector2(x, y);
            Assert.AreEqual(Math.Sqrt(x * x + y * y), vec2.Magnitude());
        }

        [TestCase(3,5)]
        public void NormaliseVector2(double x, double y)
        {

            Vector2 vec2 = new Vector2(x, y);
            
            //assuming magnitude works
            double magnitude = vec2.Magnitude();
            Vector2 result = vec2.Normalise();

            Assert.AreEqual(x / magnitude, result.x);
            Assert.AreEqual(y / magnitude, result.y);
        }

        [Test]
        public void MultiplyByScalarTest()
        {
            double x = 3;
            double y = 5;

            Vector2 vec2 = new Vector2(x, y);

            double scalar = 5.8;
            vec2 *= scalar;

            Assert.AreEqual(x * scalar, vec2.x);
            Assert.AreEqual(y * scalar, vec2.y);
        }

        [Test]
        public void DotProduct()
        {
            double xa = 8;
            double ya = 3;

            double xb = 12;
            double yb = 18;

            Vector2 vec2a = new Vector2(xa, ya);
            Vector2 vec2b = new Vector2(xb, yb);

            double sum = vec2a * vec2b;
            Assert.AreEqual(xa * xb + ya * yb, sum);
        }

        [Test]
        public void Sum2Vectors()
        {
            double xa = 8;
            double ya = 3;

            double xb = 12;
            double yb = 18;

            Vector2 vec2a = new Vector2(xa, ya);
            Vector2 vec2b = new Vector2(xb, yb);

            Vector2 sum = vec2a + vec2b;
            Assert.AreEqual(xa + xb, sum.x);
            Assert.AreEqual(ya + yb, sum.y);
        }

        [Test]
        public void Subtract2Vectors()
        {
            double xa = 8;
            double ya = 3;

            double xb = 12;
            double yb = 18;

            Vector2 vec2a = new Vector2(xa, ya);
            Vector2 vec2b = new Vector2(xb, yb);

            Vector2 sum = vec2a - vec2b;
            Assert.AreEqual(xa - xb, sum.x);
            Assert.AreEqual(ya - yb, sum.y);
        }

        [Test]
        public void DivideByScalar()
        {
            double x = 3;
            double y = 5;

            Vector2 vec2 = new Vector2(x, y);

            double scalar = 5.8;
            vec2 /= scalar;

            Assert.AreEqual(x / scalar, vec2.x);
            Assert.AreEqual(y / scalar, vec2.y);
        }
    }
}
