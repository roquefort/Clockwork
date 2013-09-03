using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLoop
{
    static class Program
    {
        //Enable the below line if program needs a loop again

       // static FastLoop _fastloop = new FastLoop(GameLoop);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine("starting loop");
        }

        static void GameLoop(double elapsedTime)
        {
            System.Console.WriteLine("loop");
        }
    }
}
