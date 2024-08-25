

namespace Ejercicio4.Models
{
    abstract class Prestacion : Persona
    {
        public double MontoTotal { get; protected set; }
        public Prestador Medico { get; set; }

        public Prestacion(string apn, Prestador medico)
            : base(apn)
        {
            this.Medico = medico;
            this.Medico.AgregarConsulta(this);
        }

        abstract public double PrestarServicio();
    }
}
