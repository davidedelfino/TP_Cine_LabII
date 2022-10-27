using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        Usuario oUsuario;
        public FrmLogin()
        {
            InitializeComponent();
            oUsuario = new Usuario();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblIngresar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != oUsuario.Contrasenia || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Contraseña incorrecta");
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }
            if (txtUsuario.Text != oUsuario.User || txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Usuario incorrecto");
                txtUsuario.Clear();
                txtUsuario.Focus();
                return;
            }
            this.Dispose();
            FrmConsultas frmConsultas = new FrmConsultas();
            frmConsultas.Show();
        }
    }
}
