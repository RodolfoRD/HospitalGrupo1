using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalOTTO
{
    class Dhabi:Datoss
    {
        private string numero;
        public string numeroo
        {
            get; set;
        }
        private string tipo;
        public string tipoo
        {
            get; set;
        }
        private float precio;
        public float precioo
        {
            get;
            set;
        }

        public override DataTable datagr()
        {
            pro.Open();
            string lineacomando = "select * from Habitaciones";
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
