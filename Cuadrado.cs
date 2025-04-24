using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTaller5
{
    internal class Cuadrado
    {
        private float b;
        private float h;
        public Cuadrado(float b, float h)
        {
            this.b = b;
            this.h = h;
        }
        public float Area() => b * h;
    }
}
