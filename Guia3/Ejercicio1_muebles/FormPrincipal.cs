using Ejercicio1.Models;
using System;
using System.Windows.Forms;
using System.Collections;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        ArrayList envios = new ArrayList();

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            Mesa nuevaMesa = null;
            double precioBase;
            string descripcion;
            double largo;
            int tipoMaterial;

            //ejemplo 1
            precioBase = 10.1;
            descripcion = "Mesa Comedor";
            largo = 1;
            tipoMaterial = 1;
            nuevaMesa = new Mesa(descripcion, precioBase, tipoMaterial, largo);
            lista.Add(nuevaMesa);
            //fin ejemplo 1

            //ejemplo 2
            precioBase = 12.2;
            descripcion = "Silla";
            tipoMaterial = 2;
            Silla nuevaSilla = new Silla(descripcion, precioBase, tipoMaterial);
            lista.Add(nuevaSilla);
            //fin ejemplo 2

            tbVer.Clear();

            foreach (Producto producto in lista)
            {
                tbVer.Text += $"{producto.VerDetalle()}\r\n";
            }
        }
    }
}
