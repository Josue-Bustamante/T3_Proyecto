using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Arbol
    {
        public Nodo_Medico raiz_principal = null;

        private void insertar(ref Nodo_Medico raiz, Medico d)
        {
            if (raiz == null)
            {
                Nodo_Medico nuevo = new Nodo_Medico();
                nuevo.dato = d;

                raiz = nuevo;
            }
            else
            {
                if (d.Id < raiz.dato.Id)
                {
                    insertar(ref raiz.Izquierdo, d);
                }
                else if (d.Id > raiz.dato.Id)
                {
                    insertar(ref raiz.Derecho, d);
                }
                else
                {
                    Console.WriteLine("DATO DUPLICADO");
                }
            }
        }
        public void Insertar(Medico d)
        {
            insertar(ref raiz_principal, d);
        }
        public Medico Buscar_Area(string area)
        {
            return buscar_Area(raiz_principal, area);
        }

        private Medico buscar_Area(Nodo_Medico raiz, string area)
        {
            if (raiz == null) return null;

            if (raiz.dato.Area == area)
                return raiz.dato;

            Medico encontrado = buscar_Area(raiz.Izquierdo, area);
            if (encontrado != null) return encontrado;

            return buscar_Area(raiz.Derecho, area);
        }
    }
}
