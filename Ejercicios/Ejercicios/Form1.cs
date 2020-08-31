using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Recuperando la informacion ingresada
            string empleado = txbEmpleado.Text;
            int horas = int.Parse(txbHoras.Text);
            double costo = double.Parse(txbCosto.Text);

            //Calculos
            double sueldoBasico = horas * costo;
            double bonificacion = 20.0 / 100 * sueldoBasico;
            double sueldoBruto = sueldoBasico + bonificacion;
            double descuento = sueldoBruto * 12.0 / 100;
            double sueldoNeto = sueldoBruto - descuento;

            // Imprimimos resultados 
            lblMontoBruto.Text = sueldoBruto.ToString();
            lblMontoDescuento.Text = descuento.ToString();
            lblMontoNeto.Text = sueldoNeto.ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbEmpleado.Clear();
            txbHoras.Clear();
            txbCosto.Clear();
            lblMontoNeto.Text = "";
            lblMontoBruto.Text = "";
            lblMontoDescuento.Text = "";
            txbEmpleado.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro ?",
                "Control de pago", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
