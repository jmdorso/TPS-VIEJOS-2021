using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MICalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Realiza operacion aritmetica entre 2 numeros
        /// </summary>
        /// <param name="numero1">primer operando (string)</param>
        /// <param name="numero2">segundo operando (string)</param>
        /// <param name="operador">el operador de la cuenta a realizar</param>
        /// <returns>retorna un double como resultado de la cuenta</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double valorRetorno;

            Numero numeroAux1 = new Numero(numero1);
            Numero numeroAux2 = new Numero(numero2);

            valorRetorno = Calculadora.Operar(numeroAux1, numeroAux2, operador);

            return valorRetorno;

        }

        /// <summary>
        /// Le da funcionalidad al boton operar, para que al hacer click, realice la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.cmbOperador.SelectedItem == null)
            {
                this.cmbOperador.Text = "+";
            }
            lblResultado.Text = FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
        }

        /// <summary>
        /// Limpia los cuadros de texto, el combobox de operadores y el label de resultado. 
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = String.Empty;
            this.txtNumero2.Text = String.Empty;
            this.cmbOperador.SelectedItem = null;
            this.lblResultado.Text = String.Empty;
        }

        /// <summary>
        /// Le da funcionalidad al boton limpiar, para que al hacer click, limpie todo lo ingresado. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Le da funcionalidad al boton cerrar, para que al hacer click, cierre la calculadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Le da funcionalidad al boton convertir a binario, para que al hacer click, si es posible, realice la conversion a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != String.Empty && this.lblResultado.Text != "Valor Invalido")
            {
                this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
            }
        }
        /// <summary>
        /// Le da funcionalidad al boton convertir a decimal, para que al hacer click, si es posible, realice la conversion a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != String.Empty && this.lblResultado.Text != "Valor Invalido")
            {
                this.lblResultado.Text = new Numero().BinarioDecimal(this.lblResultado.Text);
            }
        }

        /// <summary>
        /// Agrego este metodo para que en caso de apretar enter despues de cargar el primer numero, se diriga al combobox para elegir operador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.cmbOperador.Focus();
            }
        }

        /// <summary>
        /// Agrego este metodo para que en caso de apretar enter despues de elegir el operador, se diriga a cargar el 2do numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbOperador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.txtNumero2.Focus();
            }
        }

        /// <summary>
        /// Agrego este metodo, ya que despues de apretar enter en el segundo numero, realice la operacion. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.btnOperar.PerformClick();
            }
        }

        
    }
}
