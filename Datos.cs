using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Hospital
{
    class Datos 
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-55G45JC\\SQLEXPRESS;Initial Catalog=Hos;Integrated Security=True");
        SqlCommand comando;
      


        public void guaradar(string nombre, int exequatur, string especialidad)
        {
            con.Open();
            string lineacomando = $"  insert into Medicos values('{nombre}', {exequatur}, '{especialidad}')";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void actualizar(int id, string nombre, int exequatur, string especialidad)
        {
            con.Open();
            string lineacomando = $"update Medicos set Nombre = '{nombre}', Exequatur = {exequatur}, Especialidad = '{especialidad}' where id_M = {id}";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void Borrar(int id)
        {
            con.Open();
            string lineacomando = $"delete from Medicos where id_M = {id}";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable llenargrid()
        {
            con.Open();
            string lineacomando = "select * from Medicos";
            comando = new SqlCommand(lineacomando, con);

            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            data.Fill(table);
            con.Close();
            return table;
        }
    }
}
