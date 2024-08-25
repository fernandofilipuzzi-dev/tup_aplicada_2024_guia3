

namespace Ejercicio2.Models
{
    public class Silla:Producto
    {
        public Silla(string descripcion, double precioBase, int tipoMaterial) : base(descripcion, precioBase,tipoMaterial)
        {
        }

        override public double CalcularPrecio()
        {
            return precioBase * (1 + tipoMaterial * 0.25);
        }

        override public string VerDetalle()
        {
            string tipoProducto = "Silla";
            return $"{base.VerDetalle()}{tipoProducto,15}{CalcularPrecio(),10:f2}";
        }
    }
}
