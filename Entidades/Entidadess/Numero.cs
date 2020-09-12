using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        double numero;

        public string SetNumero { set { numero = validarNumero(value); } }
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.numero = validarNumero(strNumero);
        }

        double validarNumero(string strNumero)
        {
            double auxNumero;

            if (!(double.TryParse(strNumero, out auxNumero)))
                auxNumero = 0;

            return auxNumero;
        }

        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1.numero + numero2.numero;
        }

        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1.numero - numero2.numero;
        }

        public static double operator *(Numero numero1, Numero numero2)
        {
            return numero1.numero * numero2.numero;
        }

        public static double operator /(Numero numero1, Numero numero2)
        {
            if (numero2.numero == 0)
                return double.MinValue;
            else
                return numero1.numero / numero2.numero;

        }

        public static string BinarioDecimal(string binario)
        {
            string numeroBinario = "Valor invalido";
            if (esBinario(binario)) 
            {
                numeroBinario = Convert.ToInt32(binario, 2).ToString();
            }
            return numeroBinario;
        }

        public static string DecimalBinario(double numero)
        {
            string resultado = "";
            int numeroInt = (int)numero;

            if (numeroInt > 0)
            {
                while (numeroInt > 0)
                {
                    if (numeroInt % 2 == 0)
                    {
                        resultado = "0" + resultado;
                    }
                    else
                    {
                        resultado = "1" + resultado;
                    }

                    numeroInt = numeroInt / 2;
                }
            }
            else
            {
                resultado = "Valor invalido";
            }
            return resultado;
        }

        public static string DecimalBinario(string numero)
        {
            string resultado;
            double numeroDouble;

            if (double.TryParse(numero, out numeroDouble))
            {
                resultado = DecimalBinario(numeroDouble);
            }
            else
            {
                resultado = "Valor invalido";
            }
            return resultado;
        }

        static bool esBinario(string binario)
        {
            bool retorno = true;
            char[] arrayBinario = binario.ToCharArray();

            for (int i = 0; i < arrayBinario.Length; i++)
            {
                if (arrayBinario[i] != '0' && arrayBinario[i] != '1')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
    }
}
