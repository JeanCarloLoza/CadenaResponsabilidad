using System;
using System.Collections.Generic;
using System.Text;

namespace CadenaResponsabilidad
{
    interface ICadenaResponsabilidad
    {
        public void calcular(double monto, string concepto);
        public void asignarSiguiente(ICadenaResponsabilidad nivel);
    }
}
