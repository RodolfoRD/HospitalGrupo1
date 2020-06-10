using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalOTTO
{
    class Dmedico:Datoss
    {
       
        public string nombree
        {
            get; set;
        }

       
        public string especialidadd
        {
            get; set;
        }

       
        public string exequaturr
        {
            get; set;
        }

        public override DataTable datagr()
        {
            pro.Open();
            string lineacomando = "select * from Medicos";
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
