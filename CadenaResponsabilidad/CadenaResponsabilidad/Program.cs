using System;

namespace CadenaResponsabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            string monto, concepto;
            double dMonto;
            Console.WriteLine("Ingrese el concepto");
            concepto = Console.ReadLine();
            Console.WriteLine("Ingrese el monto");
            monto = Console.ReadLine();

            dMonto = Double.Parse(monto);

            ICadenaResponsabilidad cordinador= new NivelCordinador();
            ICadenaResponsabilidad gerente= new NivelGerente();
            ICadenaResponsabilidad subdirector= new NivelSubdirector();
            ICadenaResponsabilidad director= new NivelDirector();

            cordinador.asignarSiguiente(gerente);
            gerente.asignarSiguiente(subdirector);
            subdirector.asignarSiguiente(director);

            cordinador.calcular(dMonto, concepto);
        }
    }
}
