using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Nodo_Medicamento
    {
        public string Nombre;
        public Nodo_Medicamento Siguiente;

        public Nodo_Medicamento(string nombre)
        {
            Nombre = nombre;
            Siguiente = null;
        }
    }
}
