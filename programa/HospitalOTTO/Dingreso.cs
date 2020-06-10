using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalOTTO
{
    class Dingreso:Datoss
    {
        //public SqlConnection pro = new SqlConnection("Data Source=DESKTOP-55G45JC\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
        //public SqlCommand comand;
        //public SqlDataReader leer;

        //public DataTable litapaciente()
        //{
        //    string linea;
        //    DataTable data = new DataTable();
        //    pro.Open();
        //    linea = "select * from Pacientes";
        //    comand  = new SqlCommand(linea, pro);
        //    leer = comand.ExecuteReader();
        //    data.Load(leer);
        //    leer.Close();
        //    pro.Close();
        //    return data;
        //}

        //public DataTable listahabi()
        //{
        //    string linea;
        //    DataTable data = new DataTable();
        //    pro.Open();
        //    linea = "select * from Habitaciones";
        //    comand = new SqlCommand(linea, pro);
        //    leer = comand.ExecuteReader();
        //    data.Load(leer);
        //    leer.Close();
        //    pro.Close();
        //    return data;
        //}













        public DateTime fechaa
        {
            get; set;
        }
        private int paciente;
        public int pacientee
        {
            get; set;
        }
        private int habi;
        public int habii
        {
            get; set;
        }

        public override DataTable datagr()
        {
            pro.Open();
            string lineacomando = "select * from Ingresos";
            comand = new SqlCommand(lineacomando, pro);

            comand.ExecuteNonQuery();

            SqlDataAdapter datt = new SqlDataAdapter(comand);
            DataTable tabl = new DataTable();
            datt.Fill(tabl);
            pro.Close();
            return tabl;
        }
    }
}
