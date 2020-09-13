﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.Text = "+";
            this.lblResultado.Text = "Resultado:";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.cmbOperador.SelectedItem == null) 
            {
                this.cmbOperador.SelectedItem = "+";
            }
            this.lblResultado.Text = (Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.SelectedItem.ToString()).ToString()); 
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);

            resultado = Calculadora.Operar(numeroUno, numeroDos, operador);

            return resultado;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text.ToString());
        }
    }
}
