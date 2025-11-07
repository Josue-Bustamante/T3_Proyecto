using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Cola_Pacientes
    {
        private Nodo_Paciente frente;
        private Nodo_Paciente final;

        public Cola_Pacientes()
        {
            frente = final = null;
        }

        public void Encolar(string nombre)
        {
            Nodo_Paciente nuevo = new Nodo_Paciente(nombre);
            if (final == null)
                frente = final = nuevo;
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }

        public string Desencolar()
        {
            if (frente == null)
                return null;

            string nombre = frente.Nombre;
            frente = frente.Siguiente;
            if (frente == null)
                final = null;
            return nombre;
        }

        public bool EstaVacia()
        {
            return frente == null;
        }

        public string MostrarCola()
        {
            string texto = "";
            Nodo_Paciente temp = frente;
            while (temp != null)
            {
                texto += temp.Nombre + " -> ";
                temp = temp.Siguiente;
            }
            return texto == "" ? "Sin pacientes" : texto + "FIN";
        }
    }
}
