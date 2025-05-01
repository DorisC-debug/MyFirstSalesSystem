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
    public class DArticulo
    {
        //Listar los articulos

        //Metodo para listar los Articulos que hay en el sistema
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
                SqlCommand Comando = new SqlCommand("articulo_listar", sqlConnection);
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

        //Metodo para buscar categorias
        public DataTable Buscar(string valor)
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
                SqlCommand Comando = new SqlCommand("articulo_buscar", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //debemos configurar el parametro a enviar al procedimiento almacenado
                Comando.Parameters.Add(@"valor", SqlDbType.VarChar).Value = valor;
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
        public DataTable BuscarCodigo(string valor)
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
                SqlCommand Comando = new SqlCommand("articulo_buscar_codigo", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //debemos configurar el parametro a enviar al procedimiento almacenado
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
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

        //Metodo para determinar si un articulo existe
        public string Existe(string valor)
        {
            //Como devolvemos un string vamos a declarar una variable para almacenar el valor a devolver 
            string Respuesta = "";

            //Solo crearemos el objeto de conexion
            //Crear un objeto para conectarnos al servidor y la base de datos
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                //obtenemos la cadena de conexion
                sqlConnection = Conexion.getInstancia().CrearConexion();
                //Configurar el comando
                SqlCommand Comando = new SqlCommand("articulo_existe", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //Configuramos el parametro valor
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                //Configurar un parametro para almacenar el valor devuelto por el procedimiento almacenado
                SqlParameter existe = new SqlParameter();
                //Debo indicar al parametro que va a apuntar en el procedimiento almacenado
                existe.ParameterName = "@existe";
                //Le indicamos el sentido del parametro existe
                existe.Direction = ParameterDirection.Output;
                //anadims el patrametro al comando
                Comando.Parameters.Add(existe);
                //Abrimos la conexion
                sqlConnection.Open();
                //ejecutamos el comando, en este caso, no recibimos una tabla, solo valor 1 o 0, por lo que ejecutamos un Comando ExecuteNonQuery
                Comando.ExecuteNonQuery();
                Respuesta = Convert.ToString(existe.Value);

            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                //Siempre debemos cerrar la conexion al servidor
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            //devolvemos la respuesta
            return Respuesta;


        }//fin del metodo Existe

        //Metodo para insertar o crear un nuevo articulo
        public string Insertar(Articulo articulo)
        {
            string Respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Obtenemos la cadena de conexion
                sqlConnection = Conexion.getInstancia().CrearConexion();
                //Configurar el comando
                SqlCommand Comando = new SqlCommand("articulo_insertar", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //Configurar los parametros que vamos a enviar
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = articulo.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = articulo.Descripcion;
                Comando.Parameters.Add("@idcategoria", SqlDbType.VarChar).Value = articulo.IdCategoria;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = articulo.Codigo;
                Comando.Parameters.Add("@precio_venta", SqlDbType.VarChar).Value = articulo.PrecioVenta;
                Comando.Parameters.Add("@stock", SqlDbType.VarChar).Value = articulo.Stock;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = articulo.Imagen;
                //Abrimos la conexion 
                sqlConnection.Open();
                //ejecutando el comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el articulo";//Validamos que se inserto un registro, de ser asi guardamos ok


            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                //Siempre debemos cerrar la conexion al servidor
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            //devolvemos la respuesta
            return Respuesta;


        }//fin del metodo Insertar

        //Metodo para actualizar un articulo
        public string Actualizar(Articulo articulo)
        {
            string Respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Obtenemos la cadena de conexion
                sqlConnection = Conexion.getInstancia().CrearConexion();
                //Configurar el comando
                SqlCommand Comando = new SqlCommand("categoria_actualizar", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //Configurar los parametros que vamos a enviar
                Comando.Parameters.Add("idcategoria", SqlDbType.Int).Value = articulo.IdCategoria;
                Comando.Parameters.Add("idarticulo", SqlDbType.Int).Value = articulo.IdArticulo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = articulo.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = articulo.Descripcion;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = articulo.Codigo;
                Comando.Parameters.Add("@precio_venta", SqlDbType.VarChar).Value = articulo.PrecioVenta;
                Comando.Parameters.Add("@stock", SqlDbType.VarChar).Value = articulo.Stock;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = articulo.Imagen;
                //Abrimos la conexion 
                sqlConnection.Open();
                //ejecutando el comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el articulo";//Validamos que se inserto un registro, de ser asi guardamos ok


            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                //Siempre debemos cerrar la conexion al servidor
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            //devolvemos la respuesta
            return Respuesta;


        }//fin del metodo Actualizar

        //Metodo para eliminar una categoria
        public string Eliminar(int id)
        {
            string Respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Obtenemos la cadena de conexion
                sqlConnection = Conexion.getInstancia().CrearConexion();
                //Configurar el comando
                SqlCommand Comando = new SqlCommand("articulo_eliminar", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //Configurar los parametros que vamos a enviar
                Comando.Parameters.Add("idarticulo", SqlDbType.Int).Value = id;
                //Abrimos la conexion 
                sqlConnection.Open();
                //ejecutando el comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el articulo";//Validamos que se inserto un registro, de ser asi guardamos ok


            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                //Siempre debemos cerrar la conexion al servidor
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            //devolvemos la respuesta
            return Respuesta;


        }//fin del metodo Eliminar

        //Metodo para activar una categoria
        public string Activar(int id)
        {
            string Respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Obtenemos la cadena de conexion
                sqlConnection = Conexion.getInstancia().CrearConexion();
                //Configurar el comando
                SqlCommand Comando = new SqlCommand("articulo_activar", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //Configurar los parametros que vamos a enviar
                Comando.Parameters.Add("idarticulo", SqlDbType.Int).Value = id;
                //Abrimos la conexion 
                sqlConnection.Open();
                //ejecutando el comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el articulo";//Validamos que se inserto un registro, de ser asi guardamos ok


            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                //Siempre debemos cerrar la conexion al servidor
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            //devolvemos la respuesta
            return Respuesta;


        }//fin del metodo Activar

        //Metodo para desactivar
        public string Desactivar(int id)
        {
            string Respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Obtenemos la cadena de conexion
                sqlConnection = Conexion.getInstancia().CrearConexion();
                //Configurar el comando
                SqlCommand Comando = new SqlCommand("articulo_desactivar", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                //Configurar los parametros que vamos a enviar
                Comando.Parameters.Add("idarticulo", SqlDbType.Int).Value = id;
                //Abrimos la conexion 
                sqlConnection.Open();
                //ejecutando el comando
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el articulo";//Validamos que se inserto un registro, de ser asi guardamos ok


            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                //Siempre debemos cerrar la conexion al servidor
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            //devolvemos la respuesta
            return Respuesta;


        }//fin del metodo Desactivar

        public DataTable CargarCategorias()
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
                SqlCommand Comando = new SqlCommand("categoria_seleccionar", sqlConnection);
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



