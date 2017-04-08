using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa los texbox en "", el label resultado en "0.0" y el combox en "".
        /// </summary>
        private void limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "0.0";
            this.cmbOperacion.Text = "";
        }

        /// <summary>
        /// Instancia dos objetos numero, los opera y asigna el resultado a lblResultado.
        /// </summary>
        private void operar()
        {
            Numero numero1 = new Numero(this.txtNumero1.Text);
            Numero numero2 = new Numero(this.txtNumero2.Text);

            this.lblResultado.Text = Calculadora.operar(numero1, numero2, this.cmbOperacion.Text).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.operar();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

    }
}
