
namespace Ejercicio1.Models
{
    public class Mesa : Producto
    {
        double largo;

        public Mesa(string descripcion, double precioBase, int tipoMaterial, double largo) : base(descripcion, precioBase, tipoMaterial)
        {
            this.largo = largo;
        }

        override public double CalcularPrecio()
        {
            return (precioBase * largo) * (1 + tipoMaterial * 0.33);
        }

        override public string VerDetalle()
        {
            string tipoProducto = $"Mesa({largo:f1})";
            return $"{base.VerDetalle()}{tipoProducto,15}{CalcularPrecio(),10:f2}";
        }
    }
}
