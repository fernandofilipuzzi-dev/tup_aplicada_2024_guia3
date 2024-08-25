

namespace Ejercicio3.Models
{
    class Medidor
    {
        public int NroMedidor { get; set; }
        public int LecturaAnterior { get; set; }

        int lecturaActual;
        public int LecturaActual
        {
            get
            {
                return this.lecturaActual;
            }
            set
            {
                //podría salvar la lectura anterior.
                //pero se lo voy a delegar a otra clase
                //this.LecturaAnterior= this.lecturaActual;
                this.lecturaActual = value;
            }
        }

        public int ConsumoActual()
        {
            return LecturaActual - LecturaAnterior;
        }

        public void Medicion(int lectura)
        {
            LecturaActual = lectura;
        }
    }
}
