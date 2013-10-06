using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Clockwork2D;

namespace GameLoop.GameLoopTests
{
    [TestFixture]
    class StateSytemTest
    {
        StateSystem stateSystemUpdate;

        [Test]
        public void CreateStateSystem()
        {
            StateSystem stateSystem = new StateSystem();
        }

        [Test]
        public void CreateState()
        {
            StateSystem stateSystem = new StateSystem();
            DrawSpriteState drawSpriteState = new DrawSpriteState();

            stateSystem.AddState("drawSprite", drawSpriteState);
            stateSystem.ChangeState("drawSprite");
        }

        [Test]
        public void StateSystemUpdateTest()
        {
            stateSystemUpdate = new StateSystem();

            stateSystemUpdate.AddState("drawSprite", new DrawSpriteState());
            stateSystemUpdate.ChangeState("drawSprite");
            
            FastLoop fastLoop = new FastLoop(GameLoopTest);
        }

        /*
        [Test]
        void AddObjectsToScene(Shape shape, double posX, double posY)
        {
            //Body body = new Body(
        }
        */
 
        private void GameLoopTest(double elapsedTime)
        {
            Console.WriteLine("test game loop");
            stateSystemUpdate.Update(elapsedTime);
            stateSystemUpdate.Render();
        }
    }
}
