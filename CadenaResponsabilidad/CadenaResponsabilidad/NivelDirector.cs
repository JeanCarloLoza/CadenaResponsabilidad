using System;
using System.Collections.Generic;
using System.Text;

namespace CadenaResponsabilidad
{
    class NivelDirector : ICadenaResponsabilidad
    {
        ICadenaResponsabilidad siguiente;
        public void asignarSiguiente(ICadenaResponsabilidad nivel)
        {
            siguiente = nivel;
        }

        public void calcular(double monto, string concepto)
        {
            if (monto <= 50000)
            {
                Console.WriteLine("{0} \"AUTORIZADA\" por el Director", concepto);
            }
            else
            {
                if (siguiente != null)
                {
                    siguiente.calcular(monto, concepto);
                }
                else
                {
                    Console.WriteLine("{0} “DENEGADA”", concepto);
                }

            }
        }
    }
}
