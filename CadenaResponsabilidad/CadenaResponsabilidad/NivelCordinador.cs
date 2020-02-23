using System;
using System.Collections.Generic;
using System.Text;

namespace CadenaResponsabilidad
{
    class NivelCordinador : ICadenaResponsabilidad
    {
        ICadenaResponsabilidad siguiente;
        public void asignarSiguiente(ICadenaResponsabilidad nivel)
        {
            siguiente = nivel;
        }

        public void calcular(double monto, string concepto)
        {
            if (monto <= 5000)
            {
                Console.WriteLine("{0} \"AUTORIZADA\" por el Cordinador", concepto);
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
