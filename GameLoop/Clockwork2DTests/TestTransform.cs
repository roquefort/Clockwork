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
    class TestTransform
    {
        [Test]
        public void CreateTransform()
        {
            Transform transform = new Transform();
        }

        [Test]
        public void SetPosition()
        {
            Transform transform = new Transform();
            Vector2 vec2 = new Vector2(4, 2);
            transform.position = vec2;

            Assert.AreEqual(transform.position, vec2);
        }
    }
}
