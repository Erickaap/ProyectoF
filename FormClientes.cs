using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoF
{
    public partial class FormClientes : Syncfusion.Windows.Forms.Office2010Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }
        BaseDatos bd = new BaseDatos();
        string operacion = string.Empty;



        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("Dni", "DNI");
            dataGridView1.Columns.Add(" Nombre", "NOMBRE");
            dataGridView1.Columns.Add("Apellido", "APELLIDO");
            dataGridView1.Columns.Add("Telefono", "TELEFONO");

            dataGridView1.Rows.Add(textBoxDni.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxTelefono.Text);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBoxDni.Clear();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxTelefono.Clear();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

    }
}
    


