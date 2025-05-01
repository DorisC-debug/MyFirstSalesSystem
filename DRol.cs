using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class DRol
    {
        public DataTable Listar()
        {
            //Crear un objeto que nos permita traer la data de la base de datos
            SqlDataReader Resultado;
            //Como debemos retornar una tabla, un DataTable, creamos una varianble de tipo DataTable
            DataTable Tabla = new DataTable();
            //Crear un objeto para conectarnos al servidor y la base de datos
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Nos conectamos a la base de datos y traemos los registros
                sqlConnection = Conexion.getInstancia().CrearConexion();//La Conexion nos devuelve el string para conectarnos a la base de datos
                                                                        //Tenemos que configurar el comando que le vamos a enviar a SQL Server
                                                                        //Creamos un objeto de tipo SqlCommand
                SqlCommand Comando = new SqlCommand("rol_listar", sqlConnection);
                //Hay que decir que lo que se va a ejecutar es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //Abrir la conexion
                sqlConnection.Open();
                //Ejecutamos el comando
                Resultado = Comando.ExecuteReader();
                //Debemos convertir el resultado a un DataTable
                Tabla.Load(Resultado);
                //Ahora retornamos la tabla
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;//Hace que si ocurre un error el sistema me lo informe
            }
            finally
            {
                //Siempre debemos cerrar la conexion al servidor
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }//Fin del metodo Listar

    }
}
