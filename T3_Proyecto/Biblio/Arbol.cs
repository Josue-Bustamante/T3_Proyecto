using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Arbol
    {
        public Nodo_Medico Raiz;

        public void Insertar(int id, string nombre, string area)
        {
            Raiz = insertar(Raiz, id, nombre, area);
        }

        private Nodo_Medico insertar(Nodo_Medico raiz, int id, string nombre, string area)
        {
            if (raiz == null)
                return new Nodo_Medico(id, nombre, area);

            if (id < raiz.Id)
                raiz.Izquierdo = insertar(raiz.Izquierdo, id, nombre, area);
            else if (id > raiz.Id)
                raiz.Derecho = insertar(raiz.Derecho, id, nombre, area);

            return raiz;
        }

        public Nodo_Medico Buscar(int id)
        {
            return buscar(Raiz, id);
        }

        private Nodo_Medico buscar(Nodo_Medico raiz, int id)
        {
            if (raiz == null || raiz.Id == id)
                return raiz;
            if (id < raiz.Id)
                return buscar(raiz.Izquierdo, id);
            else
                return buscar(raiz.Derecho, id);
        }
        public string ObtenerMedicosComoTexto()
        {
            string resultado = "";
            RecorrerInOrden(Raiz, ref resultado);
            return resultado;
        }

        private void RecorrerInOrden(Nodo_Medico nodo, ref string texto)
        {
            if (nodo != null)
            {
                RecorrerInOrden(nodo.Izquierdo, ref texto);
                texto += nodo.ToString() + "\n";
                RecorrerInOrden(nodo.Derecho, ref texto);
            }
        }
    }
}
