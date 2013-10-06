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
    class TransformTest
    {
        Transform transform;

        [SetUp]
        public void SetUp()
        {
            transform = new Transform();
        }

        [Test]
        public void GetTransform()
        {
            Assert.IsNotNull(transform);
        }

        [Test]
        public void SetTransform()
        {
            Transform newTransform = new Transform();
            transform = newTransform;
            Assert.AreEqual(transform, newTransform);
        }
    }
}
