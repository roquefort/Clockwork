using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Body body = new Body();
            Shape shape = new Circle();

            Transform trans = new Transform();
            trans.position = new Vector2(2, 2);

            body.shape = shape;
            body.transform = trans;
        }
    }
}
