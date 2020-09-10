using System;
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

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.tb_Numero1.Clear();
            this.tb_Numero2.Clear();
            this.cb_Operador.Text = "+";
            this.lbl_Resultado.Text = "Resultado";
        }

        private void btn_Operar_Click(object sender, EventArgs e)
        {
            if (this.cb_Operador.SelectedItem == null) 
            {
                this.cb_Operador.SelectedItem = "+";
            }
            this.lbl_Resultado.Text = Operar(this.tb_Numero1.Text, this.tb_Numero2.Text, this.cb_Operador.SelectedItem.ToString()); 
        }

        private static string Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);

            resultado = Calculadora.Operar(numeroUno, numeroDos, operador);

            return resultado.ToString();

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Binario_Click(object sender, EventArgs e)
        {
            this.lbl_Resultado.Text = Numero.DecimalBinario(this.lbl_Resultado.Text);
        }

        private void btn_Decimal_Click(object sender, EventArgs e)
        {
            this.lbl_Resultado.Text = Numero.BinarioDecimal(this.lbl_Resultado.Text.ToString());
        }
    }
}
