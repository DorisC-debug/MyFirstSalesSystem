using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class Conexion
    {
        //Parametros de conexion al servidor o database
        private string BaseDeDatos; //guardamos el nombre de la base de datos
        private string Servidor; //nombre del servidor
        private string Usuario; //nombre del usuario
        private string Clave; //clave para conectarnos
        private bool Seguridad; //detectar si nos conectamos usando Trusted Coneccion
        private static Conexion Conn = null; //instanciar la conexion

        //Constructor para ponerles valores iniciales

        private Conexion ()
        {
            this.BaseDeDatos = "dbsistemaIEESL";
            this.Servidor = "DESKTOP-16NKLSN\\SQLEXPRESS";
            this.Usuario = "sa";
            this.Clave = "";
            this.Seguridad = true;
        }

        //Creamos la logica de conexion
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.BaseDeDatos + ";";
                if (this.Seguridad)
                {
                    //Nos conectamos usando Trusted Coneccion
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    //Nos conectamos usando un usuario y una clave
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + "Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex; //Lanza el error
            } 

            //retorna la cadena de conexion con todos los parametros para conectarnos a nuestra base de datos
            return Cadena;

           
        }

        public static Conexion getInstancia() //Si no hay conxion activa, la creamos
        {
            if (Conn == null)
            {
                Conn = new Conexion();
            }
            return Conn; //Devolvemos la conexion
        }


    }
}
