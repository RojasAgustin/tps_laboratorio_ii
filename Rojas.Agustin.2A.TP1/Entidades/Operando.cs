using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Constructor por defecto de la clase
        /// </summary>
        public Operando() : this(0)
        {

        }

        /// <summary>
        /// Sobrecarga del constructor que asigna el valor que recibe por parametro al atributo numero
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Sobrecarga del constructor que llama a la propiedad Numero 
        /// para asignar el valor que recibe por parametro
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        /// <summary>
        /// Propiedad que asigna un valor al atributo numero 
        /// luego de validarlo
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Convierte el numero binario que recibe por parametero
        /// a un numero decimal y lo devuelve.
        /// </summary>
        /// <param name="binario">El numero binario a convertir</param>
        /// <returns>El numero binario convertido a decimal </returns>
        public string BinarioDecimal(string binario)
        {
            string decimalRetorno = "Valor invalido";
            int auxBinario;
            int auxDecimal = 0;
            int auxBase = 1;
            int resto;

            if (EsBinario(binario))
            {
                auxBinario = int.Parse(binario);
                if (auxBinario > 0)
                {
                    while (auxBinario > 0)
                    {
                        resto = auxBinario % 10;
                        auxBinario /= 10;
                        auxDecimal += resto * auxBase;
                        auxBase *= 2;
                    }
                    decimalRetorno = auxDecimal.ToString();
                }
            }
            return decimalRetorno;
        }

        /// <summary>
        /// Convierte el numero decimal que recibe por parametro
        /// a un numero binario y lo devuelve
        /// </summary>
        /// <param name="numero">El numero decimal</param>
        /// <returns>El numero decimal convertido a binario</returns>
        public string DecimalBinario(double numero)
        {
            string binarioRetorno = "Valor invalido";
            int resto;
            string auxBinario = "";
            if(numero > 0)
            {
                binarioRetorno = "";
                while(numero > 0)
                {
                    resto = (int)numero / 2;
                    auxBinario += (numero % 2).ToString();
                    numero = resto;
                }

                for (int i = auxBinario.Length - 1; i >= 0; i--)
                {
                    binarioRetorno += auxBinario[i];
                }
            }
            return binarioRetorno;
        }

        /// <summary>
        /// Sobrecarga del metodo DecimalBinario con una cadena como parametro
        /// Si no es un numero, se le asigna -1 para que el retorno sea "Valor invalido"
        /// </summary>
        /// <param name="numero">El numero decimal</param>
        /// <returns>El numero decimal convertido a binario</returns>
        public string DecimalBinario(string numero)
        {
            double auxNumero;
            if(!double.TryParse(numero,out auxNumero))
            {
                auxNumero = -1; //Para que devuelva "Valor invalido" (asi hay un solo return).
            }
            return DecimalBinario(auxNumero);
        }

        /// <summary>
        /// Revisa que la cadena que recibe como parametro sea un numero binario
        /// </summary>
        /// <param name="binario">El numero binario</param>
        /// <returns>true si esta compuesto por solo unos y ceros. false de no ser asi</returns>
        private bool EsBinario(string binario)
        {
            bool esBinario = true;
            for (int i = 0; i < binario.Length; i++)
            {
                if(binario[i] != '0' && binario[i] != '1' && binario[i] != '\n')
                {
                    esBinario = false;
                    break;
                }
            }
            return esBinario;
        }
        
        /// <summary>
        /// Sobrecarga del operador + que permite sumar dos objetos de tipo Operando
        /// sumando el atributo numero de ambos y devolviendo el resultado
        /// </summary>
        /// <param name="n1">El objeto de tipo Operando uno</param>
        /// <param name="n2">El objeto de tipo Operando dos</param>
        /// <returns>El resultado de la suma</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            double resultado = n1.numero + n2.numero;
            return resultado;
        }

        /// <summary>
        /// Sobrecarga del operador - que permite restar dos objetos de tipo Operando
        /// restando el atributo numero de ambos y devolviendo el resultado
        /// </summary>
        /// <param name="n1">El objeto de tipo Operando uno</param>
        /// <param name="n2">El objeto de tipo Operando dos</param>
        /// <returns>El resultado de la resta</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            double resultado = n1.numero - n2.numero;
            return resultado;
        }

        /// <summary>
        /// Sobrecarga del operador * que permite multiplicar dos objetos de tipo Operando
        /// multiplicando el atributo numero de ambos y devolviendo el resultado
        /// </summary>
        /// <param name="n1">El objeto de tipo Operando uno</param>
        /// <param name="n2">El objeto de tipo Operando dos</param>
        /// <returns>El resultado de la multiplicacion</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            double resultado = n1.numero * n2.numero;
            return resultado;
        }

        /// <summary>
        /// Sobrecarga del operador / que permite dividir dos objetos de tipo Operando
        /// dividiendo el atributo numero de ambos y devolviendo el resultado
        /// si el segundo operador es un 0 devuelve double.MinValue
        /// </summary>
        /// <param name="n1">El objeto de tipo Operando uno</param>
        /// <param name="n2">El objeto de tipo Operando dos</param>
        /// <returns>El resultado de la division</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double resultado;
            if(n2.numero != 0)
            {
                resultado = n1.numero / n2.numero;
            }
            else
            {
                resultado = double.MinValue;
            }
            return resultado;
        }

        /// <summary>
        /// Valida que la cadena que recibe por parametro sea un numero,
        /// la parsea al tipo de dato double y la devuelve
        /// Si no es un numero devuelve 0
        /// </summary>
        /// <param name="strNumero">La cadena a validar</param>
        /// <returns>El numero como double. 0 si la cadena no es numero.</returns>
        private double ValidarOperando(string strNumero)
        {
            bool esNumerico;
            esNumerico = double.TryParse(strNumero, out double numeroRetorno);
            if (!esNumerico)
            {
                numeroRetorno = 0;
            }
            return numeroRetorno;
        }
    }
}
