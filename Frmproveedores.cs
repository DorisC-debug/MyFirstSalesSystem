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
    public partial class Frmproveedores : Form
    {
        public Frmproveedores()
        {
            InitializeComponent();
        }
        //Metodos Auxiliares

        //Metodo para dar formato a nuestro DataGridView
        private void Formato()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].Visible = false;
            dgvListado.Columns[2].Width = 150;
            dgvListado.Columns[3].Width = 100;
            dgvListado.Columns[3].HeaderText = "Nombre";
            dgvListado.Columns[4].Width = 100;
        }//fin del metodo Formato

        //Metodo para asignar los valores iniciales a los controles
        private void Limpiar()
        {
            txtBuscar.Clear();
            txtId.Clear();
            txtNombre.Clear();
            txtNumeroDeDocumento.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();

            btnInsertar.Visible = true;
            btnActualizar.Visible = false;

            dgvListado.Columns[0].Visible = false;
            btnEliminar.Visible = false;

            chkSeleccionar.Checked = false;
        }//fin del metodo Limpiar

        //Metodo para mostrar un mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error - Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }//fin del metodo MensajeError

        //Metodo para mostar un mensaje de ok
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//fin del metodo MensajeOK

        //Fin de métodos auxiliares
        private void ListarProveedores()
        {
            try
            {
                //cargamos el dgvListado con la data desde la base de datos
                dgvListado.DataSource = NPersona.ListarProveedores();
                this.Formato();
                this.Limpiar();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }//fin del metodo Listar

        private void Insertar()
        {

            try
            {
                string respuesta = ""; //aqui guardamos la respuesta que viene desde la capa de Datos
                if (txtNombre.Text == string.Empty || cmbTipoDeDocumento.Text == string.Empty || txtNumeroDeDocumento.Text == string.Empty
                    || txtDireccion.Text == string.Empty || txtTelefono.Text == string.Empty || txtEmail.Text == string.Empty)
                {
                    this.MensajeError("Faltan campos por completar");
                }
                else
                {
                    //Insertar el articulo
                    respuesta = NPersona.Insertar("Proveedor", txtNombre.Text.Trim(), cmbTipoDeDocumento.Text,
                       txtNumeroDeDocumento.Text, txtDireccion.Text,
                       txtTelefono.Text, txtEmail.Text);


                    if (respuesta == "OK")
                    {
                        this.MensajeOK("El Registro se Insertó Correctamente");
                        this.ListarProveedores();

                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }//fin del metodo Insertar

        private void Actualizar()
        {
                try
                {
                    string respuesta = ""; //aqui guardamos la respuesta que viene desde la capa de Datos
                    if (txtNombre.Text == string.Empty || cmbTipoDeDocumento.Text == string.Empty || txtNumeroDeDocumento.Text == string.Empty
                        || txtDireccion.Text == string.Empty || txtTelefono.Text == string.Empty || txtEmail.Text == string.Empty)
                    {
                        this.MensajeError("Faltan campos por completar");
                    }
                    else
                    {
                        //Insertar el articulo
                        respuesta = NPersona.Actualizar(Convert.ToInt32(txtId.Text),"Proveedor", txtNombre.Text.Trim(), cmbTipoDeDocumento.Text,
                           txtNumeroDeDocumento.Text, txtDireccion.Text,
                           txtTelefono.Text, txtEmail.Text);


                        if (respuesta == "OK")
                        {
                            this.MensajeOK("El Registro se actualizó correctamente");
                            this.ListarProveedores();
                        }
                        else
                        {
                            this.MensajeError(respuesta);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }//fin del metodo Actualizar

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


        private void Frmproveedores_Load(object sender, EventArgs e)
        {
            this.ListarProveedores();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.Insertar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos

            this.Limpiar();
            tabPrincipal.SelectedIndex = 0;

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
                btnEliminar.Visible = false;
            }
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

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarProveedores();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;
                txtId.Text = dgvListado.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgvListado.CurrentRow.Cells["Nombre"].Value.ToString();
                cmbTipoDeDocumento.Text = dgvListado.CurrentRow.Cells["Tipo_Documento"].Value.ToString();
                txtNombre.Text = dgvListado.CurrentRow.Cells["Nombre"].Value.ToString();
                txtNumeroDeDocumento.Text = dgvListado.CurrentRow.Cells["Numero_Documento"].Value.ToString();
                txtDireccion.Text = dgvListado.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dgvListado.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEmail.Text = dgvListado.CurrentRow.Cells["Email"].Value.ToString();
                tabPrincipal.SelectedIndex = 1; //muevete al 1 


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
