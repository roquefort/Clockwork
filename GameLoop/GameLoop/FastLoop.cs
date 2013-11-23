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

        PreciseTimer timer = new PreciseTimer();
        
        public delegate void LoopCallback(double elapsedTime);
        LoopCallback callBack;
        
        //get the passed in method and set it as the callback
        public FastLoop(LoopCallback callback)
        {
            this.callBack = callback;
            Application.Idle += new EventHandler(OnApplicationEnterIdle);
        }

        //check if the app is in idle, if not run delegate (calls GameLoop
        //function in GameLoop class and passes in PreciseTimer elapsed time)
        //since last update
        private void OnApplicationEnterIdle(object sender, EventArgs e)
        {
            while (IsAppStillIdle())
            {
                callBack(timer.GetElapsedTime());
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
