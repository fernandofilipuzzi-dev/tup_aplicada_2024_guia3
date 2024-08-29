

namespace Ejercicio4.Models
{
    abstract class Persona
    {
        public string ApellidosNombres { get; set; }

        public Persona(string apellidosNombres)
        {
            ApellidosNombres = apellidosNombres;
        }
    }
}
