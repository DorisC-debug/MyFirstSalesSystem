using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NUsuario
    {
        //Listar las categorias
        public static DataTable Listar()
        {
            //Crear un objeto de la clase DArticulo
            DUsuario datos = new DUsuario();
            return datos.Listar(); //Esta linea llama al metodo Listar() de la clase DArticulo
        }//Fin del metodo Listar()

        public static DataTable CargarRoles()
        {
            //Crear un objeto de la clase DArticulo
            DUsuario datos = new DUsuario();
            return datos.CargarRoles();//Esta linea llama al metodo CargarCategorias() de la clase DArticulo
        }//Fin del metodo Listar()


        //Buscar Categorias
        public static DataTable Buscar(string valor)
        {
            //creamos un objeto de la clase DArticulos
            DUsuario datos = new DUsuario();
            return datos.Buscar(valor); //Aqui llamamos al metodo listar de la clase DCategoria
        }//Fin del metodo buscar

        //Insertar una categoria
        public static string Insertar( int IdRol , string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono,
        string Email, string Clave)
        {
            //Creamos un objeto de la clase categoria
            DUsuario datos = new DUsuario();

            //antes de insertar la categoria, investigamos si existe 
            string existe = datos.Existe(Nombre);
            if (existe == "1")
            {
                return "El articulo existe";

            }
            else
            {
                //El articulo no existe, entonces la vamos a insertar en la base de datos 
                //Primero debemos crear un objeto Articulo
                Usuario usuario = new Usuario();
                //Le pasamos los parametros o argumentos 
                usuario.Nombre = Nombre;
                usuario.IdRol = IdRol;
                usuario.TipoDocumento = TipoDocumento;
                usuario.NumDocumento = NumDocumento;
                usuario.Direccion = Direccion;
                usuario.Telefono = Telefono;
                usuario.Email = Email;
                usuario.Clave = Clave;
                //Insertamos el Articulo
                return datos.Insertar(usuario);
            }
        }//Fin del metodo insertar

        //Actualizar una categoria
        public static string Actualizar(int IdUsuario, int IdRol, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono,
        string Email, string Clave)
        {
            DUsuario datos = new DUsuario();
            //El articulo no existe, entonces la vamos a insertar en la base de datos 
            //Primero debemos crear un objeto Articulo
            Usuario usuario = new Usuario();
            //Le pasamos los parametros o argumentos 
            usuario.IdUsuario = IdUsuario;
            usuario.Nombre = Nombre;
            usuario.IdRol = IdRol;
            usuario.TipoDocumento = TipoDocumento;
            usuario.NumDocumento = NumDocumento;
            usuario.Direccion = Direccion;
            usuario.Telefono = Telefono;
            usuario.Email = Email;
            usuario.Clave = Clave;
            //Insertamos el Articulo
            return datos.Actualizar(usuario);

        }//Fin del metodo Actualizar

        //Eliminar una categoria
        public static string Eliminar(int id)
        {
            //Creamos un objeto de la clase categoria
            DUsuario datos = new DUsuario();
            //Eliminamos la categoria
            return datos.Eliminar(id);

        }//Fin del metodo Eliminar

        //Activar una categria
        public static string Activar(int id)
        {
            //Creamos un objeto de la clase categoria
            DUsuario datos = new DUsuario();
            //Eliminamos la categoria
            return datos.Activar(id);

        }//Fin del metodo Activar

        //Desactivar una categria
        public static string Desactivar(int id)
        {
            //Creamos un objeto de la clase categoria
            DUsuario datos = new DUsuario();
            //Eliminamos la categoria
            return datos.Desactivar(id);

        }//Fin del metodo Desactivar

    }
}
