using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GameLoop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Message
    {
        public IntPtr hWnd;
        public Int32 msg;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public System.Drawing.Point p;
    }

    class FastLoop
    {
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool PeekMessage
        (
        out Message msg,
        IntPtr hWnd,
        uint messageFilterMin,
        uint messageFilterMax,
        uint flags
        );

        PreciseTimer _timer = new PreciseTimer();
        public delegate void LoopCallback(double elapsedTime);
        LoopCallback _callback;
        
        //get the passed in method and set it as the callback
        public FastLoop(LoopCallback callback)
        {
            _callback = callback;
            //check to see whether the application is in idle mode, if so run OnApplicationEnterIdle
            Application.Idle += new EventHandler(OnApplicationEnterIdle);
        }

        //check if there is anything that needs to be run if not, call the game loop (_callback()
        //that was passed through in the constructor and applied to the local delegate
        //then run the delegate, this runs the passed in parameter (gameloop)
        private void OnApplicationEnterIdle(object sender, EventArgs e)
        {
            while (IsAppStillIdle())
            {
                _callback(_timer.GetElapsedTime());
            }
        }

        //uses C to check if there is anything running
        private bool IsAppStillIdle()
        {
            Message msg;
            return !PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
        }
    }
}
