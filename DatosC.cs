using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Hospital
{
    class DatosC
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-55G45JC\\SQLEXPRESS;Initial Catalog=Hos;Integrated Security=True");
        SqlCommand comando;
       

        public void guaradar(string fecha, int hora, int idm , int idp)
        {
            con.Open();
            string lineacomando = $"insert into Citas (fecha, hora, id_M, id_P) values ('{fecha}', '{hora}', '{idm}', '{idp}')";
            comando = new SqlCommand(lineacomando, con);
              comando.ExecuteNonQuery();
            con.Close();
        }

        public void actualizar(int id_C, int id_m, int id_p, DateTime fecha, int hora)
        {
            con.Open();
            string lineacomando = $"update Citas set id_M = {id_m}, id_P ={id_p}, fecha = {fecha}, hora = {hora} where id_C = {id_C}";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void Borrar(int id_C)
        {
            con.Open();
            string lineacomando = $"delete from Citas where id_C ={id_C}";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();
            con.Close();
        } 

        public DataTable llenargrid3()
        {
            con.Open();
            string lineacomando = "select * from Citas";
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
