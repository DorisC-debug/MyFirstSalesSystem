using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class DLogin
    {
        //metodo para gestionar el login en la base de datos
        public DataTable Login(string email, string clave)
        {
            //Crear un objeto que nos permita traer la data de la base de datos
            SqlDataReader Resultado;
            //Como debemos retornar una tabla, un DataTable, creamos una varianble de tipo DataTable
            DataTable Tabla = new DataTable();
            //Crear un objeto para conectarnos al servidor y la base de datos
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Crear la cadena de conexion
                sqlConnection = Conexion.getInstancia().CrearConexion();
                //Creamos el comando
                SqlCommand Comando = new SqlCommand("usuario_login", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //debemos configurar el parametro a enviar al procedimiento almacenado
                Comando.Parameters.Add(@"email", SqlDbType.VarChar).Value = email;
                Comando.Parameters.Add(@"clave", SqlDbType.VarChar).Value = clave;
                //Ahora abrimos la coneccion
                sqlConnection.Open();
                //ejecutamos el comando 
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                //Siempre debemos cerrar la conexion al servidor
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

        }//Fin del metodo buscar

    }
}
