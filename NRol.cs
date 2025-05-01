using Sistema.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NRol
    {
        public static DataTable Listar()
        {
            //Crear un objeto de la clase DArticulo
            DRol datos = new DRol();
            return datos.Listar(); //Esta linea llama al metodo Listar() de la clase DArticulo
        }//Fin del metodo Listar()
    }
}
