using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoF;
using System.Data.SqlClient;


namespace ProyectoF
{
    public partial class FormLogin : Syncfusion.Windows.Forms.Office2010Form
    {
        public FormLogin()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        BaseDatos conexion = new BaseDatos();
        Usuarioo user = new Usuarioo();
        public class Usuarioo
        {
            public int Id { get; set; }
            public string Usuario { get; set; }
            public string Contraseña { get; set; }
        }
    private void buttonAceptar_Click(object sender, EventArgs e, object user)

        {

            BaseDatos _base = new BaseDatos();
            if (_base.ValidarUsuario(textBoxUsuario.Text, textBoxContraseña.Text))
            {
                FormMenu formulario = new FormMenu();
                this.Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxContraseña.Text = "";

        }

    }
}

