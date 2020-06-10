using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalOTTO
{
    public partial class Pacientes : Form
    {
        Dpaciente p = new Dpaciente();
        public Pacientes()
        {
            InitializeComponent();
        }

        private void Tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void BG_Click(object sender, EventArgs e)
        {
            p.cedula = (Tc.Text);
            p.nombre = (Tn.Text);
            p.asegurado = (checkedListBox1.Text);
            p.guardar2(p.nombre, p.cedula,  p.asegurado);
            llenargrid();
        }

        private void BA_Click(object sender, EventArgs e)
        {
            p.idd = int.Parse(Tid.Text);
            p.cedula = (Tc.Text);
            p.nombre = (Tn.Text);
            p.asegurado = (checkedListBox1.Text);
            p.actualizar2(p.idd, p.nombre, p.cedula,  p.asegurado);
            llenargrid();
        }

        private void BB_Click(object sender, EventArgs e)
        {
            p.idd = int.Parse(Tid.Text);
            p.borrar2(p.idd);
            llenargrid();

        }
        public void llenargrid()
        {
            Datapa.DataSource = p.datagr();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            llenargrid();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void BBUSCA_Click(object sender, EventArgs e)
        {
            p.nombre = (NT.Text);
            p.cedula = (CT.Text);
            p.asegurado = (AT.Text);
            Datapa.DataSource = p.buscar1(p.nombre, p.cedula, p.asegurado);
        }
    }
}
