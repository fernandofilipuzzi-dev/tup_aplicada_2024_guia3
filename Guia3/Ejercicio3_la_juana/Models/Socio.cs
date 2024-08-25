

namespace Ejercicio3.Models
{
    class Socio:Persona
    {
      public int NroSocio {get; set;}

      private Domicilio  viveen;
      public Domicilio Viveen{get{ return viveen;}}

      private Servicio servicio;
      public Servicio Servicio
      {
        get
        {
          return servicio;
        }
        set
        {  
          //Socio se hace cargo de la doble vinculación 
          servicio=value;
          servicio.Socios.Add(this);
        }
      }
     
      public Socio(string apellidos, string nombres, 
                     int dni, int edad ,int nroSocio, 
                     Servicio srv, Domicilio dmc):base( 
                     apellidos, nombres, dni, edad)
      {
         this.NroSocio=nroSocio;

        //la doble vinculación la traslado al setter
        //servicio=srv;
        //srv.Socios.Add(this);
        Servicio=srv;

      }

      public void AgregarServicio(Servicio nuevoSrv)
      {
        //la doble vinculación la traslado al setter
        //servicio=srv;
        //srv.Socios.Add(this);
        Servicio=nuevoSrv;
      }

      public void CambiarDomicilio(Domicilio nuevoDmc)
      {
        this.viveen=nuevoDmc;
      }
    }
}
