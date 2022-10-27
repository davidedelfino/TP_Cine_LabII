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
    public partial class FrmPrincipal : Form
    {
        private FrmLogin login;
        private int numImagen=1;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login = new FrmLogin();
            login.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                MessageBox.Show("Asignatura: Laboratorio de Computación II\r\nProfesores:\r\n - Kunda, Beatríz\r\n - Giñazu, Gastón Ignacio\r\nTema: Cine\r\nGrupo: 11\r\nComisión: 1W4\r\nColaboradores:\r\n  - 111858, Delfino David Elías\r\n  - 113009, Brosio Emiliano\r\n  - 113174, Gregorutti Stefano Ignacio\r\n  - 113179, Piñeiro Ignacio Roberto");
                MessageBox.Show("        ¡GRACIAS!");
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Slider()
        {
            if(numImagen==13)
            {
                numImagen = 1;
            }
            pboxSlider.ImageLocation = String.Format(@"Images\{0}.jpg", numImagen);
            numImagen++;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Slider();
        }
    }
}
