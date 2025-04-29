using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTaller5
{
    internal class AlumnosAcciones
    {
        public void Start()
        {
            List<string> ListaDeAlumnos = new List<string>();
            Console.WriteLine("Inserte nombre de Alumno");
            ListaDeAlumnos.Add(Console.ReadLine());

            Console.WriteLine(ListaDeAlumnos.Count);
        }
    }
}
