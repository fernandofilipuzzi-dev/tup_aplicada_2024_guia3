

namespace Ejercicio4.Models
{
    abstract class Persona
    {
        public string ApellidosNombre { get; set; }

        public Persona(string apn)
        {
            ApellidosNombre = apn;
        }
    }
}
