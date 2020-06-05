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

        public void GuardarPersona(Persona persona)
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
                comando.CommandText = "BUSCARPERSONAS";
                comando.CommandType = CommandType.StoredProcedure;

                DataTable datatable = new DataTable("Personas");
                SqlDataAdapter datadapter = new SqlDataAdapter(comando);
                datadapter.Fill(datatable);



                foreach (DataRow _row in datatable.Rows)
                {
                    Persona persona;
                    persona = Map(_row);
                    Personas.Add(persona);
                }


            }
            return Personas;
        }

        private Persona Map(DataRow datarow)
        {
            Persona persona = new Persona();
            persona.Identificacion = (datarow[1]).ToString();
            persona.Nombre = (datarow[0]).ToString();
            persona.Sexo = (datarow[2]).ToString();
            persona.Email = (datarow[3]).ToString();

            return persona;
        }


        public Persona ConsultarProIdentificacion(string id)
        {

            Persona persona = new Persona();
            Personas.Clear();
            using (var Comando = Connection.CreateCommand())
            {
                Comando.CommandText = "CONSULTARPERSONA";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = id;

                DataTable datatable = new DataTable("Personas");
                SqlDataAdapter datadapter = new SqlDataAdapter(Comando);
                datadapter.Fill(datatable);



                foreach (DataRow _row in datatable.Rows)
                {
                    persona = Map(_row);
                }

                return persona;

            }

        }


        public void Eliminar(string id)
        {
            Persona persona = new Persona();
            Personas.Clear();
            using (var comando = Connection.CreateCommand())
            {
                comando.CommandText = "ELIMINARPERSONA";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = id;
                DataTable datatable = new DataTable("Personas");
                SqlDataAdapter datadapter = new SqlDataAdapter(comando);
                datadapter.Fill(datatable);

                foreach (DataRow _row in datatable.Rows)
                {
                    persona = Map(_row);
                }
            }
            
        }

    }
}