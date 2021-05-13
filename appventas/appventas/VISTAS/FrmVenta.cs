using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.VISTAS
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities()) {

                var consultacliente = bd.tb_cliente.ToList();

                comboBox2.DataSource = consultacliente;
                comboBox2.DisplayMember = "nombreCliente";
                comboBox2.ValueMember = "iDCliente";

                //var consultadocumento = (from documento in bd.tb_documento
                //                         select new
                //                         {
                //                             documento.iDDocumento,
                //                             documento.nombreDocumento
                //                         }).ToList();

                var consultadocumento = bd.tb_documento.ToList();

                comboBox1.DataSource = consultadocumento;
                comboBox1.DisplayMember = "nombreDocumento";
                comboBox1.ValueMember = "iDDocumento";

              




            }
        }
    }
}
