using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GameLoop
{
    class SplashcreenState : IGameObject
    {
        private StateSystem _system;
        double _delayInSeconds = 3;

        public SplashcreenState(StateSystem _system)
        {
            // TODO: Complete member initialization
            this._system = _system;
        }

        #region IGameObject Memebers

        public void Update(double elapsedTime)
        {
            Console.WriteLine("Update splash");

            _delayInSeconds -= elapsedTime;
            if (_delayInSeconds <= 0)
            {
                _delayInSeconds = 3;
                _system.ChangeState("title_menu");
            }
        }

        public void Render()
        {
            //  Console.WriteLine("Render splash");
            Gl.glClearColor(1, 1, 1, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glFinish();
            
        }

        #endregion
    }
}
