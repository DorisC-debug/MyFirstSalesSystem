using Sistema.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmRol : Form
    {
        public FrmRol()
        {
            InitializeComponent();
        }

        //Listar los articulos
        private void Listar()
        {
            try
            {
                //cargamos el dgvListado con la data desde la base de datos
                dgvListado.DataSource = NRol.Listar();
                this.Formato();
                lblTotal.Text = "Total: " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }//fin del metodo Listar

        private void Formato()
        {
            dgvListado.Columns[0].Width = 100;
            dgvListado.Columns[0].HeaderText = "ID";
            dgvListado.Columns[1].Width = 200;
            dgvListado.Columns[1].HeaderText = "Nombre Rol";

        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
