using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace HospitalOTTO
{
    abstract class Datos
    {
        
            public int idd
        {
            get;
            set;
        }
        public abstract void guardar(string nombre, string exequatur, string especialidad);
        public abstract void guardar2(string nombre, string cedula, string asegurado);
        public abstract void guardar3(string numero, string tipo, float precio);
        public abstract void guardar4(int idp, int idm,  DateTime fecha);
        public abstract void guardar5(int idp, int habi, DateTime fecha);

        public abstract void actualizar(int id,string nombre, string exequatur, string especialidad);
        public abstract void actualizar2(int id, string nombre, string cedula,   string asegurado);
        public abstract void actualizar3(int id, string numero, string tipo, float precio);
        public abstract void actualizar4(int id, int idp, int idm, DateTime fecha);
        public abstract void actualizar5(int id, int idp, int habi, DateTime fecha);

        public abstract void borrar(int id);
        public abstract void borrar2(int id);
        public abstract void borrar3(int id);
        public abstract void borrar4(int id);
        public abstract void borrar5(int id);

        public abstract DataTable buscar(string nombre, string especialidad);
        public abstract DataTable buscar1(string nombre, string cedula, string asegurado);
        public abstract DataTable buscar2(string tipo);
        public abstract DataTable buscar3(DateTime fecha, int idm, int idp);
        public abstract DataTable buscar4(DateTime fecha, int Habi);





    }



    class Datoss : Datos
    {
        public SqlConnection pro = new SqlConnection("Data Source=DESKTOP-55G45JC\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
        public SqlCommand comand;



        //METODOSGUARDAR
        public override void guardar(string nombre, string exequatur, string especialidad)
        {
            pro.Open();
            string lineacomando = $"insert into Medicos values ('{nombre}','{exequatur}', '{especialidad}');";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }

        public override void guardar2(string nombre, string cedula, string asegurado)
        {
            pro.Open();
            string lineacomando = $"insert into Pacientes values ('{nombre}', '{cedula}', '{asegurado}')";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }

        public override void guardar3(string numero, string tipo, float precio)
        {
            pro.Open();
            string lineacomando = $"insert into Habitaciones values ('{numero}','{tipo}', {precio})";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }
        public override void guardar4(int idp, int idm, DateTime fecha)
        {
            pro.Open();
            string lineacomando = $"insert into		Citas values ({idp}, {idm}, convert(varchar,'{fecha}'));";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }
        public override void guardar5(int idp, int habi, DateTime fecha)
        {
            pro.Open();
            string lineacomando = $"insert into Ingresos values ({idp}, {habi}, convert(varchar,'{fecha}'));";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }






        //METODOSactualizar
        public override void actualizar(int id, string nombre, string exequatur, string especialidad)
        {
            pro.Open();
            string lineacomando = $"update Medicos set nombre ='{nombre}' , exequatur ='{exequatur}' , especialidad ='{especialidad}'  where id={id}";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }
        public override void actualizar2(int id, string nombre, string cedula, string asegurado)
        {
            pro.Open();
            string lineacomando = $"update Pacientes set nombre = '{nombre}', cedula='{cedula}' , asegurado = '{asegurado}' where id = {id}";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }
        public override void actualizar3(int id, string numero, string tipo, float precio)
        {
            pro.Open();
            string lineacomando = $"update Habitaciones set numero = '{numero}' , tipo = '{tipo}', precio = {precio} where id={id}";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }
        public override void actualizar4(int id, int idp, int idm, DateTime fecha)
        {
            pro.Open();
            string lineacomando = $"update Citas set idPaciente = {idp}, idDoctor = {idm} , HoraFecha = '{fecha}' where id = {id}";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }
        public override void actualizar5(int id, int idp, int habi, DateTime fecha)
        {
            pro.Open();
            string lineacomando = $"update Ingresos set idPaciente = {idp}, idHabitacion = {habi} , Fecha = '{fecha}' where id = {id}";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }






        //METODOSborrar
        public override void borrar(int id)
        {
            pro.Open();
            string lineacomando = $"delete from Ingresos where id={id}";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }
        public override void borrar2(int id)
        {
            pro.Open();
            string lineacomando = $"delete from Pacientes where id = {id}";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }
        public override void borrar3(int id)
        {
            pro.Open();
            string lineacomando = $"delete from Habitaciones where id = {id}";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }
        public override void borrar4(int id)
        {
            pro.Open();
            string lineacomando = $"delete from Citas where id={id}";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }
        public override void borrar5(int id)
        {
            pro.Open();
            string lineacomando = $"delete from internamientos where id_in = {id}";
            comand = new SqlCommand(lineacomando, pro);
            comand.ExecuteNonQuery();
            pro.Close();
        }





        public virtual DataTable datagr()
        {

            pro.Open();
            string lineacomando = "select * from Medicos;";
            comand = new SqlCommand(lineacomando, pro);

            comand.ExecuteNonQuery();

            SqlDataAdapter datt = new SqlDataAdapter(comand);
            DataTable tabl = new DataTable();
            datt.Fill(tabl);
            pro.Close();
            return tabl;
        }


        





        public override DataTable buscar(string nombre, string especialidad)
        {
            pro.Open();
            string lineacomando = $"select * from Medicos where nombre = '{nombre}' or Especialidad = '{especialidad}'";
            comand = new SqlCommand(lineacomando, pro);

            comand.ExecuteNonQuery();

            SqlDataAdapter datt = new SqlDataAdapter(comand);
            DataTable tabl = new DataTable();
            datt.Fill(tabl);
            pro.Close();
            return tabl;
        }
        public override DataTable buscar1(string nombre, string cedula, string asegurado)
        {
            pro.Open();
            string lineacomando = $"select * from Pacientes where nombre = '{nombre}' or cedula = '{cedula}' or asegurado = '{asegurado}'";
            comand = new SqlCommand(lineacomando, pro);

            comand.ExecuteNonQuery();

            SqlDataAdapter datt = new SqlDataAdapter(comand);
            DataTable tabl = new DataTable();
            datt.Fill(tabl);
            pro.Close();
            return tabl;
        }
        public override DataTable buscar2(string tipo)
        {
            pro.Open();
            string lineacomando = $"select * from Habitaciones where tipo = '{tipo}'";
            comand = new SqlCommand(lineacomando, pro);

            comand.ExecuteNonQuery();

            SqlDataAdapter datt = new SqlDataAdapter(comand);
            DataTable tabl = new DataTable();
            datt.Fill(tabl);
            pro.Close();
            return tabl;
        }
        public override DataTable buscar3(DateTime fecha, int idm, int idp)
        {
            pro.Open();
            string lineacomando = $"select * from Citas where HoraFecha = '{fecha}' or idDoctor = '{idm}' or idPaciente = '{idp}'";
            comand = new SqlCommand(lineacomando, pro);

            comand.ExecuteNonQuery();

            SqlDataAdapter datt = new SqlDataAdapter(comand);
            DataTable tabl = new DataTable();
            datt.Fill(tabl);
            pro.Close();
            return tabl;
        }
        public override DataTable buscar4(DateTime fecha, int Habi)
        {
            pro.Open();
            string lineacomando = $"select * from Ingresos where Fecha = '{fecha}' or idHabitacion = '{Habi}'";
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
