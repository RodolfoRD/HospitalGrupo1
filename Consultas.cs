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


namespace Hospital
{
    public partial class Consultas : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-55G45JC\\SQLEXPRESS;Initial Catalog=Hos;Integrated Security=True");
        string fecha;
        int  idp, horas;
        int idm;
        DatosC obj = new DatosC();

        public Consultas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            
            llenargrid3();
           
            
            
        }
       
        private  void BG_Click(object sender, EventArgs e)
        {
            fecha = (Tf.Text);
            horas = int.Parse(Th.Text);
            idm = int.Parse(Tm.Text);
            idp = int.Parse(Tp.Text);
            obj.guaradar(fecha, horas, idm, idp);
            llenargrid3();
          
        }
        public void llenargrid3()
        {
            dataGridView1.DataSource = obj.llenargrid3();
        }

       

        public DataTable llenaritems()
        {
            con.Open();
            string linea = "select * from Medicos";
            SqlCommand cmd = new SqlCommand(linea, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            con.Close();
            return tabla;
        }
    }
    
}
