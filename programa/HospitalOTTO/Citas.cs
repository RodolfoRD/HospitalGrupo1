using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HospitalOTTO
{
    public partial class Citas : Form
    {

        Dcitas c = new Dcitas();
        public Citas()
        {
            InitializeComponent();
            
        }
       
        

        private void BG_Click(object sender, EventArgs e)
        {
            c.medicoo = int.Parse(Tmedico.Text);
            c.pacientee = int.Parse(Tpaciente.Text);
            c.Fechaa = DateTime.Parse(dateTimePicker1.Text);
            c.guardar4(c.pacientee,  c.medicoo,  c.Fechaa);
            llenargrid();
        }

        private void BA_Click(object sender, EventArgs e)
        {
            c.idd = int.Parse(Tid.Text);
            c.Fechaa = DateTime.Parse(dateTimePicker1.Text);
            c.medicoo = int.Parse(Tmedico.Text);
            c.pacientee = int.Parse(Tpaciente.Text);
            c.actualizar4(c.idd, c.pacientee, c.medicoo,  c.Fechaa);
            llenargrid();
        }

        private void BB_Click(object sender, EventArgs e)
        {
            c.idd = int.Parse(Tid.Text);
            c.borrar(c.idd);
            llenargrid();
        }

        public void llenargrid()
        {
            DATAC.DataSource = c.datagr();
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            llenargrid();
            //string pro = "Data Source=DESKTOP-55G45JC\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True";
            //string query = "select * from Medicos";
            //string queryy = "select * from Pacientes";

            //SqlConnection conn = new SqlConnection(pro);
            //SqlDataAdapter adapter = new SqlDataAdapter(query, conn);


            //SqlConnection connn = new SqlConnection(pro);
            //SqlDataAdapter adapterr = new SqlDataAdapter(queryy, connn);

            //DataTable dt = new DataTable();
            //adapter.Fill(dt);


            //DataTable dtt = new DataTable();
            //adapterr.Fill(dtt);


            //cm.DisplayMember = "Nombre";
            //cm.ValueMember = "id_M";
            //cm.DataSource = dt;


            //cp.DisplayMember = "Nombre";
            //cp.ValueMember = "Id_P";
            //cp.DataSource = dtt;



            //conn.Close();
            //connn.Close();
        }

        private void Th_TextChanged(object sender, EventArgs e)
        {

        }

        //private void Bbus_Click(object sender, EventArgs e)
        //{
        //    c.Fechaa = DateTime.Parse(Ft.Text);
        //    c.medicoo = int.Parse(Mt.Text);
        //    c.pacientee = int.Parse(Pt.Text);
        //    DATAC.DataSource = c.buscar3(c.Fechaa, c.medicoo, c.pacientee);
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
