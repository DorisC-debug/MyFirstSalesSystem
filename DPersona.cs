using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidad;


namespace Sistema.Datos
{
    public class DPersona
    {
        //Metodo para listar las categorias
        public DataTable Listar()
        {
            //Es crear un objeto que nos permita traer la data de la base de datos
            SqlDataReader Resultado;
            //Como debemos retornar un DataTable, crearemos una variable de tipo DataTable
            DataTable Tabla = new DataTable();
            //Crear un objeto para conectarnos al servidor y la base de datos
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Nos conectamos a la base de datos y traemos los registros (tabla de categorias)
                sqlConnection = Conexion.getInstancia().CrearConexion(); //la clase Conexion de devuelve el connection string para conectarnos a la base de datos
                //Tenemos que configurar el comando que le vamos a enviar a SQL Server
                //Creamos un objeto de tipo SqlCommand
                SqlCommand Comando = new SqlCommand("persona_listar", sqlConnection);
                //Hay que decirle que lo que se va a ejecutar es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //Abrir la conexion
                sqlConnection.Open();
                //Ejecutamos el comando
                Resultado = Comando.ExecuteReader();
                //Debemos convertir el Resultado a un DataTable
                Tabla.Load(Resultado);
                //retornamos la Tabla
                return Tabla;

            }
            catch (Exception ex)
            {

                throw ex; //esta linea hace que si ocurre un error, el sistema me lo informe
            }
            finally
            {
                //Siempre debemos cerrar la conexion al servidor
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

        }//fin del metodo Listar

        //Metodo para listar proveedores
        public DataTable ListarProveedores()
        {
            //Es crear un objeto que nos permita traer la data de la base de datos
            SqlDataReader Resultado;
            //Como debemos retornar un DataTable, crearemos una variable de tipo DataTable
            DataTable Tabla = new DataTable();
            //Crear un objeto para conectarnos al servidor y la base de datos
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Nos conectamos a la base de datos y traemos los registros (tabla de categorias)
                sqlConnection = Conexion.getInstancia().CrearConexion(); //la clase Conexion de devuelve el connection string para conectarnos a la base de datos
                //Tenemos que configurar el comando que le vamos a enviar a SQL Server
                //Creamos un objeto de tipo SqlCommand
                SqlCommand Comando = new SqlCommand("persona_listar_proveedores", sqlConnection);
                //Hay que decirle que lo que se va a ejecutar es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //Abrir la conexion
                sqlConnection.Open();
                //Ejecutamos el comando
                Resultado = Comando.ExecuteReader();
                //Debemos convertir el Resultado a un DataTable
                Tabla.Load(Resultado);
                //retornamos la Tabla
                return Tabla;

            }
            catch (Exception ex)
            {

                throw ex; //esta linea hace que si ocurre un error, el sistema me lo informe
            }
            finally
            {
                //Siempre debemos cerrar la conexion al servidor
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

        }//fin del metodo Listar

        //Metodo para listar las categorias
        public DataTable ListarClientes()
        {
            //Es crear un objeto que nos permita traer la data de la base de datos
            SqlDataReader Resultado;
            //Como debemos retornar un DataTable, crearemos una variable de tipo DataTable
            DataTable Tabla = new DataTable();
            //Crear un objeto para conectarnos al servidor y la base de datos
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Nos conectamos a la base de datos y traemos los registros (tabla de categorias)
                sqlConnection = Conexion.getInstancia().CrearConexion(); //la clase Conexion de devuelve el connection string para conectarnos a la base de datos
                //Tenemos que configurar el comando que le vamos a enviar a SQL Server
                //Creamos un objeto de tipo SqlCommand
                SqlCommand Comando = new SqlCommand("persona_listar_clientes", sqlConnection);
                //Hay que decirle que lo que se va a ejecutar es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //Abrir la conexion
                sqlConnection.Open();
                //Ejecutamos el comando
                Resultado = Comando.ExecuteReader();
                //Debemos convertir el Resultado a un DataTable
                Tabla.Load(Resultado);
                //retornamos la Tabla
                return Tabla;

            }
            catch (Exception ex)
            {

                throw ex; //esta linea hace que si ocurre un error, el sistema me lo informe
            }
            finally
            {
                //Siempre debemos cerrar la conexion al servidor
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

        }//fin del metodo Listar


        //Metodo para buscar categorias
        public DataTable Buscar(string valor)
        {
            //Es crear un objeto que nos permita traer la data de la base de datos
            SqlDataReader Resultado;
            //Como debemos retornar un DataTable, crearemos una variable de tipo DataTable
            DataTable Tabla = new DataTable();
            //Crear un objeto para conectarnos al servidor y la base de datos
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                //Crear la cadena de conexion
                sqlConnection = Conexion.getInstancia().CrearConexion();
                //configuramos el comando
                SqlCommand Comando = new SqlCommand("persona_buscar", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //debemos configurar el parametro a enviar al procedimiento almacenado
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                //abrimos la conexion
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
                {
                    sqlConnection.Close();
                }
            }

        }//Fin del metodo Buscar

        //Metodo para buscar categorias
        public DataTable BuscarProveedores(string valor)
        {
            //Es crear un objeto que nos permita traer la data de la base de datos
            SqlDataReader Resultado;
            //Como debemos retornar un DataTable, crearemos una variable de tipo DataTable
            DataTable Tabla = new DataTable();
            //Crear un objeto para conectarnos al servidor y la base de datos
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                //Crear la cadena de conexion
                sqlConnection = Conexion.getInstancia().CrearConexion();
                //configuramos el comando
                SqlCommand Comando = new SqlCommand("persona_buscar_proveedores", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //debemos configurar el parametro a enviar al procedimiento almacenado
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                //abrimos la conexion
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
                {
                    sqlConnection.Close();
                }
            }

        }//Fin del metodo Buscar

        //Metodo para buscar categorias
        public DataTable BuscarClientes(string valor)
        {
            //Es crear un objeto que nos permita traer la data de la base de datos
            SqlDataReader Resultado;
            //Como debemos retornar un DataTable, crearemos una variable de tipo DataTable
            DataTable Tabla = new DataTable();
            //Crear un objeto para conectarnos al servidor y la base de datos
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                //Crear la cadena de conexion
                sqlConnection = Conexion.getInstancia().CrearConexion();
                //configuramos el comando
                SqlCommand Comando = new SqlCommand("persona_buscar_clientes", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //debemos configurar el parametro a enviar al procedimiento almacenado
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                //abrimos la conexion
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
                {
                    sqlConnection.Close();
                }
            }

        }//Fin del metodo Buscar
        public string Insertar(Persona Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = Obj.TipoPersona;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento;
                Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        //Actualizar Persona

        public string Actualizar(Persona Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_actuializar", SqlCon);


                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idpersona", SqlDbType.Int).Value = Obj.IdPersona;
                Comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = Obj.TipoPersona;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento;
                Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        //Eliminar Persona
        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idpersona ", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}

