using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class PersonaRepository
    {
        private SqlConnection Connection;
        private IList<Persona> Personas;
        private SqlDataReader Reader;

        public PersonaRepository(SqlConnection connection)
        {
            Connection = connection;
            Personas = new List<Persona>();

        }

        public void GuardarPersona( Persona persona)
        {
            SqlCommand Command = new SqlCommand("GUARDARPERSONA", Connection);
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = persona.Nombre;
            Command.Parameters.Add("Identificacion", SqlDbType.VarChar).Value = persona.Identificacion;
            Command.Parameters.Add("Sexo", SqlDbType.VarChar).Value = persona.Sexo;
            Command.Parameters.Add("Correo", SqlDbType.VarChar).Value = persona.Email;
            Command.ExecuteNonQuery();
        }


        public IList<Persona> Consultar()
        {
            Personas.Clear();
            using (var comando = Connection.CreateCommand())
            {
                comando.CommandText = "SELECT * FROM Personas";
                Reader = comando.ExecuteReader();

                while (Reader.Read())
                {
                    Persona persona;
                    persona = Map(Reader);
                    Personas.Add(persona);
                }
            }
            return Personas;
        }

        private Persona Map(SqlDataReader reader)
        {
            Persona persona = new Persona();
            persona.Nombre = (string)reader["Nombre"];
            persona.Identificacion = (string)reader["Identificacion"];
            persona.Sexo = (string)reader["Sexo"];
            persona.Email = (string)reader["Correo"];
            return persona;
        }

    }
}
