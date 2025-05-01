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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }
        //Metodos Auxiliares

        //Metodo para formato a nuestros DataGridView
        private void Formato()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].Visible = false;
            dgvListado.Columns[2].Width = 150;
            dgvListado.Columns[3].Width = 200;
            dgvListado.Columns[3].HeaderText = "Descripción";
            dgvListado.Columns[4].Width = 135;
        }
        //Fin del metodo formato

        //Metodo para asignar los valores iniciales a los controles
        private void Limpiar()
        {
            txtBuscar.Clear();
            txtNombre.Clear();
            txtId.Clear();
            txtDescripcion.Clear();
            btnInsertar.Visible = true;
            btnActualizar.Visible = false;

            dgvListado.Columns[0].Visible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            btnEliminar.Visible = false;

            chkSeleccionar.Checked = false;

        }

        //Fin del metodo limpiar

        //Metdodo para mostrar un mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error - Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }//Fin de metodo MensajeError

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//Fin de metodo MensajeOk

        //Fin de metodos auxiliares


        //Listar las categorias
        private void Listar()
        {
            try
            {
                //cargamos el dgvListado con la data desde la base de datos 
                dgvListado.DataSource = NCategoria.Listar();
                this.Formato();
                this.Limpiar();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Fin del metodo Listar

        //Insertar una categoria

        private void Insertar()
        {

            try
            {
                string respuesta = ""; //Aqui guardamos la respuesta que viene desde la capa de datos
                if (txtNombre.Text == string.Empty)
                {
                    this.MensajeError("El campo Nombre está vacio");
                }
                else
                {
                    //Insertar la categoria
                    respuesta = NCategoria.Insertar(txtNombre.Text, txtDescripcion.Text);
                    if (respuesta == "OK")
                    {
                        this.MensajeOk("El registro se insertó correctamente");
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }//Fin del metodo insertar

        private void Buscar()
        {
            try
            {
                //cargamos el dgvListado con la data desde la base de datos 
                dgvListado.DataSource = NCategoria.Buscar(txtBuscar.Text);
                this.Formato();
                this.Limpiar();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Fin del metodo Buscar

        //Actualizar una categoria
        private void Actualizar()
        {
            try
            {
                string respuesta = "";
                if (txtNombre.Text == "")
                {
                    this.MensajeError("El campo nombre no puede estar vacio");
                }
                else
                {
                    respuesta = NCategoria.Actualizar(Convert.ToInt32(txtId.Text), txtNombre.Text, txtDescripcion.Text);
                    if (respuesta == "OK")
                    {
                        this.MensajeOk("El registro se actualizó correctamente");
                        this.Listar();
                        tabPrincipal.SelectedIndex = 0; //lleva al tab 0
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }//Fin del metodo actualizar

        //Activar categoria

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
                            rpta = NCategoria.Activar(codigo);
                            if (rpta == "OK")
                            {
                                this.MensajeOk("Se activó el registro: " + Convert.ToString(row.Cells[2].Value));
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

        //Desactivar

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
                            rpta = NCategoria.Desactivar(codigo);
                            if (rpta == "OK")
                            {
                                this.MensajeOk("Se desactivó el registro: " + Convert.ToString(row.Cells[2].Value));
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
            //fin del metodo desactivar

        }

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
                            rpta = NCategoria.Eliminar(codigo);
                            if (rpta == "OK")
                            {
                                this.MensajeOk("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
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

                //Fin de metodos auxiliares

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            //Ejecutamos el metodo Listar
            this.Listar();
        }
        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            this.Insertar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
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
                txtNombre.Text = dgvListado.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvListado.CurrentRow.Cells["Descripcion"].Value.ToString();
                tabPrincipal.SelectedIndex = 1; //muevete al 1 


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Actualizar();
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
            if(e.ColumnIndex == dgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkCambiar =(DataGridViewCheckBoxCell)dgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chkCambiar.Value = !Convert.ToBoolean(chkCambiar.Value);
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             // Limpiar todos los campos
                txtId.Text = "";
                txtNombre.Text = "";
                txtDescripcion.Text = "";
        }
    }
}
