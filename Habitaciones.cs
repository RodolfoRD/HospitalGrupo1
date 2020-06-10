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
    public partial class Habitaciones : Form
    {
        int id, numero, precio;
        string tipo;

        Datosh obj = new Datosh();

        private void BG_Click(object sender, EventArgs e)
        {
      
            numero = int.Parse(Tn.Text);
            tipo = (comboBox1.Text);
            precio = int.Parse(Tp.Text);
            obj.guardar2( numero, tipo, precio);
            llenar3();
        }

        private void BA_Click(object sender, EventArgs e)
        {
            id = int.Parse(Tid.Text);
            numero = int.Parse(Tn.Text);
            tipo = (Tt.Text);
            precio = int.Parse(Tp.Text);
            obj.actualizar2(id, numero, tipo, precio);
            llenar3();
        }

        private void BB_Click(object sender, EventArgs e)
        {
            id = int.Parse(Tid.Text);
            obj.Borrar2(id);
            llenar3();
        }

        public Habitaciones()
        {
            InitializeComponent();
        }

        private void Habitaciones_Load(object sender, EventArgs e)
        {
            llenar3();
        }
        public void llenar3()
        {
            dataGridView1.DataSource = obj.llenargrid2();
        }
    }
}
