using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarFecha();
            mostrarMesActual();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string empleado = txbEmpleado.Text;
            string cargo = cbCargo.Text;
            DateTime fechaIngreso = dtFechaIngreso.Value;
            int anios = int.Parse(txbAnios.Text);

            Planilla pj = new Planilla();
            pj.empleado = empleado; 
            pj.cargo = cargo;
            pj.fechaIngreso = fechaIngreso;
            pj.anios = anios;

            //Impresion de valores
            txbMesConsultado.Text = pj.mesConsultado();
            lblSueldoBasico.Text = pj.determinaSueldoBasico().ToString("$0.00");
            lblGratificacion.Text = pj.determinaGratificacion().ToString("$0.00");
            lblComision.Text = pj.determinaComision().ToString("$0.00");
            lblAFP.Text = pj.determinaAFP().ToString("$0.00");
            lblCooperativa.Text = pj.determinaDescuentoCooperativa().ToString("$0.00");
            lblSeguro.Text = pj.determinaSeguro().ToString("$0.00");

            lblTotalIngresos.Text = pj.calculaTotalIngresos().ToString("$0.00");
            lblTotalDescuentos.Text = pj.calculaTotalDescuentos().ToString("$0.00");
            lblTotalAportaciones.Text = pj.calculaTotalAportaciones().ToString("$0.00");

            lblTotalNeto.Text = pj.determinaNeto().ToString("$0.00");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txbEmpleado.Clear();
            dtFechaIngreso.Value = DateTime.Now;
            cbCargo.Text = "(Seleccione cargo)";
            txbMesConsultado.Clear();
            txbAnios.Clear();

            lblSueldoBasico.Text = (0).ToString("$0.00");
            lblGratificacion.Text = (0).ToString("$0.00");
            lblComision.Text = (0).ToString("$0.00");
            lblAFP.Text = (0).ToString("$0.00");
            lblCooperativa.Text = (0).ToString("$0.00");
            lblSeguro.Text = (0).ToString("$0.00");

            lblTotalAportaciones.Text = (0).ToString("$0.00");
            lblTotalDescuentos.Text = (0).ToString("$0.00");
            lblTotalIngresos.Text = (0).ToString("$0.00");
            lblTotalNeto.Text = (0).ToString("$0.00");

            txbEmpleado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Seguro que desea salir?", "Pagos", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }



        public void mostrarFecha()
        {
            lblFechaActual.Text = DateTime.Now.ToShortDateString();
        }

        public void mostrarMesActual()
        {
            txbMesConsultado.Text = DateTime.Now.Month.ToString();
        }

        private void dtFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            txbAnios.Text = (DateTime.Now.Year - dtFechaIngreso.Value.Year).ToString();
        }
    }
}
