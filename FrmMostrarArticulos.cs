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
    public partial class FrmMostrarArticulos : Form
    {
        public FrmMostrarArticulos()
        {
            InitializeComponent();
        }

        //Metodo para dar formato a nuestro DataGridView
        private void Formato()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].Visible = false;
            dgvListado.Columns[2].Width = 150;
            dgvListado.Columns[3].Width = 110;
            dgvListado.Columns[3].HeaderText = "Descripción";
            dgvListado.Columns[4].Width = 100;
        }//fin del metodo Formato

        private void Buscar()
        {
            try
            {
                //cargamos el dgvListado con la data desde la base de datos 
                dgvListado.DataSource = NArticulo.Buscar(txtBuscar.Text);
                this.Formato();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }//Fin del metodo Buscar

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdArticulo = Convert.ToInt32(dgvListado.CurrentRow.Cells["ID"].Value);
            Variables.Codigo = Convert.ToString(dgvListado.CurrentRow.Cells["Codigo"].Value);
            Variables.NombreArticulo = Convert.ToString(dgvListado.CurrentRow.Cells["Nombre"].Value);
            Variables.Precio = Convert.ToDecimal(dgvListado.CurrentRow.Cells["Precio_Venta"].Value);
            this.Close();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
