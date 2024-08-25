using System;
using System.Collections;

namespace Ejercicio3.Models
{
    class Servicio
    {
        private ArrayList Consumos=new ArrayList();

        public int CantidadConsumos { get { return Consumos.Count; } }

        private int periodo;
        public int Periodo
        {
            get { return periodo; }
            private set
            {
                if (CantidadConsumos >= 7)//hay varias formas de implementar esto
                    Consumos.RemoveAt(0);

                periodo = value % 6;
            }
        }

        public int this[int nro]
        {
            get
            {
                return (int)Consumos[nro];
            }
        }

        public DateTime FechaAlta { get; set; }

        private Domicilio prestadoEn;
        public Domicilio PrestadoEn
        {
            get { return prestadoEn; }
            private set { prestadoEn = value; }
        }

        private Medidor medidoPor;
        public Medidor MedidoPor
        {
            get { return medidoPor; }
            set { medidoPor = value; }
        }

        public ArrayList Socios { get; set; }

        //no tiene sentido la propiedad titular de un solo Socio
        //private public Socio Titular{get; private set;}
        //porque varios socios pueden ser titular de un servicio

        public Servicio(Medidor mdd, Domicilio dmc)
        {
            this.MedidoPor = mdd;
            this.PrestadoEn = dmc;
            Socios = new ArrayList();
        }

        public void CambioTitular(Socio titularBaja,
                                   Socio titularAlta)
        {
            //this.Titular=titular;
            Socios.Remove(titularBaja);
            Socios.Add(titularAlta);
        }

        public void RegistrarConsumo(int medicion)
        {
            Periodo++;
            Consumos.Add(medidoPor.ConsumoActual());

            medidoPor.LecturaAnterior = medidoPor.LecturaActual;
            medidoPor.LecturaActual = medicion;
        }
    }
}
