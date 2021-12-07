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
    public partial class FormBoleteria : Syncfusion.Windows.Forms.Office2010Form
    {
        public FormBoleteria()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
       
        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("Fecha", "FECHA"); 
            dataGridView1.Columns.Add("NoBus", "NOBUS");
            dataGridView1.Columns.Add("NoAsiento", "NoAsiento");
            dataGridView1.Columns.Add("Destino", "DESTINO");
            dataGridView1.Columns.Add("Descripcion", "DESCRIPCION");
            dataGridView1.Columns.Add("Precio", "PRECIO");
            dataGridView1.Rows.Add(textBoxNoBus.Text, textBoxNoAsiento.Text, textBoxDestino.Text, textBoxDescripcion.Text,
                textBoxPrecio.Text, dateTimePickerFecha.Value);
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxNoBus.Clear();
            textBoxNoAsiento.Clear();
            textBoxDestino.Clear();
            textBoxDescripcion.Clear();
            textBoxPrecio.Clear();
            dateTimePickerFecha.ResetText();
                

        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
