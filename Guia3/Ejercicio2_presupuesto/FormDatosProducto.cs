using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormDatosProducto : Form
    {
        public FormDatosProducto()
        {
            InitializeComponent();
        }

        private void cbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbLargo.Enabled = cbTipoProducto.SelectedIndex == 1;
        }
    }
}
