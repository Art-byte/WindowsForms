using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Volumen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(txbaAtura.Text);
            double diametro = double.Parse(txbDiametro.Text);

            double radio = diametro / 2;
            double area = (2 * Math.PI * radio) * (radio + altura);
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;


            //Mostrando datos
            txR.Text = "** RESUMEN DE VOLUMEN Y AREAS **";
            txR.Text += "\r\nValor altura: " + altura.ToString("0.00");
            txR.Text += "\r\nValor diametro: " + diametro.ToString("0.00");
            txR.Text += "\r\n---------------------------------------------";
            txR.Text += "\r\nValor radio: " + radio.ToString("0.00");
            txR.Text += "\r\nValor area: " + area.ToString("0.00");
            txR.Text += "\r\nValor volumen: " + volumen.ToString("0.00");




        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbaAtura.Clear();
            txbDiametro.Clear();
            txR.Clear();
            txbaAtura.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro de salir?", "Medidas", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
