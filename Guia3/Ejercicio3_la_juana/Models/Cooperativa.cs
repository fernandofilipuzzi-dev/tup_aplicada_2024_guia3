
using System.Collections;

namespace Ejercicio3.Models
{
    class Cooperativa
    {
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }

        public Domicilio UbicadaEn { get; set; }

        private ArrayList asociado = new ArrayList();

        public Cooperativa(string razonSocial,
                            string Cuit,
                            Domicilio ubicadaEn,
                            Socio socio)
        {
            this.RazonSocial = razonSocial;
            this.Cuit = Cuit;
            this.UbicadaEn = ubicadaEn;
            asociado.Add(socio);
        }

        public void AgregarSocio(Socio nuevo)
        {
            this.asociado.Add(nuevo);
        }
    }
}
