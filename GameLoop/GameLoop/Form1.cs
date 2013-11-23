﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace GameLoop
{
    public partial class Form1 : Form
    {        
        bool _fullscreen = false;
        FastLoop _fastLoop;
        StateSystem _system = new StateSystem();

        public Form1()
        {
            //add all the states that will be used
            _system.AddState("splash", new SplashcreenState(_system));
            _system.AddState("title_menu", new TitleMenuState());
            _system.AddState("sprite_test", new DrawSpriteState());
            //select the start state
            _system.ChangeState("title_menu");

            _fastLoop = new FastLoop(GameLoop);
            InitializeComponent();
            _openGLControl.InitializeContexts();  

            if (_fullscreen)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                ClientSize = new Size(1280, 720);
            }
            //Setup2DGraphics(ClientSize.Width, ClientSize.Height);
        }
        
        //game loop is passed as a delegate to fast loop
        void GameLoop(double elapsedTime)
        {
            _system.Update(elapsedTime);
            _system.Render();
            _openGLControl.Refresh();
        }
        
        protected override void OnClientSizeChanged(EventArgs e)
        {
            base.OnClientSizeChanged(e);
            Gl.glViewport(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            Setup2DGraphics(ClientSize.Width, ClientSize.Height);
        }
        
        private void Setup2DGraphics(double width, double height)
        {
            double halfWidth = width / 2;
            double halfHeight = height / 2;

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-halfWidth, halfWidth, -halfHeight, halfHeight, -100, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        private void _openGLControl_Load(object sender, EventArgs e)
        {

        }
    }
}