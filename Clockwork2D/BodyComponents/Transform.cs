using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockwork2D
{
    public class Transform
    {
        private Vector2 m_position;
        public Vector2 position
        {
            get
            {
                return m_position;
            }

            set
            {
                m_position = value;
            }
        }

        public Transform()
        {
            m_position = new Vector2();
        }

        public Transform(Vector2 position)
        {
            this.m_position = position;
        }
    }
}
