namespace Sistema.Presentacion
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelDetalleIngreso = new System.Windows.Forms.Panel();
            this.txtTotalImpuestosD = new System.Windows.Forms.TextBox();
            this.txtTotalD = new System.Windows.Forms.TextBox();
            this.txtSubtotalD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvMostrarDetalles = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalImpuestos = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.bntVerArticulos = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbComprobante = new System.Windows.Forms.ComboBox();
            this.txtSerieComprobante = new System.Windows.Forms.TextBox();
            this.txtNumeroComprobante = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelDetalleIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPage1);
            this.tabPrincipal.Controls.Add(this.tabPage2);
            this.tabPrincipal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrincipal.Location = new System.Drawing.Point(2, 3);
            this.tabPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1209, 718);
            this.tabPrincipal.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelDetalleIngreso);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.btnAnular);
            this.tabPage1.Controls.Add(this.chkSeleccionar);
            this.tabPage1.Controls.Add(this.dgvListado);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1201, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelDetalleIngreso
            // 
            this.panelDetalleIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelDetalleIngreso.Controls.Add(this.txtTotalImpuestosD);
            this.panelDetalleIngreso.Controls.Add(this.txtTotalD);
            this.panelDetalleIngreso.Controls.Add(this.txtSubtotalD);
            this.panelDetalleIngreso.Controls.Add(this.label13);
            this.panelDetalleIngreso.Controls.Add(this.label12);
            this.panelDetalleIngreso.Controls.Add(this.labe);
            this.panelDetalleIngreso.Controls.Add(this.btnCerrar);
            this.panelDetalleIngreso.Controls.Add(this.dgvMostrarDetalles);
            this.panelDetalleIngreso.Location = new System.Drawing.Point(149, 43);
            this.panelDetalleIngreso.Name = "panelDetalleIngreso";
            this.panelDetalleIngreso.Size = new System.Drawing.Size(828, 442);
            this.panelDetalleIngreso.TabIndex = 7;
            this.panelDetalleIngreso.Visible = false;
            // 
            // txtTotalImpuestosD
            // 
            this.txtTotalImpuestosD.Location = new System.Drawing.Point(706, 361);
            this.txtTotalImpuestosD.Name = "txtTotalImpuestosD";
            this.txtTotalImpuestosD.Size = new System.Drawing.Size(100, 25);
            this.txtTotalImpuestosD.TabIndex = 7;
            // 
            // txtTotalD
            // 
            this.txtTotalD.Location = new System.Drawing.Point(706, 396);
            this.txtTotalD.Name = "txtTotalD";
            this.txtTotalD.Size = new System.Drawing.Size(100, 25);
            this.txtTotalD.TabIndex = 6;
            // 
            // txtSubtotalD
            // 
            this.txtSubtotalD.Location = new System.Drawing.Point(706, 323);
            this.txtSubtotalD.Name = "txtSubtotalD";
            this.txtSubtotalD.Size = new System.Drawing.Size(100, 25);
            this.txtSubtotalD.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(594, 404);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(594, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total Impuestos";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(594, 323);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(63, 17);
            this.labe.TabIndex = 2;
            this.labe.Text = "Sub Total";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(745, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(61, 45);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvMostrarDetalles
            // 
            this.dgvMostrarDetalles.AllowUserToAddRows = false;
            this.dgvMostrarDetalles.AllowUserToDeleteRows = false;
            this.dgvMostrarDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDetalles.Location = new System.Drawing.Point(26, 57);
            this.dgvMostrarDetalles.Name = "dgvMostrarDetalles";
            this.dgvMostrarDetalles.ReadOnly = true;
            this.dgvMostrarDetalles.RowHeadersWidth = 51;
            this.dgvMostrarDetalles.RowTemplate.Height = 24;
            this.dgvMostrarDetalles.Size = new System.Drawing.Size(780, 263);
            this.dgvMostrarDetalles.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(794, 503);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 17);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total de Registros:";
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(384, 507);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(164, 28);
            this.btnAnular.TabIndex = 5;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.Location = new System.Drawing.Point(7, 507);
            this.chkSeleccionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(98, 21);
            this.chkSeleccionar.TabIndex = 1;
            this.chkSeleccionar.Text = "Seleccionar";
            this.chkSeleccionar.UseVisualStyleBackColor = true;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.chkSeleccionar_CheckedChanged);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvListado.Location = new System.Drawing.Point(6, 41);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.Size = new System.Drawing.Size(1177, 458);
            this.dgvListado.TabIndex = 2;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(464, 11);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 25);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(7, 11);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(434, 25);
            this.txtBuscar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnInsertar);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1201, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(459, 650);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 24);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(302, 650);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(112, 24);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtTotalImpuestos);
            this.groupBox1.Controls.Add(this.txtSubtotal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgvDetalle);
            this.groupBox1.Controls.Add(this.bntVerArticulos);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(22, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 442);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "(*)Indica que el dato es obligatorio";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(737, 397);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(117, 25);
            this.txtTotal.TabIndex = 18;
            // 
            // txtTotalImpuestos
            // 
            this.txtTotalImpuestos.Location = new System.Drawing.Point(737, 352);
            this.txtTotalImpuestos.Name = "txtTotalImpuestos";
            this.txtTotalImpuestos.ReadOnly = true;
            this.txtTotalImpuestos.Size = new System.Drawing.Size(117, 25);
            this.txtTotalImpuestos.TabIndex = 17;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(737, 311);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(117, 25);
            this.txtSubtotal.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(597, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total Impuestos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(597, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Subtotal";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(9, 78);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(1058, 215);
            this.dgvDetalle.TabIndex = 14;
            this.dgvDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellEndEdit);
            this.dgvDetalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetalle_RowsRemoved);
            // 
            // bntVerArticulos
            // 
            this.bntVerArticulos.Location = new System.Drawing.Point(617, 38);
            this.bntVerArticulos.Name = "bntVerArticulos";
            this.bntVerArticulos.Size = new System.Drawing.Size(112, 27);
            this.bntVerArticulos.TabIndex = 13;
            this.bntVerArticulos.Text = "Ver";
            this.bntVerArticulos.UseVisualStyleBackColor = true;
            this.bntVerArticulos.Click += new System.EventHandler(this.bntVerArticulos_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(67, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(544, 25);
            this.txtCodigo.TabIndex = 13;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Articulo";
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.label5);
            this.groupbox.Controls.Add(this.label4);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.cmbComprobante);
            this.groupbox.Controls.Add(this.txtSerieComprobante);
            this.groupbox.Controls.Add(this.txtNumeroComprobante);
            this.groupbox.Controls.Add(this.txtImpuestos);
            this.groupbox.Controls.Add(this.btnBuscarClientes);
            this.groupbox.Controls.Add(this.txtNombreCliente);
            this.groupbox.Controls.Add(this.txtIdCliente);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.txtId);
            this.groupbox.Location = new System.Drawing.Point(13, 5);
            this.groupbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox.Name = "groupbox";
            this.groupbox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox.Size = new System.Drawing.Size(904, 171);
            this.groupbox.TabIndex = 1;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Cabecera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "NUMERO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "SERIE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Impuesto(*)";
            // 
            // cmbComprobante
            // 
            this.cmbComprobante.AutoCompleteCustomSource.AddRange(new string[] {
            "FACTURA",
            "TICKET",
            "BOLETA",
            "GUIA"});
            this.cmbComprobante.FormattingEnabled = true;
            this.cmbComprobante.Items.AddRange(new object[] {
            "FACTURA",
            "TICKET",
            "BOLETO",
            "GUIA"});
            this.cmbComprobante.Location = new System.Drawing.Point(116, 113);
            this.cmbComprobante.Name = "cmbComprobante";
            this.cmbComprobante.Size = new System.Drawing.Size(179, 25);
            this.cmbComprobante.TabIndex = 9;
            // 
            // txtSerieComprobante
            // 
            this.txtSerieComprobante.Location = new System.Drawing.Point(319, 113);
            this.txtSerieComprobante.Name = "txtSerieComprobante";
            this.txtSerieComprobante.Size = new System.Drawing.Size(117, 25);
            this.txtSerieComprobante.TabIndex = 8;
            // 
            // txtNumeroComprobante
            // 
            this.txtNumeroComprobante.Location = new System.Drawing.Point(472, 113);
            this.txtNumeroComprobante.Name = "txtNumeroComprobante";
            this.txtNumeroComprobante.Size = new System.Drawing.Size(190, 25);
            this.txtNumeroComprobante.TabIndex = 7;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(793, 113);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(90, 25);
            this.txtImpuestos.TabIndex = 6;
            this.txtImpuestos.Text = "0.18";
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Location = new System.Drawing.Point(460, 47);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(112, 24);
            this.btnBuscarClientes.TabIndex = 5;
            this.btnBuscarClientes.Text = "Buscar";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(194, 46);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(260, 25);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(98, 46);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(90, 25);
            this.txtIdCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comprobante(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente(*)";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(588, 16);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(119, 25);
            this.txtId.TabIndex = 0;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 783);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelDetalleIngreso.ResumeLayout(false);
            this.panelDetalleIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelDetalleIngreso;
        private System.Windows.Forms.TextBox txtTotalImpuestosD;
        private System.Windows.Forms.TextBox txtTotalD;
        private System.Windows.Forms.TextBox txtSubtotalD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvMostrarDetalles;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotalImpuestos;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button bntVerArticulos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbComprobante;
        private System.Windows.Forms.TextBox txtSerieComprobante;
        private System.Windows.Forms.TextBox txtNumeroComprobante;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
    }
}