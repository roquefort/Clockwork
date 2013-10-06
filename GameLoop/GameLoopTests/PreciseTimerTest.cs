using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GameLoop.GameLoopTests
{
    [TestFixture]
    class PreciseTimerTest
    {
        [Test]
        public void CreatePreciseTimer()
        {
            PreciseTimer preciseTimer = new PreciseTimer();
        }

        [Test]
        public void GetElapsedTimeTest()
        {
            PreciseTimer preciseTimer = new PreciseTimer();
            //not sure how to test if this gives a correct result
            //since it is all based on CPU time between the frame
            preciseTimer.GetElapsedTime();
        }
    }
}
