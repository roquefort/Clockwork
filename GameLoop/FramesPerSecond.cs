using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop
{
    class FramesPerSecond
    {
        int _numberOfFrames = 60;
        double _timePassed = 0;

        private static double deltaTime;
        public static double DeltaTime
        {
            get { return deltaTime; }
        }

        //whether to print the fps to console or not
        public bool PrintFPS
        {
            set;
            get;
        }

        //what is the current fps
        public double CurrentFps
        {
            get;
            set;
        }
        
        //print fps constructor
        public FramesPerSecond(bool printFPS)
        {
            this.PrintFPS = printFPS;
        }

        //determine the FPS
        public void Process(double timeElapsed)
        {
            _numberOfFrames++;
            _timePassed = _timePassed + timeElapsed;
            if (_timePassed > 1)
                ResetProcess();
        }

        private void ResetProcess()
        {
            CurrentFps = (double)_numberOfFrames / _timePassed;
            deltaTime = (double)1 / CurrentFps;
            if (PrintFPS)
                Console.WriteLine("FPS: " + CurrentFps);

            _timePassed = 0;
            _numberOfFrames = 0;
        }
    }
}
