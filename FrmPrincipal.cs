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
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        //Declarar variables de clase para recibir informacion del usuario que esta haciendo el login
        public int IdUsuario { get; set; }

        public int IdRol { get; set; }

        public string Rol { get; set; }

        public string Nombre { get; set; }

        public bool Estado { get; set; }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciar un objeto de frmCategorias
            FrmCategorias frm = new FrmCategorias();
            //Lo ponemos como un hijo del frmPrincipal
            frm.MdiParent = this;
            //mostramos el formulario
            frm.Show();

        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciar un objeto de frmCategorias
            FrmArticulos frmArticulos = new FrmArticulos();
            //Lo ponemos como un hijo del frmPrincipal
            frmArticulos.MdiParent = this;
            //mostramos el formulario
            frmArticulos.Show();

        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol frm = new FrmRol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            if(Rol.Equals("Administrador"))
            {
                almacénToolStripMenuItem.Enabled = true;
                ingresosToolStripMenuItem.Enabled = true;
                ventasToolStripMenuItem.Enabled = true;
                accesosToolStripMenuItem.Enabled = true;
                comprasToolStripMenuItem.Enabled = true;
                consultasDeComprasToolStripMenuItem.Enabled=true;
            }

             else if (Rol.Equals("Vendedor"))
            {
                almacénToolStripMenuItem.Enabled = false;
                ingresosToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem.Enabled = true;
                accesosToolStripMenuItem.Enabled = false;
                comprasToolStripMenuItem.Enabled = false;
                consultasDeComprasToolStripMenuItem.Enabled = true;
            }
            else if (Rol.Equals("Almacenista"))
            {
                almacénToolStripMenuItem.Enabled = true;
                ingresosToolStripMenuItem.Enabled = true;
                ventasToolStripMenuItem.Enabled = false;
                accesosToolStripMenuItem.Enabled = false;
                comprasToolStripMenuItem.Enabled = true;
                consultasDeComprasToolStripMenuItem.Enabled = false;
            }

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Deseas salir del Sistema?", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmproveedores frm = new Frmproveedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresos frm = new FrmIngresos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
