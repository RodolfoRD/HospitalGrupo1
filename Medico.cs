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
    public partial class Medico : Form
    {
        string nom, espe;
        int id, exe;

        Datos obj = new Datos();
        public Medico()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = int.Parse(TID.Text);
            nom = (TN.Text);
            exe = int.Parse(TE.Text);
            espe = (TES.Text);
            obj.actualizar(id, nom, exe, espe);
            llenargrid();
        }

        private void BB_Click(object sender, EventArgs e)
        {
            id = int.Parse(TID.Text);
            obj.Borrar(id);
            llenargrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            llenargrid();
        }

        private void BPACIENTE_Click(object sender, EventArgs e)
        {

        }

        private void Bmedico_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            nom = (TN.Text);
            exe = int.Parse(TE.Text); 
            espe = (TES.Text);
            obj.guaradar( nom, exe, espe);

            llenargrid();
        }
        public void llenargrid()
        {
            dataGridView1.DataSource = obj.llenargrid();
        }

    }
}
