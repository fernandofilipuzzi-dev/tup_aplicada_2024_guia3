

using System.Collections;

namespace Ejercicio4.Models
{
    class Prestador : Persona
    {
        //son todas las consultas de ese mes
        ArrayList consultas = new ArrayList();

        public Prestador(string apellidosNombres)
            : base(apellidosNombres)
        {
        }

        public void AgregarConsulta(Prestacion nuevaConsulta)
        {
            consultas.Add(nuevaConsulta);
        }

        public double GenerarPago()
        {
            double monto = 0;
            foreach (Prestacion consulta in consultas)
            {
                monto += consulta.MontoTotal;
            }
            return monto;
        }
    }
}
