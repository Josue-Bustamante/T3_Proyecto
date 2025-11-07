using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Cola_Pacientes
    {
        public Nodo_Paciente frente = null;
        public Nodo_Paciente final = null;

        public void Encolar(Paciente p)
        {
            //1. Crear nuevo Nodo
            Nodo_Paciente nuevo = new Nodo_Paciente();
            nuevo.dato = p;

            //2. encolar
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                if (p.Prioridad == 0)
                {
                    final.Siguiente = nuevo;
                    final = nuevo;
                }
                else
                {
                    if (frente.dato.Prioridad == 0)
                    {
                        nuevo.Siguiente = frente;
                        frente = nuevo;
                    }
                    else
                    {
                        Nodo_Paciente temp = frente;
                        while (temp != null && temp.Siguiente.dato.Prioridad == 1)
                        {
                            temp = temp.Siguiente;
                        }
                        nuevo.Siguiente = temp.Siguiente;
                        temp.Siguiente = nuevo;

                    }
                }
            }

        }

        public Paciente Desencolar()
        {
            if (frente != null)
            {
                Paciente p = frente.dato;

                frente = frente.Siguiente;

                return p;
            }
            return null;
        }
    }
}
