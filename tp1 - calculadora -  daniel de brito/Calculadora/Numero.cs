using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Numero
    {
        private double _numero;

        /// <summary>
        /// Constructor de objeto numero
        /// </summary>
        public Numero()
            : this(0)
        {
        }

        /// <summary>
        /// Constructor de objeto numero
        /// </summary>
        /// <param name="numero"> Valor de numero </param>
        public Numero(double numero)
        {
            this._numero = numero;
        }

        /// <summary>
        /// Construcctor de objeto numero
        /// </summary>
        /// <param name="numero"> Valor de numero </param>
        public Numero(string numero)
        {
            this._setNumero(numero);
        }

        /// <summary>
        /// Obtiene un numero
        /// </summary>
        /// <returns></returns>
        public double getNumero()
        {
            return this._numero;
        }

        /// <summary>
        /// Establece un double validado
        /// </summary>
        /// <param name="numeroString"></param>
        private void _setNumero(string numeroString)
        {
            this._numero = Numero._validarNumero(numeroString);
        }

        /// <summary>
        /// Valida un objeto numero
        /// </summary>
        /// <param name="numeroString"> Valor del numero a validar y parsear </param>
        /// <returns> Numero validado y parseado </returns>
        private static double _validarNumero(string numeroString)
        {
            double ret;

            if (!(double.TryParse(numeroString, out ret)))
                ret = 0;

            return ret;
        }
    }
}