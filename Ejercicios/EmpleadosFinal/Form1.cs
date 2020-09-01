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
            lblAFP.Text = pj.determinaAFP().ToString();


        }
    }
}
