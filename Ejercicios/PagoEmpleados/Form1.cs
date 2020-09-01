using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoEmpleados
{
    public partial class Form1 : Form
    {
        double sueldo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string empleado = txbEmpleado.Text;
            string categoria = cbCategoria.Text;

            //Calculos
            double descuento = 0;
            if (sueldo > 2000) descuento = sueldo * (12.5 / 100);

            double neto = sueldo - descuento;

            //Imprimiendo resultados
            ListViewItem fila = new ListViewItem(empleado);
            fila.SubItems.Add(categoria);
            fila.SubItems.Add(sueldo.ToString("C"));
            fila.SubItems.Add(descuento.ToString("C"));
            fila.SubItems.Add(neto.ToString("C"));
            lvPagos.Items.Add(fila);

            btnCancelar_Click(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro que desea salir?", "Control",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbCategoria.Text = "(Seleccione)";
            txbEmpleado.Clear();
            txbEmpleado.Focus();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Capturamos valores de la categoria 
            string categoria = cbCategoria.Text;

            //Asignando de acuerdo a la categoria 
            if (categoria == "Jefe") sueldo = 3500;
            if (categoria == "Administrativo") sueldo = 2500;
            if (categoria == "Tecnico") sueldo = 1700;
            if (categoria == "Operario") sueldo = 1000;

            lblSueldo.Text = sueldo.ToString("0.00");
        }
    }
}
