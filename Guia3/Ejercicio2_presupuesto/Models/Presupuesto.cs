using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Presupuesto
    {

        ArrayList presupuestados = new ArrayList();
        public string Cliente { get; private set; }
        public string Direccion { get; private set; }
        public int CantidadProductos
        {
            get
            {
                return presupuestados.Count;
            }
        }
        public double CostoTotal
        {
            get
            {
                double costo = 0;
                foreach (Producto p in presupuestados)
                {
                    costo += p.CalcularPrecio();
                }
                return costo;
            }
        }
        
        public Presupuesto(string cliente, string direccion)
        {
            Cliente = cliente;
            Direccion = direccion;
        }

        public void AgregarProducto(Producto nuevo)
        {
            presupuestados.Add(nuevo);
            //acá tambien podrían acumular el costo total
            //los que lo hicieron así esta bien, salvo aparecen
            //casteos e if inecesarios.
            //CostoTotal+=nuevo.CalcularPrecio();
            //en este ejemplo lo hice en el getter de CostoTotal
        }
        public Producto VerProducto(int idx)
        {
            if(idx>=0 && idx<CantidadProductos)
                return presupuestados[idx] as Producto;
            return null;
        }

    }
}
