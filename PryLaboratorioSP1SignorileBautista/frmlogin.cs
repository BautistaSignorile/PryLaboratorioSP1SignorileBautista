using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLaboratorioSP1SignorileBautista
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Adm" && txtContraseña.Text == "@1a" && cmbModulo.Text == "ADM")
            {
                Form Bienvenido = new frmBienvenida();
                this.Hide();
                Bienvenido.Show(); 

            }
            else
            {
                MessageBox.Show("Datos ingresados invalidos");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
        }
    }
}
