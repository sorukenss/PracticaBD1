using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data.SqlClient;
using Infraestructura;
using System.Runtime.InteropServices.ComTypes;


namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personarepository;
        private IList<Persona> Personas;
        private SqlConnection Connection;
         Correo EmailCorreo = new Correo();

        public PersonaService()
        {
            Connection = new SqlConnection(@"Data Source=ISAAC-PIMIENTA9\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True");
            personarepository = new PersonaRepository(Connection);

        }

        public string GuardarPersona(Persona persona)
        {
            try
            {
                Connection.Open();
                personarepository.GuardarPersona(persona);
                Connection.Close();
                return $"Se guardo con Extio!";
            }catch(SqlException ex)
            {
                Connection.Close();
                return $"No se pudo guardar error en la Base de datos:{ex.Message.ToString()}";
            }
        }

        public void EnviarPdf(string ruta,string correo)
        {
            EmailCorreo.EnviarEmail(ruta, correo);
        }

        public IList<Persona> ConsultarNormal()
        {
            try
            {
                Connection.Open();
                Personas= new List<Persona>();
                Personas = personarepository.Consultar();
                Connection.Close();
                return Personas;
            }
            catch (SqlException ex)
            {
                Connection.Close();
                return null;
            }

        }

        public Persona ConsultarPersona(string id)
        {
            Persona persona = null;
            try
            {
                Connection.Open();
                persona = personarepository.ConsultarProIdentificacion(id);

                Connection.Close();
                return persona;

            }
            catch (SqlException ex)
            {
                Connection.Close();
                return null;
            }
        }


        public string GenerarPdf(IList<Persona> personas, string filename)
        {
            DocumentoPdf documentoPdf = new DocumentoPdf();
            try
            {
                documentoPdf.GuardarPdf(personas, filename);
                return "Se genró el Documento satisfactoriamente";
            }
            catch (Exception e)
            {

                return $"Error al crear docuemnto: { e.Message.ToString()}";
            }
        }


        public string EliminarPersona(string id)
        {
           
            try
            {
                Connection.Open();
                personarepository.Eliminar(id);
                Connection.Close();
                return $"Se elimino con exito";
            }
            catch (SqlException ex)
            {
                Connection.Close();
                return $"No se elimino{ex.Message.ToString()}";
            }
        }



        public class ConsultaPersonaRespuesta
        {
            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public IList<Persona> Personas { get; set; }
        }

        public class BusquedaPersonaRespuesta
        {
            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Persona Persona { get; set; }
        }

    }
}
