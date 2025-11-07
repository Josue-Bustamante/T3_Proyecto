using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Nodo_Medico
    {
        public int Id;
        public string Nombre;
        public string Area;
        public Cola_Pacientes Pacientes;
        public Nodo_Medico Izquierdo;
        public Nodo_Medico Derecho;

        public Nodo_Medico(int id, string nombre, string area)
        {
            Id = id;
            Nombre = nombre;
            Area = area;
            Pacientes = new Cola_Pacientes();
            Izquierdo = null;
            Derecho = null;
        }

        public override string ToString()
        {
            return $"ID: {Id} - {Nombre} ({Area})";
        }
    }
}
