using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Lista_Areas
    {
        public Nodo_Area listaAreas;

        public Lista_Areas()
        {
            InicializarAreas();
        }

        public void InicializarAreas()
        {
            listaAreas = new Nodo_Area("Medicina General");
            Nodo_Area actual = listaAreas;
            actual.Siguiente = new Nodo_Area("Ginecologia"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Traumatologia"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Neumologia"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Cardiologia"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Pediatria"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Dermatologia"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Gastroenterologia");
        }
    }
}
