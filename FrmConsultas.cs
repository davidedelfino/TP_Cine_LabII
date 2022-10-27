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
    public partial class FrmConsultas : Form
    {
        private DBHelper oDatos;

        public FrmConsultas()
        {
            InitializeComponent();
            oDatos=new DBHelper();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private DataTable tabla = new DataTable();

        private void cboConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cboConsultas.SelectedIndex==0)
            {
                rtxtDescripcion.Text = "Muestra los clientes que compraron más de 3 veces entradas para películas de drama.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = tabla;
                chFiltro.Enabled = false;
                chFiltro.Checked = false;

            }
            if(cboConsultas.SelectedIndex==1)
            {
                rtxtDescripcion.Text = "Muestra la cantidad total de asistencias a funciones por cada tipo de cliente en las cuales se proyectaron películas de terror entre los años 2000 y 2010 \r\n \r\n NOTA: Puede modificar el intérvalo de años";
                chFiltro.Enabled = true;
                dgvConsultas.DataSource = tabla;
               
                
            }
            if (cboConsultas.SelectedIndex == 2)
            {
                rtxtDescripcion.Text = "Muestra cuándo realizo la última compra cada cliente y su importe total realizado (cantidad de comprobantes abonados), siempre que el importe total sea mayor\r\n al importe promedio general.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = tabla;
                chFiltro.Enabled = false;
                chFiltro.Checked = false;
            }
            if (cboConsultas.SelectedIndex == 3)
            {
                rtxtDescripcion.Text = "Emite un listado de peliculas que no se hayan trasmitido este año.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = tabla;
                chFiltro.Enabled = false;
                chFiltro.Checked = false;
            }
            if (cboConsultas.SelectedIndex == 4)
            {
                rtxtDescripcion.Text = "Lista los clientes que hayan abonado en efectivo funciones que tuvieron promoción con 70% de descuento.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = tabla;
                chFiltro.Enabled = false;
                chFiltro.Checked = false;
            }
            if (cboConsultas.SelectedIndex == 5)
            {
                rtxtDescripcion.Text = "Muestra cuánto fue el total anual facturado por cada cliente, para los casos en que el nombre no comience con ‘M’, que los números de reservas oscilen entre 10 y 55 y que el promedio del monto facturado sea inferior al promedio de ese año ordenado por cliente.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = tabla;
                chFiltro.Enabled = false;
                chFiltro.Checked = false;
            }
            if (cboConsultas.SelectedIndex == 6)
            {
                rtxtDescripcion.Text = "Muestra la fecha de la primera venta de cada reserva, el importe total facturado por cliente para los años menores a 2015 y el importe promedio facturado sea \r\nmenor a 3000.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = tabla;
                chFiltro.Enabled = false;
                chFiltro.Checked = false;
            }
            if (cboConsultas.SelectedIndex == 7)
            {
                rtxtDescripcion.Text = "Lista la cantidad de tickets, el importe y promedio vendido por fecha, siempre que incluya más de 5 funciones.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = tabla;
                chFiltro.Enabled = false;
                chFiltro.Checked = false;
            }
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboConsultas.SelectedIndex == 0)
            {
                dgvConsultas.DataSource = oDatos.ConsultarDB("pa_consulta_1");
                this.dgvConsultas.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;

            }
            if (cboConsultas.SelectedIndex == 1)
            {
                
                if(chFiltro.Checked==true)
                {
                    dtp1.Enabled = true;
                    dtp2.Enabled = true;
                    DataTable tabla1;
                    tabla1= oDatos.ConsultarDB("pa_consulta_2_filtro", Convert.ToDateTime(dtp1.Value), Convert.ToDateTime(dtp2.Value));
                    if(tabla1.Rows.Count==0)
                    {
                        MessageBox.Show("No hay registros cargados");
                        dgvConsultas.DataSource = tabla;
                    }
                    else
                    {
                        dgvConsultas.DataSource=tabla1;
                        this.dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                 
                }
                else
                {
                    dgvConsultas.DataSource = oDatos.ConsultarDB("pa_consulta_2");
                    this.dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            if (cboConsultas.SelectedIndex == 2)
            {
                rtxtDescripcion.Text = "Muestra cuándo realizo la última compra cada cliente y su importe total realizado (cantidad de comprobantes abonados), siempre que el importe total sea mayor\r\n al importe promedio general.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = oDatos.ConsultarDB("pa_consulta_3");
                this.dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (cboConsultas.SelectedIndex == 3)
            {
                rtxtDescripcion.Text = "Emite un listado de peliculas que no se hayan trasmitido este año.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = oDatos.ConsultarDB("pa_consulta_4");
                this.dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (cboConsultas.SelectedIndex == 4)
            {
                rtxtDescripcion.Text = "Lista los clientes que hayan abonado en efectivo funciones que tuvieron promoción con 70% de descuento.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = oDatos.ConsultarDB("pa_consulta_5");
                this.dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (cboConsultas.SelectedIndex == 5)
            {
                rtxtDescripcion.Text = "Muestra cuánto fue el total anual facturado por cada cliente, para los casos en que el nombre no comience con ‘M’, que los números de reservas oscilen entre 10 y 55 y que el promedio del monto facturado sea inferior al promedio de ese año ordenado por cliente.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = oDatos.ConsultarDB("pa_consulta_6");
                this.dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (cboConsultas.SelectedIndex == 6)
            {
                rtxtDescripcion.Text = "Muestra la fecha de la primera venta de cada reserva, el importe total facturado por cliente para los años menores a 2015 y el importe promedio facturado sea \r\nmenor a 3000.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = oDatos.ConsultarDB("pa_consulta_7");
                this.dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (cboConsultas.SelectedIndex == 7)
            {
                rtxtDescripcion.Text = "Lista la cantidad de tickets, el importe y promedio vendido por fecha, siempre que incluya más de 5 funciones.";
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dgvConsultas.DataSource = oDatos.ConsultarDB("pa_consulta_8");
                this.dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void chFiltro_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarFechas();
        }

        private void HabilitarFechas()
        {
            if(chFiltro.Checked==true)
            {
                dtp1.Enabled = true;
                dtp2.Enabled = true;
            }
            else
            {
                dtp1.Enabled = false; ;
                dtp2.Enabled = false; ;
            }
        }
    }
}
