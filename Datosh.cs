using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hospital
{
    class Datosh
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-55G45JC\\SQLEXPRESS;Initial Catalog=Hos;Integrated Security=True");
        SqlCommand comando;

        public void guardar2(int numero, string tipo, int precio)
        {
            con.Open();
            string lineacomando = $"insert into Habitaciones values({numero}, '{tipo}', {precio})";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void actualizar2(int id, int numero, string tipo, int precio)
        {
            con.Open();
            string lineacomando = $"update Habitaciones set Numero = {numero}, Tipo = '{tipo}', Precio = {precio} where id_H = {id}";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void Borrar2(int id)
        {
            con.Open();
            string lineacomando = $"delete from Habitaciones where id_H = {id}";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable llenargrid2()
        {
            con.Open();
            string lineacomando = "select * from Habitaciones";
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
