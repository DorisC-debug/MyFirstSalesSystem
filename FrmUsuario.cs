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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        private void Formato()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].Visible = false;
            dgvListado.Columns[2].Width = 50;
            dgvListado.Columns[3].Width = 100;
            dgvListado.Columns[3].HeaderText = "Descripción";
            dgvListado.Columns[4].Width = 100;
        }//fin del metodo Formato
        //Metodo para asignar los valores iniciales a los controles
        private void Limpiar()
        {
            txtBuscar.Clear();
            txtNombre.Clear();
            txtNumeroDeDocumento.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtClave.Clear();
            txtTelefono.Clear();
            btnInsertar.Visible = true;
            btnActualizar.Visible = false;

            dgvListado.Columns[0].Visible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
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

        //Listar los usuarios
        private void Listar()
        {
            try
            {
                //cargamos el dgvListado con la data desde la base de datos
                dgvListado.DataSource = NUsuario.Listar();
                this.Formato();
                this.Limpiar();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }//fin del metodo Listar
        //Metodo para traer las categorias activas y usarlas para asignar a los articulos que se vayan a crear 
        //o a actualizar
        //Insertar un Articulo
        private void Insertar()
        {

            try
            {
                string respuesta = ""; //aqui guardamos la respuesta que viene desde la capa de Datos
                if (txtNombre.Text == string.Empty || cmbRol.Text == string.Empty || txtEmail.Text == string.Empty || txtClave.Text == string.Empty)
                {
                    this.MensajeError("Faltan campos por completar");
                }
                else
                {
                    //Insertar el articulo
                    respuesta = NUsuario.Insertar(Convert.ToInt32(cmbRol.SelectedValue), txtNombre.Text.Trim(), Convert.ToString(cmbTipoDeDocumento.Text),
                        txtNumeroDeDocumento.Text,
                        txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtClave.Text);


                    if (respuesta == "OK")
                    {
                        this.MensajeOK("El Registro se Insertó Correctamente");
                        this.Listar();
                        this.Limpiar();
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }//fin del metodo Insertar

        private void Actualizar()
        {

            try
            {
                string respuesta = ""; //aqui guardamos la respuesta que viene desde la capa de Datos
                if (txtNombre.Text == string.Empty || cmbRol.Text == string.Empty || txtEmail.Text == string.Empty || txtClave.Text == string.Empty)
                {
                    this.MensajeError("Faltan campos por completar");
                }
                else
                {
                    //Insertar el articulo
                    respuesta = NUsuario.Actualizar(Convert.ToInt32(txtId.Text), Convert.ToInt32(cmbRol.SelectedValue), txtNombre.Text.Trim() , 
                        Convert.ToString(cmbTipoDeDocumento.Text),
                        txtNumeroDeDocumento.Text,
                        txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtClave.Text);


                    if (respuesta == "OK")
                    {
                        this.MensajeOK("El Registro se Insertó Correctamente");
                        this.Listar();
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

        private void Activar()
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea Activar el (los) registro(s) Seleccionado(s)", "Sistema de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                            rpta = NUsuario.Activar(codigo);
                            if (rpta == "OK")
                            {
                                this.MensajeOK("Se activó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }

                        }

                    }
                    //Refrescar el dgvListado
                    this.Listar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Fin del metodo activar
        private void Desactivar()
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea Desactivar el (los) registro(s) Seleccionado(s)", "Sistema de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                            rpta = NUsuario.Desactivar(codigo);
                            if (rpta == "OK")
                            {
                                this.MensajeOK("Se desactivó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }

                        }

                    }
                    //Refrescar el dgvListado
                    this.Listar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //fin del metodo desactivar
        //Eliminar
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
                            rpta = NUsuario.Eliminar(codigo);
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
                    this.Listar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Fin del metodo eliminar
        private void Buscar()
        {
            try
            {
                //cargamos el dgvListado con la data desde la base de datos 
                dgvListado.DataSource = NUsuario.Buscar(txtBuscar.Text);
                this.Formato();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Fin del metodo Buscar
       


        //Fin de metodos auxiliares


        private void CargarRoles()
        {
            cmbRol.DataSource = NUsuario.CargarRoles();
            cmbRol.ValueMember = "idrol";
            cmbRol.DisplayMember = "nombre";

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.CargarRoles();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.CargarRoles();
            this.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.Insertar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Actualizar();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            this.Activar();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            this.Desactivar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        private void dgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;
                txtId.Text = dgvListado.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgvListado.CurrentRow.Cells["Nombre"].Value.ToString();
                txtNombre.Text = dgvListado.CurrentRow.Cells["Nombre"].Value.ToString();
                tabPrincipal.SelectedIndex = 1; //muevete al 1 


            }
            catch (Exception)
            {

                throw;
            }
        }
       

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked)
            {
                dgvListado.Columns[0].Visible = true;
                btnActivar.Visible = true;
                btnDesactivar.Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                dgvListado.Columns[0].Visible = false;
                btnActivar.Visible = false;
                btnDesactivar.Visible = false;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            this.Limpiar();
            tabPrincipal.SelectedIndex = 0;
        }
    }
}

   