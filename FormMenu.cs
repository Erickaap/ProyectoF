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
    public partial class FormMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FormMenu()
        {
            InitializeComponent();

        }
        FormClientes FormularioClientes;
        FormBoleteria FormularioBoleteria;

        private void toolStripButtonClientes_Click(object sender, EventArgs e)
        {
            if (FormularioClientes == null)
            {
                FormularioClientes = new FormClientes();
                FormularioClientes.MdiParent = this.MdiParent;
                FormularioClientes.FormClosed += Formulario_FormClosed;
                FormularioClientes.Show();
            }
            else
            {
                FormularioClientes.Activate();
            }
        }
        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormularioClientes = null;
        }

        private void toolStripButtonBoletos_Click(object sender, EventArgs e)
        {
            if (FormularioBoleteria == null)
            {
                FormularioBoleteria = new FormBoleteria();
                FormularioBoleteria.MdiParent = this.MdiParent;
                FormularioBoleteria.FormClosed += Formulario1_FormClosed;
                FormularioBoleteria.Show();
            }
            else
            {
                FormularioBoleteria.Activate();
            }
        }
        private void Formulario1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormularioBoleteria = null;
        }
        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            Application.Exit();
        }

    }

}


