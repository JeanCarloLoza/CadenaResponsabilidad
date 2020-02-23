using System;
using System.Collections.Generic;
using System.Text;

namespace CadenaResponsabilidad
{
    class NivelGerente : ICadenaResponsabilidad
    {
        ICadenaResponsabilidad siguiente;
        public void asignarSiguiente(ICadenaResponsabilidad nivel)
        {
            siguiente = nivel;
        }

        public void calcular(double monto, string concepto)
        {
            if (monto <= 10000)
            {
                Console.WriteLine("{0} \"AUTORIZADA\" por el Gerente", concepto);
            }
            else
            {
                if (siguiente != null)
                {
                    siguiente.calcular(monto, concepto);
                }

            }
        }
    }
}
