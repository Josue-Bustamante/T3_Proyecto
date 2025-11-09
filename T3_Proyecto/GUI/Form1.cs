using System;
using System.Drawing;
using System.Windows.Forms;
using Biblio;

namespace GUI
{
    public partial class Form1 : Form
    {
        Arbol arbolMedicos = new Arbol();
        Nodo_Area listaAreas;
        Nodo_Historial historialAtenciones = null;

        public Form1()
        {
            InitializeComponent();
            InicializarAreas();
            Medicos_Defecto();
            lv_Historial.View = View.Details;
            lv_Historial.FullRowSelect = true;
            lv_Historial.GridLines = true;
            lv_Historial.Columns.Add("Paciente", 180);
            lv_Historial.Columns.Add("DNI", 100);
            lv_Historial.Columns.Add("Médico", 180);
            lv_Historial.Columns.Add("Área", 150);
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
        private void InicializarAreas()
        {
            cb_Especialidad.Items.Clear();
            cb_Area.Items.Clear();
            cb_Area_Desencolar.Items.Clear();

            listaAreas = new Nodo_Area("Medicina General");
            Nodo_Area actual = listaAreas;
            actual.Siguiente = new Nodo_Area("Ginecologia"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Traumatologia"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Neumologia"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Cardiologia"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Pediatria"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Dermatologia"); actual = actual.Siguiente;
            actual.Siguiente = new Nodo_Area("Gastroenterologia");
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

                switch (temp.Nombre)
                {
                    case "Medicina General":
                        nuevo.Nombre = "Luis";
                        nuevo.ApellidoPaterno = "Herrera";
                        nuevo.ApellidoMaterno = "Campos";
                        nuevo.DNI = "12345678";
                        break;
                    case "Ginecologia":
                        nuevo.Nombre = "María";
                        nuevo.ApellidoPaterno = "Rojas";
                        nuevo.ApellidoMaterno = "Flores";
                        nuevo.DNI = "23456789";
                        break;
                    case "Traumatologia":
                        nuevo.Nombre = "José";
                        nuevo.ApellidoPaterno = "Ramírez";
                        nuevo.ApellidoMaterno = "Torres";
                        nuevo.DNI = "34567890";
                        break;
                    case "Neumologia":
                        nuevo.Nombre = "Ricardo";
                        nuevo.ApellidoPaterno = "Fernández";
                        nuevo.ApellidoMaterno = "Cruz";
                        nuevo.DNI = "45678901";
                        break;
                    case "Cardiologia":
                        nuevo.Nombre = "Pedro";
                        nuevo.ApellidoPaterno = "Salazar";
                        nuevo.ApellidoMaterno = "Mendoza";
                        nuevo.DNI = "56789012";
                        break;
                    case "Pediatria":
                        nuevo.Nombre = "Ana";
                        nuevo.ApellidoPaterno = "Morales";
                        nuevo.ApellidoMaterno = "Gómez";
                        nuevo.DNI = "67890123";
                        break;
                    case "Dermatologia":
                        nuevo.Nombre = "Javier";
                        nuevo.ApellidoPaterno = "Quiroz";
                        nuevo.ApellidoMaterno = "Soto";
                        nuevo.DNI = "78901234";
                        break;
                    case "Gastroenterologia":
                        nuevo.Nombre = "Carla";
                        nuevo.ApellidoPaterno = "Sánchez";
                        nuevo.ApellidoMaterno = "Vargas";
                        nuevo.DNI = "89012345";
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
            nuevo.DNI = txt_DNI.Text;
            nuevo.Nombre = txt_Nombre.Text;
            nuevo.ApellidoPaterno = txt_Paterno.Text;
            nuevo.ApellidoMaterno = txt_Materno.Text;
            nuevo.Area = cb_Especialidad.Text;
            nuevo.Pacientes = new Cola_Pacientes();

            arbolMedicos.Insertar(nuevo);

            MessageBox.Show("Médico registrado correctamente.", "Registro Médico");

            txt_ID.Text = "";
            txt_DNI.Text = "";
            txt_Nombre.Text = "";
            txt_Paterno.Text = "";
            txt_Materno.Text = "";
            cb_Especialidad.SelectedIndex = -1;
        }

        private void btn_Registrar_Paciente_Click(object sender, EventArgs e)
        {
            string area = cb_Area.Text;
            Medico medico = arbolMedicos.Buscar_Area(area);

            if (medico != null)
            {
                Paciente p = new Paciente();
                p.DNI = txt_DNIPaciente.Text;
                p.Nombre = txt_NPaciente.Text;
                p.ApellidoPaterno = txt_PaternoPaciente.Text;
                p.ApellidoMaterno = txt_MaternoPaciente.Text;
                p.Prioridad = checkB_Prioridad.Checked ? 1 : 0;

                medico.Pacientes.Encolar(p);

                MessageBox.Show("Paciente registrado correctamente.", "Registro Paciente");

                txt_DNIPaciente.Text = "";
                txt_NPaciente.Text = "";
                txt_PaternoPaciente.Text = "";
                txt_MaternoPaciente.Text = "";
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
                    MessageBox.Show("Paciente:\n" +
                                    atendido.Nombre + " " + atendido.ApellidoPaterno + " " + atendido.ApellidoMaterno +
                                    "\nDNI: " + atendido.DNI +
                                    "\n\nPasar para atención con el doctor:\n" +
                                    "Dr. " + medico.Nombre + " " + medico.ApellidoPaterno + " " + medico.ApellidoMaterno +
                                    "\n\nEn el área de:\n" +
                                    medico.Area,
                                    "Atención");

                    AgregarHistorial(atendido, medico);
                    ActualizarHistorial();
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
        private void ActualizarTabla()
        {
            dgv_Vista.Rows.Clear();
            dgv_Vista.Columns.Clear();
            Nodo_Area temp = listaAreas;
            while (temp != null)
            {
                dgv_Vista.Columns.Add(temp.Nombre, temp.Nombre);
                temp = temp.Siguiente;
            }
            int maxPacientes = ObtenerMaxPacientes(arbolMedicos.raiz_principal);
            for (int i = 0; i < maxPacientes; i++)
            {
                int index = dgv_Vista.Rows.Add();
                DataGridViewRow fila = dgv_Vista.Rows[index];
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
        private void AgregarHistorial(Paciente p, Medico m)
        {
            Nodo_Historial nuevo = new Nodo_Historial();
            nuevo.PacienteNombre = p.Nombre + " " + p.ApellidoPaterno + " " + p.ApellidoMaterno;
            nuevo.PacienteDNI = p.DNI;
            nuevo.MedicoNombre = m.Nombre + " " + m.ApellidoPaterno + " " + m.ApellidoMaterno;
            nuevo.MedicoArea = m.Area;

            if (historialAtenciones == null)
            {
                historialAtenciones = nuevo;
            }
            else
            {
                Nodo_Historial temp = historialAtenciones;
                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevo;
            }
        }

        private void ActualizarHistorial()
        {
            lv_Historial.Items.Clear();

            Nodo_Historial temp = historialAtenciones;
            while (temp != null)
            {
                ListViewItem item = new ListViewItem(temp.PacienteNombre);
                item.SubItems.Add(temp.PacienteDNI);
                item.SubItems.Add(temp.MedicoNombre);
                item.SubItems.Add(temp.MedicoArea);
                lv_Historial.Items.Add(item);

                temp = temp.Siguiente;
            }
        }

    }
}
