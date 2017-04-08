using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        /// <summary>
        /// Valida que el operador este dentro de los admitidos "+", "-", "*", "/"
        /// </summary>
        /// <param name="operador"> Operador a validar </param>
        /// <returns> Operador validado, en caso de error retorna "+" </returns>
        public static string validarOperador(string operador)
        {
            if (operador != "-" && operador != "*" && operador != "/")
                operador = "+";

            return operador;
        }

        /// <summary>
        /// Opera dos objetos del tipo numero, segun la operacion que se le indique, suma, resta, division, multiplicacion.
        /// </summary>
        /// <param name="numero1"> Primer operando </param>
        /// <param name="numero2"> Segundo operando </param>
        /// <param name="operador"> Operador de operacion </param>
        /// <returns> Resultado de la operacion </returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double ret = 0;

            switch (Calculadora.validarOperador(operador))
            {
                case "-":
                    ret = numero1.getNumero() - numero2.getNumero();
                    break;
                case "/":
                    if (numero2.getNumero() == 0)
                        break;
                    ret = numero1.getNumero() / numero2.getNumero();
                    break;
                case "*":
                    ret = numero1.getNumero() * numero2.getNumero();
                    break;
                default:
                    ret = numero1.getNumero() + numero2.getNumero();
                    break;
            }
            return ret;
        }
    }
}
