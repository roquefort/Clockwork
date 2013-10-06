using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GameLoop.GameLoopTests
{
    [TestFixture]
    class FastLoopTest
    {
        [Test]
        public void CreateFastLoop()
        {
            PreciseTimer preciseTimer = new PreciseTimer();
            FastLoop fastloop = new FastLoop(GameLoopTest);
        }

        private void GameLoopTest(double elaspsedTime)
        {
            Console.WriteLine("main loop");
            //where all render and update data is called etc
        }
    }
}
