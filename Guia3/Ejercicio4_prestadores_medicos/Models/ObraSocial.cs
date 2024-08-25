

namespace Ejercicio4.Models
{
    class ObraSocial : Prestacion
    {
        public int ConsultasMensuales { get; set; }
        public double Arancel { get; set; }

        public ObraSocial(string apn, Prestador medico)
            : base(apn, medico)
        {
            Arancel = 200;
            ConsultasMensuales = 0;
        }

        override public double PrestarServicio()
        {
            MontoTotal += Arancel;

            double monto = 0;
            ConsultasMensuales++;
            if (ConsultasMensuales > 2)
                monto = Arancel;

            return monto;
        }
    }
}
