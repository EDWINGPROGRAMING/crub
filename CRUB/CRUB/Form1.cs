using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            frmempleado f = new frmempleado();
            f.Show();
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {

            {
                operacion open = new operacion();
                dataGridView1.DataSource = open.cosnsultaconresultado("select * from Nomina " + txtbuscar.Text + "");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion open = new operacion();
            string resultado = open.conectar();
            MessageBox.Show(resultado);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
