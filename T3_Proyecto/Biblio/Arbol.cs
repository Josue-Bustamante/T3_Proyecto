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

        //disfraz
        public void insertar(Medico d)
        {
            insertar(ref raiz_principal, d);
        }
    }
}
