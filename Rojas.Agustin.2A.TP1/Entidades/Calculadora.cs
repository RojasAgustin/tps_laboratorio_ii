using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operacion con los parametros recibidos y la devuelve
        /// </summary>
        /// <param name="num1">El primer operando</param>
        /// <param name="num2">El segundo operando</param>
        /// <param name="operador">El tercer operando</param>
        /// <returns>El resultado de la operacion</returns>
        public static double Operar(Operando num1, Operando num2,char operador)
        {
            double resultado;
            switch (ValidarOperador(operador))
            {
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
        }
        
        /// <summary>
        /// Valida que el operador que recibe por parametro sea valido
        /// De no serlo devuelve '+'
        /// </summary>
        /// <param name="operador">El operador</param>
        /// <returns>El operador ya validado</returns>
        private static char ValidarOperador(char operador)
        {
            char operadorRetorno;
            switch (operador)
            {
                case '-':
                    operadorRetorno = '-';
                    break;
                case '*':
                    operadorRetorno = '*';
                    break;
                case '/':
                    operadorRetorno = '/';
                    break;
                default:
                    operadorRetorno = '+';
                    break;
            }
            return operadorRetorno;
        }
    }
}
