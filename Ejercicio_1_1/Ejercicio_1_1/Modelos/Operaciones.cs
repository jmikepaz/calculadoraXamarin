using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1_1.modulo
{
    public class Operaciones
    {
 
        public Decimal Numero1 { get; set; }
        public Decimal Numero2 { get; set ; }

        public Decimal sumar()
        {

            return Numero1 + Numero2;
        }

        public Decimal restar( )
        {

            return Numero1 - Numero2;
        }

        public Decimal dividir( )
        {
          decimal resultado = 0;
          if (Numero2 > 0)
          {
            resultado =  Numero1 / Numero2;
          }

      return resultado;
        }

        public Decimal multiplicar( )
        {

            return Numero1 * Numero2;
        }

    }


}
