using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using Clockwork2D;
using NUnit.Framework;

namespace GameLoop.GameLoopTests
{
    [TestFixture]
    class TitleMenuStateTest
    {
        TitleMenuState titleMenuState;

        [SetUp]
        public void Init()
        {
            titleMenuState = new TitleMenuState();
        }

        [Test]
        public void AddCircleToScene()
        {
            titleMenuState.AddCircle();
        }

        [Test]
        public void AddCircleWithRadiusAndTransformToScene()
        {
            float radius = 25.5f;
            Transform transform = new Transform();
            transform.position = new Vector2(4, 20);
            titleMenuState.AddCircle(radius, transform);
        }

        [Test]
        public void RenderCircleTooScene()
        {
            titleMenuState.RenderCircle();
        }

        [Test]
        public void SetCirclePosition()
        {
            Circle circle = new Circle(20.0f);
            Vector2 position = new Vector2(2, 5);
            circle.transform.position = position;
        }

        [Test]
        public void AddCircleWithRadiusAndPosition()
        {
            float radius = 32.5f;
            titleMenuState.AddCircle(32.5f, new Vector2(100,100));
        }
    }
}
