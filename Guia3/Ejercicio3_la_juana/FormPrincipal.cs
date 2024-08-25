using System;
using System.Windows.Forms;

using System.Collections;
using Ejercicio3.Models;

namespace Ejercicio3
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Random azar = new Random();

            //creación de servicios
            //cartera de servicios a prestar
            //el servicio consiste de un medidor 
            //      instalado en domicilio
            ArrayList servicios = new ArrayList();
            for (int n = 0; n < 10; n++)
            {
                Medidor mdd = new Medidor();
                mdd.NroMedidor = n;
                Domicilio dmc = new Domicilio();
                //completar domicilio
                Servicio srv = new Servicio(mdd, dmc);

                servicios.Add(srv);
            }

            //creación de socios
            //cartera de socios con su domicilio y su servicio
            ArrayList socios = new ArrayList();
            for (int n = 0; n < 10; n++)
            {
                Domicilio dmc = new Domicilio();
                Socio nuevo = new Socio("apellido" + n,
                                      "nombres" + n,
                                       n,
                                       azar.Next(4564554, 12556466),
                                       azar.Next(4, 54),
                                       (Servicio)(servicios[n]), dmc);
                socios.Add(nuevo);
            }

            //creación de la cooperativa
            string rzn = "La Juana";
            string cuit = "20200000002";
            Domicilio ubicadaEn = new Domicilio();
            Cooperativa laJuana = new Cooperativa(rzn,
                                        cuit, ubicadaEn, (Socio)socios[0]);

            //asociar los demas socios a la cooperativa.
            for (int n = 1; n < 10; n++)
            {
                Domicilio dmc = new Domicilio();
                laJuana.AgregarSocio((Socio)socios[n]);
            }


            //caso de registrar las mediciones 
            //( elijo la carga durante un año)
            //un año : definido 6 mediciones bimestrales.
            int selectedPeriodo = 9;
            for (int n = 0; n < selectedPeriodo; n++) //bimestrales
            {
              foreach(Servicio selectedSrv in servicios)
              {       
                //por cada caso seleccionado

                //generar una medicion
                int consumoAnterior=selectedSrv.MedidoPor.LecturaActual ;
                int lecturaActual = consumoAnterior+azar.Next(0, 2200); 
         
                //registro la lectura
                selectedSrv.RegistrarConsumo( lecturaActual );                                 
              }
            }

            //determinar el consumo de los socios: 
            //imprimir todos los bimestre por cada uno
            lBSociosConsumos.Items.Clear();
            lBSociosConsumos.Items.Add( string.Format("{0,-10} {1,10}",
                                       "Periodo", "Consumo"));
            foreach (Socio selectedSos in socios)
            {
                //por cada caso seleccionado

                //nro titular, nro medidor, consumo
                string titularNro =
                             selectedSos.NroSocio.ToString("000000");
                string nroMedidor =
                            selectedSos.Servicio.MedidoPor.NroMedidor.ToString("000000");
                int perido = selectedSos.Servicio.Periodo;

                lBSociosConsumos.Items.Add(
                                         string.Format("{0,-10} {1,10}",
                                         titularNro, nroMedidor));
                for (int n = 0;n < selectedSos.Servicio.CantidadConsumos; n++)
                {
                    string consumo =
                              selectedSos.Servicio[n].ToString("0.00");
                    lBSociosConsumos.Items.Add(
                                        string.Format("{0,-10} {1,10}",
                                        (n + selectedSos.Servicio.Periodo)%6, consumo));
                }
                lBSociosConsumos.Items.Add("---");
            }
        }
    }
}
