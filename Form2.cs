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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            perdise();
        }

        public void perdise()
        {
            panel10.Visible = false;
        }

        public void ocm()
        {
            if (panel10.Visible == true)
                panel10.Visible = false;
        }

        public void mm(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocm();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
       
           



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox7_Click(null, e);
        }
        private void abrir(object abrir)
        {
            if (this.Pcont.Controls.Count > 0)
                this.Pcont.Controls.RemoveAt(0);
            Form fh = abrir as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pcont.Controls.Add(fh);
            this.Pcont.Tag = fh;
            fh.Show();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            abrir(new Inicio());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bmedico_Click(object sender, EventArgs e)
        {
          


        }

        private void BPACIENTE_Click(object sender, EventArgs e)
        {
            
        }

        private void BHABITACIONES_Click(object sender, EventArgs e)
        {
            
        }

        private void Bmedico_Click_1(object sender, EventArgs e)
        {
            ocm();
            abrir(new Medico());
        }

        private void Bpaciente_Click_1(object sender, EventArgs e)
        {
            ocm();
            abrir(new Internamientos());
        }

        private void Bhospital_Click(object sender, EventArgs e)
        {
            ocm();
           
            abrir(new Habitaciones());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            mm(panel10);
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ocm();
            abrir(new Medico());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ocm();
            abrir(new Internamientos());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ocm();

            abrir(new Habitaciones());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            abrir(new Consultas());

            
        }

        private void button11_Click(object sender, EventArgs e)
        {

          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void Pcont_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
