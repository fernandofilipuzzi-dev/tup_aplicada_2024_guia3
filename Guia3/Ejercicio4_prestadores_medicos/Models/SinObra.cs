

namespace Ejercicio4.Models
{
    class SinObra : Prestacion
    {
        public string CUIT { get; set; }
        public double ImporteFijo { get; set; }

        public SinObra(string apn, string cuit, Prestador medico)
            : base(apn, medico)
        {
            this.CUIT = cuit;
            ImporteFijo = 250;
            this.Medico.AgregarConsulta(this);
        }
        override public double PrestarServicio()
        {
            MontoTotal += ImporteFijo;
            return ImporteFijo;
        }
    }
}
