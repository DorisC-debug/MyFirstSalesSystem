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
    public partial class FrmVistaProveedores : Form
    {
        public FrmVistaProveedores()
        {
            InitializeComponent();
        }

        private void Formato()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].Visible = false;
            dgvListado.Columns[2].Width = 150;
            dgvListado.Columns[3].Width = 100;
            dgvListado.Columns[3].HeaderText = "Nombre";
            dgvListado.Columns[4].Width = 100;
        }//fin del metodo Formato
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error - Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }//fin del metodo MensajeError

        //Metodo para mostar un mensaje de ok
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//fin del metodo MensajeOK

        private void ListarProveedores()
        {
            try
            {
                //cargamos el dgvListado con la data desde la base de datos
                dgvListado.DataSource = NPersona.ListarProveedores();
                this.Formato();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }//fin del metodo Listar
        private void BuscarProveedores()
        {
            try
            {
                //cargamos el dgvListado con la data desde la base de datos 
                dgvListado.DataSource = NPersona.BuscarProveedores(txtBuscar.Text);
                this.Formato();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Fin del metodo Buscar

        private void FrmVistaProveedores_Load(object sender, EventArgs e)
        {
            this.ListarProveedores();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarProveedores();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.IdProveedor = Convert.ToInt32(dgvListado.CurrentRow.Cells["Id"].Value);
            Variables.NombreProveedor = dgvListado.CurrentRow.Cells["Nombre"].Value.ToString();
            this.Close();
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked)
            {
                dgvListado.Columns[0].Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                dgvListado.Columns[0].Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void Eliminar()
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el (los) registro(s) Seleccionado(s)", "Sistema de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    //necesitamos determinar el idcategoria de las categorias seleccionadas 
                    int codigo;
                    string rpta = "";
                    foreach (DataGridViewRow row in dgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            //Activamos la categoria
                            rpta = NPersona.Eliminar(codigo);
                            if (rpta == "OK")
                            {
                                this.MensajeOK("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }

                        }

                    }
                    //Refrescar el dgvListado
                    this.ListarProveedores();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Fin del metodo eliminar

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lo que queremos es investigar si se hizo el click encima de un checkbox de la columna seleccionar
            if (e.ColumnIndex == dgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkCambiar = (DataGridViewCheckBoxCell)dgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkCambiar.Value = !Convert.ToBoolean(chkCambiar.Value);
            }
        }
    }
}
