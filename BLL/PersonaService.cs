using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data.SqlClient;
using Infraestructura;

namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personarepository;
        private IList<Persona> Personas;
        private SqlConnection Connection;

        public PersonaService()
        {
            Connection = new SqlConnection(@"Data Source=ISAAC-PIMIENTA9\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True");
            personarepository = new PersonaRepository(Connection);

        }

        public string GuardarPersona(Persona persona)
        {
            Correo correo = new Correo();

            try
            {
                Connection.Open();
                personarepository.GuardarPersona(persona);
                correo.EnviarEmail(persona);


                Connection.Close();
                return $"Se guardo con Extio!";
            }catch(SqlException ex)
            {
                Connection.Close();
                return $"No se pudo guardar error en la Base de datos:{ex.Message.ToString()}";
            }
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

    }
}
