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
    public partial class Medicos : Form
    {
        Dmedico m = new Dmedico();
        public Medicos()
        {
            InitializeComponent();
        }

        private void BG_Click(object sender, EventArgs e)
        {
          
            m.nombree = (Tnombre.Text);
            m.exequaturr = (Te.Text);
            m.especialidadd = (Tes.Text);
            m.guardar(m.nombree, m.exequaturr, m.especialidadd);
            llenargrid();
        }

        public void llenargrid()
        {
            Dm.DataSource = m.datagr();
        }

        private void Medicos_Load(object sender, EventArgs e)
        {
            llenargrid();
        }

        private void BA_Click(object sender, EventArgs e)
        {
            m.idd = int.Parse(Tid.Text);
            m.nombree = (Tnombre.Text);
            m.exequaturr = (Te.Text);
            m.especialidadd = (Tes.Text);
            m.actualizar(m.idd, m.nombree, m.exequaturr, m.especialidadd);
            llenargrid();
        }

        private void BB_Click(object sender, EventArgs e)
        {
            m.idd = int.Parse(Tid.Text);
            m.borrar(m.idd);
            llenargrid();
        }

        private void Bbus_Click(object sender, EventArgs e)
        {
            m.nombree = (NT.Text);
            m.especialidadd = (ET.Text);
            Dm.DataSource = m.buscar(m.nombree, m.especialidadd);
        }
    }
}
