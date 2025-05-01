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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NLogin.Login(txtEmail.Text.Trim(), txtClave.Text.Trim());
                if (Tabla.Rows.Count <= 0)
                {
                    //Significa que el usuario no existe que el login fue incorrecto
                    MessageBox.Show("El email o la clave son incorrectos", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (Convert.ToBoolean(Tabla.Rows[0][4]) == false) //El usuario no esta activo
                {
                    MessageBox.Show("El usuario esta inactivo", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //Todo correcto
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                    Variables.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                    frm.IdRol = Convert.ToInt32(Tabla.Rows[0][1]);
                    frm.Rol = Convert.ToString(Tabla.Rows[0][2]);
                    frm.Nombre = Convert.ToString(Tabla.Rows[0][3]);
                    frm.Estado = Convert.ToBoolean(Tabla.Rows[0][4]);
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
