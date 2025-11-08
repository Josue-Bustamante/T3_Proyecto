using System;
using System.Drawing;
using System.Windows.Forms;
using Biblio;

namespace GUI
{
    public partial class Form1 : Form
    {
        Arbol arbolMedicos = new Arbol();
        Nodo_Area listaAreas; // ← lista enlazada de áreas médicas
        Lista_Medicamento listaMedicamentos = new Lista_Medicamento();

        public Form1()
        {
            InitializeComponent();
            InicializarAreas();
            Medicos_Defecto();
        }
        public class Nodo_Area
        {
            public string Nombre;
            public Nodo_Area Siguiente;

            public Nodo_Area(string nombre)
            {
                Nombre = nombre;
                Siguiente = null;
            }
        }

        // Crea la lista enlazada de áreas
        private void InicializarAreas()
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

            // Cargar los ComboBox sin usar arreglos
            Nodo_Area temp = listaAreas;
            while (temp != null)
            {
                cb_Especialidad.Items.Add(temp.Nombre);
                cb_Area.Items.Add(temp.Nombre);
                cb_Area_Desencolar.Items.Add(temp.Nombre);
                temp = temp.Siguiente;
            }
        }
        private void Medicos_Defecto()
        {
            Nodo_Area temp = listaAreas;
            int id = 1;

            while (temp != null)
            {
                Medico nuevo = new Medico();
                nuevo.Id = id;

                // Asignar nombres reales aleatorios
                switch (temp.Nombre)
                {
                    case "Medicina General":
                        nuevo.Nombre = "Dr. Luis Herrera";
                        break;
                    case "Ginecologia":
                        nuevo.Nombre = "Dra. María Rojas";
                        break;
                    case "Traumatologia":
                        nuevo.Nombre = "Dr. José Ramírez";
                        break;
                    case "Neumologia":
                        nuevo.Nombre = "Dr. Ricardo Fernández";
                        break;
                    case "Cardiologia":
                        nuevo.Nombre = "Dr. Pedro Salazar";
                        break;
                    case "Pediatria":
                        nuevo.Nombre = "Dra. Ana Morales";
                        break;
                    case "Dermatologia":
                        nuevo.Nombre = "Dr. Javier Quiroz";
                        break;
                    case "Gastroenterologia":
                        nuevo.Nombre = "Dra. Carla Sánchez";
                        break;
                }
                nuevo.Area = temp.Nombre;
                nuevo.Pacientes = new Cola_Pacientes();
                arbolMedicos.Insertar(nuevo);
                id++;
                temp = temp.Siguiente;
            }

            MessageBox.Show("Se registraron médicos por defecto para todas las áreas.", "Inicio del sistema");
        }

        private void btn_Registrar_Medico_Click(object sender, EventArgs e)
        {
            Medico nuevo = new Medico();
            nuevo.Id = int.Parse(txt_ID.Text);
            nuevo.Nombre = txt_Nombre.Text;
            nuevo.Area = cb_Especialidad.Text;
            nuevo.Pacientes = new Cola_Pacientes();

            arbolMedicos.Insertar(nuevo);

            MessageBox.Show("Médico registrado correctamente.", "Registro Médico");

            txt_ID.Text = "";
            txt_Nombre.Text = "";
            cb_Especialidad.SelectedIndex = -1;
        }

        private void btn_Registrar_Paciente_Click(object sender, EventArgs e)
        {
            string area = cb_Area.Text;
            Medico medico = arbolMedicos.Buscar_Area(area);

            if (medico != null)
            {
                Paciente p = new Paciente();
                p.Nombre = txt_NPaciente.Text;
                p.Prioridad = checkB_Prioridad.Checked ? 1 : 0;

                medico.Pacientes.Encolar(p);

                MessageBox.Show("Paciente registrado correctamente.", "Registro Paciente");

                txt_NPaciente.Text = "";
                cb_Area.SelectedIndex = -1;
                checkB_Prioridad.Checked = false;

                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("No existe un médico registrado en el área seleccionada.", "Aviso");
            }
        }
        private void btn_Atender_Click(object sender, EventArgs e)
        {
            string area = cb_Area_Desencolar.Text;
            Medico medico = arbolMedicos.Buscar_Area(area);
            if (medico != null)
            {
                Paciente atendido = medico.Pacientes.Desencolar();
                if (atendido != null)
                {
                    Medicamento med = listaMedicamentos.BuscarPorArea(medico.Area);
                    if (med != null)
                    {
                        if (med.Stock > 0)
                        {
                            med.Stock--;
                            MessageBox.Show(
                                "Atendiendo a: " + atendido.Nombre +
                                "\nMédico: " + medico.Nombre +
                                "\nÁrea: " + medico.Area +
                                "\nMedicamento asignado: " + med.Nombre +
                                "\nStock restante: " + med.Stock,
                                "Atención"
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Atendiendo a: " + atendido.Nombre +
                                "\nMédico: " + medico.Nombre +
                                "\nÁrea: " + medico.Area +
                                "\n⚠ No queda stock de " + med.Nombre + ".",
                                "Atención"
                            );
                        }
                    }
                    ActualizarTabla();
                }
                else
                {
                    MessageBox.Show("No hay pacientes en la cola para esta área.", "Cola vacía");
                }
            }
            else
            {
                MessageBox.Show("No existe un médico en el área seleccionada.", "Aviso");
            }
        }
        // -----------------------------------------
        // ACTUALIZAR TABLA SIN USAR ARREGLOS
        // -----------------------------------------
        private void ActualizarTabla()
        {
            dgv_Vista.Rows.Clear();
            dgv_Vista.Columns.Clear();

            // Crear columnas dinámicamente desde la lista enlazada
            Nodo_Area temp = listaAreas;
            while (temp != null)
            {
                dgv_Vista.Columns.Add(temp.Nombre, temp.Nombre);
                temp = temp.Siguiente;
            }

            // Obtener cantidad máxima de pacientes en alguna cola
            int maxPacientes = ObtenerMaxPacientes(arbolMedicos.raiz_principal);

            // Crear filas según el número máximo de pacientes
            for (int i = 0; i < maxPacientes; i++)
            {
                int index = dgv_Vista.Rows.Add();
                DataGridViewRow fila = dgv_Vista.Rows[index];

                // Llenar la fila con los pacientes de esa posición
                LlenarFilaPorArea(arbolMedicos.raiz_principal, fila, i);
            }
        }
        private int ObtenerMaxPacientes(Nodo_Medico raiz)
        {
            if (raiz == null) return 0;

            int maxIzq = ObtenerMaxPacientes(raiz.Izquierdo);
            int maxDer = ObtenerMaxPacientes(raiz.Derecho);
            int cantidad = ContarPacientes(raiz.dato.Pacientes.frente);

            int mayor = cantidad;
            if (maxIzq > mayor) mayor = maxIzq;
            if (maxDer > mayor) mayor = maxDer;

            return mayor;
        }

        private int ContarPacientes(Nodo_Paciente nodo)
        {
            int count = 0;
            while (nodo != null)
            {
                count++;
                nodo = nodo.Siguiente;
            }
            return count;
        }

        private void LlenarFilaPorArea(Nodo_Medico raiz, DataGridViewRow fila, int posicion)
        {
            if (raiz == null) return;

            // Buscar la columna que coincide con el área del médico
            foreach (DataGridViewColumn col in dgv_Vista.Columns)
            {
                if (col.HeaderText == raiz.dato.Area)
                {
                    Nodo_Paciente paciente = ObtenerNodoEnPosicion(raiz.dato.Pacientes.frente, posicion);
                    if (paciente != null)
                    {
                        fila.Cells[col.Index].Value = paciente.dato.Nombre;
                    }
                    break;
                }
            }

            LlenarFilaPorArea(raiz.Izquierdo, fila, posicion);
            LlenarFilaPorArea(raiz.Derecho, fila, posicion);
        }

        private Nodo_Paciente ObtenerNodoEnPosicion(Nodo_Paciente frente, int posicion)
        {
            int indice = 0;
            Nodo_Paciente temp = frente;
            while (temp != null)
            {
                if (indice == posicion)
                    return temp;
                temp = temp.Siguiente;
                indice++;
            }
            return null;
        }
    }
}
