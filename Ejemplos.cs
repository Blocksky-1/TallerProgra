using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTaller5
{
    internal class Ejemplos
    {
        public void Start()
        {
            Triangle t1 = new Triangle(3, 7);
            Triangle t2 = new Triangle(4, 8);

            Triangle[] tris = { t1, t2, new Triangle(1, 1) };
            //tris[3] = new Triangle(1, 2); <= error

            List<Triangle> lista = new List<Triangle>();
            lista.Add(t1);
            lista.Add(t2);
            lista.Add(new Triangle(1, 2));

            Console.WriteLine(lista.Count);

            Triangle r = lista.Find(x => x.Area() == 5);
            lista.Remove(r);
            Console.WriteLine(lista.Count);

            //List<Triangle> lista =tris.ToList();

            foreach (Triangle tr in lista)
            {
                Console.WriteLine(tr.Area());
            }
        }
    }
}
