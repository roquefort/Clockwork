using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Clockwork2D;

namespace GameLoop.Clockwork2DTests
{
    [TestFixture]
    class TestShape
    {
        [Test]
        public void SetUp()
        {
            Circle circle = new Circle(4.2f);
        }

        [Test]
        public void GetRadius()
        {
            Circle circle = new Circle(3.2f);
            Assert.AreEqual(3.2f, circle.Radius);
        }

        [Test]
        public void SetPosition()
        {
            Circle circle = new Circle(4.5f);
            Vector2 position = new Vector2();
            circle.transform.position = position;
        }
    }
}
