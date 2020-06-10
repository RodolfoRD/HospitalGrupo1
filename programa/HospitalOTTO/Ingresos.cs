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
    public partial class Ingresos : Form
    {
        Dingreso i = new Dingreso();
        public Ingresos()
        {
            InitializeComponent();
        }

        private void BG_Click(object sender, EventArgs e)
        {
            i.fechaa = DateTime.Parse(dateTimePicker1.Text);
            i.pacientee = int.Parse(Tp.Text);
            i.habii = int.Parse(Tha.Text);
            i.guardar5(i.pacientee, i.habii,  i.fechaa);
            llenargrid();
        }

        private void BA_Click(object sender, EventArgs e)
        {
            i.idd = int.Parse(Tid.Text);
            i.fechaa = DateTime.Parse(dateTimePicker1.Text);
            i.pacientee = int.Parse(Tp.Text);
            i.habii = int.Parse(Tha.Text);
            i.actualizar5(i.idd,  i.pacientee, i.habii, i.fechaa);
            llenargrid();
        }

        private void BB_Click(object sender, EventArgs e)
        {
            i.idd = int.Parse(Tid.Text);
            i.borrar5(i.idd);
            llenargrid();
        }

        public void llenargrid()
        {
            Di.DataSource = i.datagr();
        }

        private void Ingresos_Load(object sender, EventArgs e)
        {
            llenargrid();
            //paciente();
            //habi();
            
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            i.fechaa = DateTime.Parse(Ft.Text);
            i.habii = int.Parse(HT.Text);
            Di.DataSource = i.buscar4(i.fechaa, i.habii);

        }

        private void Di_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void paciente()
        //{
        //    cpa.DataSource = i.litapaciente();
        //    cpa.DisplayMember = "nombre";
        //    cpa.ValueMember = "id";
        //}
        //private void habi()
        //{
        //    ch.DataSource = i.listahabi();
        //    ch.DisplayMember = "numero";
        //    ch.ValueMember = "id";
        //}
    }
}
