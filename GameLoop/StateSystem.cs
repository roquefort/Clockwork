using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace GameLoop
{
    class StateSystem
    {
        Dictionary<string, IGameObject> _stateStore = new Dictionary<string, IGameObject>();
        IGameObject _currentState = null;

        public void Update(double elapsedTime)
        {
            if (_currentState == null)
            {
                return;
            }
            _currentState.Update(elapsedTime);
        }

        public void Render()
        {
            if (_currentState == null)
            {
                return;
            }
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glPointSize(5.0f);

            _currentState.Render();

            Gl.glFinish();
        }

        public void AddState(string stateId, IGameObject state)
        {
            Console.WriteLine("Add State");

            System.Diagnostics.Debug.Assert(Exists(stateId) == false);
            _stateStore.Add(stateId, state);
        }


        public void ChangeState(string stateId)
        {
            Console.WriteLine("The new state is {0}", stateId);
            System.Diagnostics.Debug.Assert(Exists(stateId));
            _currentState = _stateStore[stateId];
        }

        public bool Exists(string stateId)
        {
            return _stateStore.ContainsKey(stateId);
        }
    }
}
