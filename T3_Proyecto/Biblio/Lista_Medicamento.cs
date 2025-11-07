using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Lista_Medicamento
    {
        public Nodo_Medicamento primero = null;

        public Lista_Medicamento()
        {
            Insertar(new Medicamento { Nombre = "Paracetamol" });
            Insertar(new Medicamento { Nombre = "Ibuprofeno" });
            Insertar(new Medicamento { Nombre = "Amoxicilina" });
            Insertar(new Medicamento { Nombre = "Loratadina" });
        }

        public void Insertar(Medicamento v)
        {
            Nodo_Medicamento nuevo = new Nodo_Medicamento();
            nuevo.dato = v;

            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo_Medicamento temp = primero;
                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevo;
            }
        }

        public void Mostrar()
        {
            Nodo_Medicamento temp = primero;
            while (temp != null)
            {
                Console.WriteLine("->" + temp.dato);
                temp = temp.Siguiente;
            }
        }

        public void Eliminar(string v)
        {
            Nodo_Medicamento temp = primero;
            Nodo_Medicamento ant = null;
            while (temp != null)
            {
                if (temp.dato.Nombre == v)
                {
                    if (temp == primero)
                    {
                        primero = primero.Siguiente;
                    }
                    else
                    {
                        ant.Siguiente = temp.Siguiente;
                    }
                    return;
                }
                ant = temp;
                temp = temp.Siguiente;
            }
            Console.WriteLine("Elemento no encontrado");
        }
    }
}

