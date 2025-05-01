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
    public partial class FrmIngresos : Form
    {
        public FrmIngresos()
        {
            InitializeComponent();
        }

        
        private void Listar()
        {
            try
            {
                //cargamos el dgvListado con la data desde la base de datos 
                dgvListado.DataSource = NIngreso.Listar();
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
        private void Buscar()
        {
            try
            {
                //cargamos el dgvListado con la data desde la base de datos 
                dgvListado.DataSource = NIngreso.Buscar(txtBuscar.Text);
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

        //Crear DtDetalle para llenar los datos de detalle de un ingreso
        private DataTable DtDetalle = new DataTable();
       
            private void Formato()
            {
                dgvListado.Columns[0].Visible = false;
                dgvListado.Columns[1].Visible = false;
                dgvListado.Columns[2].Visible = false;
                dgvListado.Columns[0].Width = 100;
                dgvListado.Columns[3].Width = 150;
                dgvListado.Columns[4].Width = 150;
                dgvListado.Columns[5].Width = 100;
                dgvListado.Columns[5].HeaderText = "Documento";
                dgvListado.Columns[6].Width = 70;
                dgvListado.Columns[6].HeaderText = "Serie";
                dgvListado.Columns[7].Width = 70;
                dgvListado.Columns[7].HeaderText = "Número";
                dgvListado.Columns[8].Width = 60;
                dgvListado.Columns[9].Width = 100;
                dgvListado.Columns[10].Width = 100;
                dgvListado.Columns[11].Width = 100;
               
            }
        //Fin del metodo formato

        //Metodo para asignar los valores iniciales a los controles
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//Fin de metodo MensajeOk

        private void Limpiar()
            {
                txtBuscar.Clear();
                txtId.Clear();
                txtCodigo.Clear();
                txtIdProveedor.Clear();
                txtNombreProveedor.Clear();
                txtSerieComprobante.Clear();
                txtNumeroComprobante.Clear();
                DtDetalle.Clear();
                txtSubtotal.Text = "0.00";
                txtTotalImpuestos.Text = "0.00";
                txtTotal.Text = "0.00";

                btnAnular.Visible = false;
                dgvListado.Columns[0].Visible = false;
                chkSeleccionar.Checked = false;

            }

            //Fin del metodo limpiar

            private void FormatoArticulos()
            {
              
            }

            //Metdodo para mostrar un mensaje de error
            private void MensajeError(string mensaje)
            {
                MessageBox.Show(mensaje, "Error - Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Fin de metodo MensajeError


            //Fin de metodos auxiliares

           private void CrearTabla ()
           {
            this.DtDetalle.Columns.Add("idArticulo", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"));

            //Lo añadimos al DGV

            dgvDetalle.DataSource = this.DtDetalle;
            dgvDetalle.Columns[0].Visible = false;
            dgvDetalle.Columns[1].HeaderText = "CODIGO";
            dgvDetalle.Columns[1].Width = 100;
            dgvDetalle.Columns[2].HeaderText = "ARTICULO";
            dgvDetalle.Columns[2].Width = 200;
            dgvDetalle.Columns[3].HeaderText = "CANTIDAD";
            dgvDetalle.Columns[3].Width = 90;
            dgvDetalle.Columns[4].HeaderText = "PRECIO";
            dgvDetalle.Columns[4].Width = 80;
            dgvDetalle.Columns[5].HeaderText = "IMPORTE";
            dgvDetalle.Columns[5].Width = 80;


            dgvDetalle.Columns[1].ReadOnly = true;
            dgvDetalle.Columns[2].ReadOnly = true;
            dgvDetalle.Columns[5].ReadOnly = true;

        }
        private void FrmIngresos_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CrearTabla();
        }

        private void btnBuscarProveedores_Click(object sender, EventArgs e)
        {
            FrmVistaProveedores vista = new FrmVistaProveedores();
            vista.ShowDialog();
            txtIdProveedor.Text = Variables.IdProveedor.ToString();
            txtNombreProveedor.Text = Variables.NombreProveedor;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable Tabla = new DataTable();
                    Tabla = NArticulo.BuscarCodigo(txtCodigo.Text.Trim());

                    if (Tabla.Rows.Count <= 0 )
                    {
                        this.MensajeError("No existe un articulo con este codigo de barra");
                    }
                    else
                    {
                        //Agregar este articulo y su detalle
                        this.AgregarDetalle(Convert.ToInt32(Tabla.Rows[0][0]), Convert.ToString(Tabla.Rows[0][1]),
                            Convert.ToString(Tabla.Rows[0][2]), Convert.ToDecimal(Tabla.Rows[0][3]));

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Metodo agregar detalle de un articulo para ingreso
        private void AgregarDetalle(int IdArticulo, string Codigo, string Nombre, decimal Precio) 
        {
            bool Agregar = true;

            foreach (DataRow FilaTemp in DtDetalle.Rows) 
            {
                if (Convert.ToInt32(FilaTemp["idarticulo"]) == IdArticulo) 
                {
                  Agregar = false;
                  this.MensajeError("Este articulo ya ha sido agregado");
                }
                else if (Precio <= 0)
                {
                    this.MensajeError("El precio debe ser mayor a 0.");
                    return;
                }
            }

            if (Agregar) 
            { 
              DataRow Fila = DtDetalle.NewRow();
                Fila["idarticulo"] = IdArticulo;
                Fila["codigo"] = Codigo;
                Fila["articulo"] = Nombre;
                Fila["precio"] = Precio;
                Fila["importe"] = Precio;
                Fila["cantidad"] = 1;
                this.DtDetalle.Rows.Add(Fila);

                //Calcular totales
                this.CalcularTotales();

            }


        }

        private void CalcularTotales()
        {
            decimal Total = 0;
            decimal Subtotal = 0;

            if (dgvDetalle.Rows.Count == 0)
            {
                Total = 0;
            }
            else
            {
                foreach(DataRow item in DtDetalle.Rows)
                {
                    Total = Total + Convert.ToDecimal(item["importe"]);
                }
            }

            Subtotal = Total / (1 + Convert.ToDecimal(txtImpuestos.Text));
            txtTotal.Text = Total.ToString("#0.00#");
            txtSubtotal.Text = Subtotal.ToString("#0.00#");
            txtTotalImpuestos.Text = (Total - Subtotal).ToString("#0.00#");
        }

        private void bntVerArticulos_Click(object sender, EventArgs e)
        {
            FrmMostrarArticulos frm = new FrmMostrarArticulos();
            frm.ShowDialog();
            this.AgregarDetalle(Variables.IdArticulo, Variables.Codigo, Variables.NombreArticulo, Variables.Precio);
        }
        private void dgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataRow fila = (DataRow)DtDetalle.Rows[e.RowIndex];
                decimal precio = Convert.ToDecimal(fila["precio"]);
                int cantidad = Convert.ToInt32(fila["cantidad"]);

                // Validar que los valores no sean negativos o cero
                if (precio <= 0)
                {
                    this.MensajeError("El precio no puede ser cero o negativo.");
                    fila["precio"] = 1;
                }

                if (cantidad <= 0)
                {
                    this.MensajeError("La cantidad no puede ser cero o negativa.");
                    fila["cantidad"] = 1;
                }

                // Calcular el importe
                precio = Convert.ToDecimal(fila["precio"]);
                cantidad = Convert.ToInt32(fila["cantidad"]);
                fila["importe"] = cantidad * precio;

                this.CalcularTotales();
            }
            catch (Exception ex)
            {
                this.MensajeError("Error al editar el detalle: " + ex.Message);
            }

        }

        private void dgvDetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.CalcularTotales();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
                try
                {
                    string respuesta = ""; //aqui guardamos la respuesta que viene desde la capa de Datos
                    if (txtIdProveedor.Text == string.Empty || txtImpuestos.Text == string.Empty || txtNumeroComprobante.Text == string.Empty || DtDetalle.Rows.Count == 0)
                    {
                        this.MensajeError("Faltan campos por completar");
                    }
                    else
                    {
                        //Insertar el articulo
                        respuesta = NIngreso.Insertar(Convert.ToInt32(txtIdProveedor.Text), Variables.IdUsuario, cmbComprobante.Text, txtSerieComprobante.Text.Trim(),
                            txtNumeroComprobante.Text.Trim(), Convert.ToDecimal(txtImpuestos.Text), Convert.ToDecimal(txtTotal.Text), DtDetalle);


                        if (respuesta.Equals("OK"))
                        {
                            this.MensajeOk("El Registro se Insertó Correctamente");
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

                    MessageBox.Show(ex.Message);
                }
            
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
                dgvMostrarDetalles.DataSource = NIngreso.ListarDetalle(Convert.ToInt32(dgvListado.CurrentRow.Cells["Id"].Value));
                decimal total, subtotal;
                decimal Impuesto = Convert.ToDecimal(dgvListado.CurrentRow.Cells["Impuesto"].Value);
                total = Convert.ToDecimal(dgvListado.CurrentRow.Cells["Total"].Value);
                subtotal = total / (1 + Impuesto);
                txtTotalD.Text = total.ToString("#0.00#");
                txtSubtotalD.Text = subtotal.ToString("#0.00#");
                txtTotalImpuestosD.Text = (total - subtotal).ToString("#0.00#");
                panelDetalleIngreso.Visible = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            panelDetalleIngreso.Visible = false;
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked)
            {
                dgvListado.Columns[0].Visible = true;
                btnAnular.Visible = true;
            }
            else
            {
                dgvListado.Columns[0].Visible = false;
                btnAnular.Visible = false;
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea anular el (los) registro(s) Seleccionado(s)", "Sistema de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                            rpta = NIngreso.Anular(codigo);
                            if (rpta == "OK")
                            {
                                this.MensajeOk("Se anuló el registro: " + Convert.ToString(row.Cells[2].Value));
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
        }    //Fin del metodo eliminar

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
            this.Limpiar();
            tabPrincipal.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}
       
    

