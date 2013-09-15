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
        public void RenderBodyToScene()
        {
            titleMenuState.RenderBody();
        }

        [Test]
        public void AddBodyTooScene()
        {
            titleMenuState.AddBody();
        }

        [Test]
        public void SetCirclePosition()
        {
            Circle circle = new Circle(20.0f);
            Vector2 position = new Vector2(2, 5);
            circle.transform.position = position;
        }
    }
}
