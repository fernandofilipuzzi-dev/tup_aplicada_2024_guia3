

namespace Ejercicio3.Models
{
    class Domicilio
    {
        public string Calle { get; set; }

        public int Nro { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }

        public string EnTexto()
        {
            return string.Format("{0}, Nro: {1}, {2}, {3}",
                                   Localidad,
                                   Nro,
                                   Localidad,
                                   Provincia
                                );
        }
    }
}
