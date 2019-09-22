using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {

        //Instancia de una clase
        Matematica matematica = new Matematica();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            matematica.setNumero1(double.Parse(txtnumero1.Text));
            matematica.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Text = "Resultado: " + matematica.Sumar().ToString();
            txtnumero1.Focus();
            lblresultado.Visible = true;
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            matematica.setNumero1(double.Parse(txtnumero1.Text));
            matematica.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Text = "Resultado: " + matematica.Restar().ToString();
            txtnumero1.Focus();
            lblresultado.Visible = true;
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            matematica.setNumero1(double.Parse(txtnumero1.Text));
            matematica.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Text = "Resultado: " + matematica.Multiplicar().ToString();
            txtnumero1.Focus();
            lblresultado.Visible = true;
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            matematica.setNumero1(double.Parse(txtnumero1.Text));
            matematica.setNumero2(double.Parse(txtnumero2.Text));
            lblresultado.Text = "Resultado: " + matematica.Dividir().ToString();
            txtnumero1.Focus();
            lblresultado.Visible = true;
        }
    }
}
