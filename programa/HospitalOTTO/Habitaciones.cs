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
    public partial class Habitaciones : Form
    {
        Dhabi habi = new Dhabi();
        public Habitaciones()
        {
            InitializeComponent();
        }

        private void BG_Click(object sender, EventArgs e)
        {
            habi.numeroo = (Tno.Text);
            habi.tipoo = (Combo1.Text);
            habi.precioo = float.Parse(Tp.Text);
            habi.guardar3(habi.numeroo, habi.tipoo, habi.precioo);
            llenar();
        }

        private void BA_Click(object sender, EventArgs e)
        {
            habi.idd = int.Parse(Tid.Text);
            habi.numeroo = (Tno.Text);
            habi.tipoo = (Combo1.Text);
            habi.precioo = float.Parse(Tp.Text);
            habi.actualizar3(habi.idd, habi.numeroo, habi.tipoo, habi.precioo);
            llenar();
        }

        private void BB_Click(object sender, EventArgs e)
        {
            habi.idd = int.Parse(Tid.Text);
            habi.borrar3(habi.idd);
            llenar();
        }

        private void llenar()
        {
            dataGridView1.DataSource = habi.datagr();
        }

        private void Habitaciones_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            habi.tipoo = (Cbuscar.Text);
            dataGridView1.DataSource = habi.buscar2(habi.tipoo);
        }
    }
}
