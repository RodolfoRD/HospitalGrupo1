using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalOTTO
{
    class Dcitas:Datoss
    {
      
        public DateTime Fechaa
        {
            get; set;
        }

        public int medicoo
        {
            get; set;
        }

        public int pacientee
        {
            get; set;
        }

        public override DataTable datagr()
        {
            pro.Open();
            string lineacomando = "select* from Citas";
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
