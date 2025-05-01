using Sistema.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public static class NLogin
    {
        public static DataTable Login(string email, string clave)
        {
            DLogin datos = new DLogin();
            return datos.Login(email, clave);
        }
    }
}
