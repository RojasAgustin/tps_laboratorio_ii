using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public interface IImpuestoPAIS
    {
        /// <summary>
        /// Metodo para aplicar el impuesto PAIS.
        /// Devuelve el valor del impuesto.
        /// </summary>
        /// <returns></returns>
        double CalcularImpuesto();
    }
}
