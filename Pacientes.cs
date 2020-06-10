using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Internamientos : Form
    {
        int id, cedula;
        string nombre, asegurado;
        DatosP obj = new DatosP();

        public Internamientos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BA_Click(object sender, EventArgs e)
        {
            id = int.Parse(Tid.Text);
            cedula = int.Parse(Tc.Text);
            nombre = (Tn.Text);
            asegurado = (Ta.Text);
            obj.actualizar1(id, cedula, nombre, asegurado);
            llenargrid1();
        }

        private void BB_Click(object sender, EventArgs e)
        {
            id = int.Parse(Tid.Text);
            obj.Borrar1(id);
            llenargrid1();
        }

        private void Internamientos_Load(object sender, EventArgs e)
        {
            llenargrid1();
        }

        private void BG_Click(object sender, EventArgs e)
        {
            
            cedula = int.Parse(Tc.Text);
            nombre = (Tn.Text);
            asegurado = (Ta.Text);
            obj.guardar( cedula, nombre, asegurado);
            llenargrid1();
        }

        public void llenargrid1()
        {
            dataGridView1.DataSource = obj.llenargrid1();
        }

    }
}
