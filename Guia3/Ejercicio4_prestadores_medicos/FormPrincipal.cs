﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Ejercicio4.Models;

namespace Ejercicio4
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Random azar=new Random();
            lbResultados.Items.Clear();

            //prueba de concepto (simulación)

            //crear el listado de prestadores
            ArrayList prestadores=new ArrayList();
            prestadores.Add(new Prestador("Médico "+1));
            prestadores.Add(new Prestador("Médico "+2));

            //dar de alta las prestaciones (consultas)
            ArrayList prestaciones = new ArrayList();
            prestaciones.Add(new ObraSocial("Juan", (Prestador)prestadores[0]));
            prestaciones.Add(new SinObra("Renata", "20292046002", (Prestador)prestadores[1]));

            //creado el contexto – a jugar!
            Prestacion selectedConsulta=null;
            double montoAPagar=0;

            //renata necesita tres consultas en un mes; 
            //no necesito conocer si renata tiene o no obra social
            selectedConsulta=((Prestacion) prestaciones[1]); //selección de objeto de interés
            montoAPagar=selectedConsulta.PrestarServicio();
            lbResultados.Items.Add(string.Format( "Consulta de {0}, monto: ${1:f2}", selectedConsulta.ApellidosNombre, montoAPagar) );

            selectedConsulta=((Prestacion) prestaciones[1]); //selección de objeto de interés
            montoAPagar=selectedConsulta.PrestarServicio();
            lbResultados.Items.Add(string.Format( "Consulta de {0}, monto: ${1:f2}", selectedConsulta.ApellidosNombre, montoAPagar) );

            selectedConsulta=((Prestacion) prestaciones[1]); //selección de objeto de interés
            montoAPagar=selectedConsulta.PrestarServicio();
            lbResultados.Items.Add(string.Format( "Consulta de {0}, monto: ${1:f2}", selectedConsulta.ApellidosNombre, montoAPagar) );


            //juan necesita tres consultas tambien en un mes; 
            //del mismo modo que el caso anterior, juan consigue sus consultas y pagará 
            //según lo que su modelo de pago diga
            selectedConsulta=((Prestacion) prestaciones[0]); //selección de objeto de interés
            montoAPagar=selectedConsulta.PrestarServicio();
            lbResultados.Items.Add(string.Format( "Consulta de {0}, monto: ${1:f2}", selectedConsulta.ApellidosNombre, montoAPagar) );

            selectedConsulta=((Prestacion) prestaciones[0]); //selección de objeto de interés
            montoAPagar=selectedConsulta.PrestarServicio();
            lbResultados.Items.Add(string.Format( "Consulta de {0}, monto: ${1:f2}", selectedConsulta.ApellidosNombre, montoAPagar) );

            selectedConsulta=((Prestacion) prestaciones[0]); //selección de objeto de interés
            montoAPagar=selectedConsulta.PrestarServicio();
            lbResultados.Items.Add(string.Format( "Consulta de {0}, monto: ${1:f2}", selectedConsulta.ApellidosNombre, montoAPagar) );


            //llego el cierre del mes y hay que generar los pagos a los médicos.
            foreach(Prestador medico in prestadores)
            {
              lbResultados.Items.Add(string.Format( "Médico: {0}, Monto a Cobrar: ${1:f2}", medico.ApellidosNombre, medico.GenerarPago()));
            }
            
        }        
    }
}
