using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Nodo_Paciente
    {
        public string Nombre;
        public Nodo_Paciente Siguiente;

        public Nodo_Paciente(string nombre)
        {
            Nombre = nombre;
            Siguiente = null;
        }
    }
}
