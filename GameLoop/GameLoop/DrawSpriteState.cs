using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GameLoop
{
    class DrawSpriteState : IGameObject
    {
        public void Update(double elapsedTime)
        {
            Console.WriteLine("sprites update");
        }

        public void Render()
        {
            double height = 200;
            double width = 200;
            double halfHeight = height / 2;
            double halfWidth = width / 2;

            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glBegin(Gl.GL_TRIANGLES);
            {
                Gl.glVertex3d(-halfWidth, halfHeight, 0); //top left
                Gl.glVertex3d(halfWidth, halfHeight, 0); //top right
                Gl.glVertex3d(-halfWidth, -halfHeight, 0); //bottom left

                Gl.glVertex3d(halfWidth, halfHeight, 0); //top right
                Gl.glVertex3d(halfWidth, -halfHeight, 0);//bottom right
                Gl.glVertex3d(-halfWidth, -halfHeight, 0); //bottom left


            }
            Gl.glEnd();
        }
    }
}
