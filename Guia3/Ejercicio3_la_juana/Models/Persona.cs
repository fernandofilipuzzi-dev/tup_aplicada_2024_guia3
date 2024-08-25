
namespace Ejercicio3.Models
{
    class Persona
    {
        public int DNI { get; set; }

        public string Apellidos { get; set; }
        public string Nombres { get; set; }

        private int edad;
        public int Edad()
        {
            return edad;
        }

        public Persona(string apellidos, string nombres,
                              int dni, int edad)
        {
            this.DNI = dni;
            this.Apellidos = apellidos;
            this.Nombres = nombres;
            this.edad = edad;
        }
    }
}
