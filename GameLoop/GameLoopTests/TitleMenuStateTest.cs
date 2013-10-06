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
        public void AddBodyToSceneAtLocation()
        {
            Transform _transform = new Transform(new Vector2());
            titleMenuState.AddBody(_transform);
        }

        [Test]
        public void AddBodyToSceneAtLocationAndRadius()
        {
            Transform _transform = new Transform(new Vector2());
            float radius = 40f;
            titleMenuState.AddBody(_transform, radius);
        }

        [Test]
        public void CreatePairs()
        {
            titleMenuState.CreatePairs();
        }

        public void DetectCollisions()
        {
            titleMenuState.DetectCollisions();
        }

    }
}
