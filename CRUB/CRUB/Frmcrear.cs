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
    public partial class frmempleado : Form
    {
        public frmempleado()
        {
            InitializeComponent();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmcrear_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            oper.consultasinreaultado("insert into nomina(nombre,apellido,cedula,sexo) values('" + txtnombre.Text + "','" + txtpellido.Text + "','" + txtcedula.Text + "','" + txtsexo.Text + "')");

        }
    }
}
