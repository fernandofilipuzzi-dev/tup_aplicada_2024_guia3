
using System;
using System.Windows.Forms;
using System.Collections;
using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        Presupuesto presupuesto;

        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void btnIniciarPresupuesto_Click(object sender, EventArgs e)
        {
            FormDatosCliente fCliente = new FormDatosCliente();
            if (fCliente.ShowDialog() == DialogResult.OK)
            {
                string nombre = fCliente.tbNombre.Text;
                string direccion = fCliente.tbDireccion.Text;
                presupuesto = new Presupuesto(nombre, direccion);
                lbCliente.Text = nombre;
                lbDireccion.Text = direccion;

                #region
                btnAgregarProducto.Enabled = true;
                btnVerPresupuesto.Enabled = true;
                btnIniciarPresupuesto.Enabled = false;
                #endregion
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormDatosProducto fDatos = new FormDatosProducto();
            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                int tipoProducto = fDatos.cbTipoProducto.SelectedIndex;
                double precioBase = Convert.ToDouble(fDatos.tbPrecioBase.Text);
                string descripcion = fDatos.tbDescripcion.Text;
                int tipoMaterial = fDatos.cbTipoMaterial.SelectedIndex;

                Producto nuevo = null;
                if (tipoProducto == 0)
                {
                    nuevo = new Silla(descripcion, precioBase, tipoMaterial);

                }
                else if (tipoProducto == 1)
                {
                    double largo = Convert.ToDouble(fDatos.tbLargo.Text);
                    nuevo = new Mesa(descripcion, precioBase, tipoMaterial, largo);
                }

                if (nuevo != null)
                    presupuesto.AgregarProducto(nuevo);
            }
            fDatos.Dispose();
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            FormVer formVer = new FormVer();

            formVer.tbVer.Clear();

            formVer.tbVer.Text += $@"Cliente: {presupuesto.Cliente}
    Dirección: {presupuesto.Direccion}

    Items presupuestados:
    ";

            for (int n = 0; n < presupuesto.CantidadProductos; n++)
            {
                Producto producto = presupuesto.VerProducto(n);

                formVer.tbVer.Text += $"{producto.VerDetalle()}\r\n";
            }
            formVer.tbVer.Text += $"Total:{presupuesto.CostoTotal,54:f2}";

            formVer.ShowDialog();
            formVer.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
