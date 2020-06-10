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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }
       

        private void abrir(object abrir)
        {
            if (this.Pfor.Controls.Count > 0)
                this.Pfor.Controls.RemoveAt(0);
            Form fh = abrir as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pfor.Controls.Add(fh);
            this.Pfor.Tag = fh;
            fh.Show();

        }

        private void Bmantenimiento_Click(object sender, EventArgs e)
        {
            
        }

        private void Bmedico_Click(object sender, EventArgs e)
        {
            abrir(new Medicos());
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Visible = true;
            panel5.Hide();
            panel6.Hide();

        }

        private void Bpacientes_Click(object sender, EventArgs e)
        {
            abrir(new Pacientes());
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Visible = true;
            panel6.Hide();

        }

        private void Bhabitaciones_Click(object sender, EventArgs e)
        {
            abrir(new Habitaciones());
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Visible = true;
        }

        private void Bcitas_Click(object sender, EventArgs e)
        {
            abrir(new Citas());
            panel1.Visible = true;
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            

        }

        private void Bingresos_Click(object sender, EventArgs e)
        {
            abrir(new Ingresos());
            panel1.Hide();
            panel2.Visible = true;
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void Baltas_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Visible = true;
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrir(new Casa());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(null, e);
        }
    }
}
