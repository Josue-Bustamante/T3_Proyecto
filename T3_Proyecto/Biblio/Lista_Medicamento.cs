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
            Insertar(new Medicamento { Nombre = "Paracetamol", Especialidad = "Medicina General", Stock = 5 });
            Insertar(new Medicamento { Nombre = "Ibuprofeno", Especialidad = "Ginecologia", Stock = 5 });
            Insertar(new Medicamento { Nombre = "Amoxicilina", Especialidad = "Traumatologia", Stock = 5 });
            Insertar(new Medicamento { Nombre = "Loratadina", Especialidad = "Neumologia", Stock = 5 });
            Insertar(new Medicamento { Nombre = "Aspirina", Especialidad = "Cardiologia", Stock = 5 });
            Insertar(new Medicamento { Nombre = "Jarabe Infantil", Especialidad = "Pediatria", Stock = 5 });
            Insertar(new Medicamento { Nombre = "Crema Antialérgica", Especialidad = "Dermatologia", Stock = 5 });
            Insertar(new Medicamento { Nombre = "Omeprazol", Especialidad = "Gastroenterologia", Stock = 5 });
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
        public Medicamento BuscarPorArea(string area)
        {
            Nodo_Medicamento temp = primero;
            while (temp != null)
            {
                if (temp.dato.Especialidad == area)
                    return temp.dato;

                temp = temp.Siguiente;
            }
            return null;
        }

        //<<<<<<< HEAD

        //        public void Mostrar()
        //=======
        //        public Medicamento BuscarPorArea(string area)
        //>>>>>>> rama1
        //        {
        //            Nodo_Medicamento temp = primero;
        //            while (temp != null)
        //            {
        //<<<<<<< HEAD
        //                Console.WriteLine("->" + temp.dato);
        //                temp = temp.Siguiente;
        //            }
        //        }

        //        public void Eliminar(string v)
        //        {
        //            Nodo_Medicamento temp = primero;
        //            Nodo_Medicamento ant = null;
        //            while (temp != null)
        //            {
        //                if (temp.dato.Nombre == v)
        //                {
        //                    if (temp == primero)
        //                    {
        //                        primero = primero.Siguiente;
        //                    }
        //                    else
        //                    {
        //                        ant.Siguiente = temp.Siguiente;
        //                    }
        //                    return;
        //                }
        //                ant = temp;
        //                temp = temp.Siguiente;
        //            }
        //            Console.WriteLine("Elemento no encontrado");
        //=======
        //                if (temp.dato.Especialidad == area)
        //                    return temp.dato;

        //                temp = temp.Siguiente;
        //            }
        //            return null;
        //>>>>>>> rama1
        //}
    }
}

