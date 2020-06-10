using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalOTTO
{
    class Dpaciente:Datoss
    {
        private string CEDULA;
       public string cedula
        {
            get; set;
        }


        private string NOMBRE;
        public string nombre
        {
            get; set;
        }


        private string ASEGURADO;
            public string asegurado
        {
            get; set;
        }

        public override DataTable datagr()
        {
            pro.Open();
            string lineacomando = "select * from Pacientes";
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
