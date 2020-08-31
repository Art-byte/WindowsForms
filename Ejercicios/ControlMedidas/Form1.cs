using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlMedidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbMetros.Clear();
            lstR.Items.Clear();
            txbMetros.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Medidas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //capturando valor en metros
            double metros = double.Parse(txbMetros.Text);

            //Conversiones
            double centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pies / 3;

            //Mostrando resultados
            lstR.Items.Add("**RESUMEN DE CONVERSIONES**");
            lstR.Items.Add("MEDIDA EN METROS: " + metros.ToString("0.00"));
            lstR.Items.Add("--------------------------");
            lstR.Items.Add("MEDIDA EN CENTIMETROS: " + centimetros.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN PULGADAS: " + pulgadas.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN PIES: " + pies.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN YARDAS: " + yardas.ToString("0.00"));
        }
    }
}
