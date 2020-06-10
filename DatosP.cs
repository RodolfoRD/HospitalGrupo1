using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hospital
{
    class DatosP
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-55G45JC\\SQLEXPRESS;Initial Catalog=Hos;Integrated Security=True");
        SqlCommand comando;

        public void guardar( int Cedula, string Nombre, string Asegurado)
        {
            con.Open();
            string lineacomando = $"insert into Pacientes values ({Cedula}, '{Nombre}', '{Asegurado}')";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void actualizar1(int Id, int Cedula, string Nombre, string Asegurado)
        {
            con.Open();
            string lineacomando = $"update Pacientes set Cedula = {Cedula}, Nombre = '{Nombre}', Asegurado ='{Asegurado}' where Id_P = {Id}";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void Borrar1(int Id)
        {
            con.Open();
            string lineacomando = $"delete from Pacientes where Id_P = {Id}";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable llenargrid1()
        {
            con.Open();
            string lineacomando = "Select * from Pacientes";
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
