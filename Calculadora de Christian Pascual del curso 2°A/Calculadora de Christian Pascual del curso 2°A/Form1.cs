using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Calculadora_de_Christian_Pascual_del_curso_2_A
{
    public partial class FormCalculadora : Form
    {
        Calculadora calculadora = new Calculadora();
        Operando Operatoria = new Operando();
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox.SelectedIndex;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) 
            {
                Close();
            }

        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, comboBox.Text);

            this.lblResultado.Text = resultado.ToString();
            string mensaje = resultado.ToString();
            lstOperaciones.Items.Add(txtNumero1.Text+" "+comboBox.Text+" "+txtNumero2.Text+" = "+mensaje);
            // lstOperaciones.Items.Add(txtNumero1.Text + " " + cmbOperador.Text + " " + txtNumero2.Text + " = " + mensaje);
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double numeroA;
            double numeroB;

            if (Double.TryParse(numero1, out numeroA) && Double.TryParse(numero2, out numeroB))
            {
                Operando operando1 = new Operando(numero1);

                Operando operando2 = new Operando(numero2);

                return Calculadora.Operar(operando1, operando2, operador[0]);
            }


            return double.NaN;

        }


        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {

            if (lblResultado.Text != "Valor invalido")
            {
                string antes = this.lblResultado.Text;
                string despues = Operatoria.DecimalBinario(double.Parse(lblResultado.Text));
                lstOperaciones.Items.Add(antes + " = " + despues);
                lblResultado.Text = despues;
            }

        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {

           
            string antes = this.lblResultado.Text;
            string despues = Operatoria.BinarioDecimal(antes);
            lstOperaciones.Items.Add(antes + " = " + despues);
            lblResultado.Text = despues;

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar() 
        {
            txtNumero1.Text = null;
            txtNumero2.Text = null;
            lblResultado.Text = null;
            comboBox.Text = null;
        }

    }
}
