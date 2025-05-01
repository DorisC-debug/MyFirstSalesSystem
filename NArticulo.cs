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
    public class NArticulo
    {
        //Listar las categorias
        public static DataTable Listar()
        {
            //Crear un objeto de la clase DArticulo
            DArticulo datos = new DArticulo();
            return datos.Listar(); //Esta linea llama al metodo Listar() de la clase DArticulo
        }//Fin del metodo Listar()

        public static DataTable CargarCategorias()
        {
            //Crear un objeto de la clase DArticulo
            DArticulo datos = new DArticulo();
            return datos.CargarCategorias(); //Esta linea llama al metodo CargarCategorias() de la clase DArticulo
        }//Fin del metodo Listar()


        //Buscar Categorias
        public static DataTable Buscar(string valor)
        {
            //creamos un objeto de la clase DArticulos
            DArticulo datos = new DArticulo();
            return datos.Buscar(valor); //Aqui llamamos al metodo listar de la clase DCategoria
        }//Fin del metodo buscar

        public static DataTable BuscarCodigo(string valor)
        {
            //creamos un objeto de la clase DArticulos
            DArticulo datos = new DArticulo();
            return datos.BuscarCodigo(valor); //Aqui llamamos al metodo listar de la clase DCategoria
        }//Fin del metodo buscar

        //Insertar una categoria
        public static string Insertar(string nombre, string descripcion, int idcategoria, string codigo, decimal precioVenta, int stock, string imagen)
        {
            //Creamos un objeto de la clase categoria
            DArticulo datos = new DArticulo();

            //antes de insertar la categoria, investigamos si existe 
            string existe = datos.Existe(nombre);
            if (existe == "1")
            {
                return "El articulo existe";

            }
            else
            {
                //El articulo no existe, entonces la vamos a insertar en la base de datos 
                //Primero debemos crear un objeto Articulo
                Articulo articulo = new Articulo();
                //Le pasamos los parametros o argumentos 
                articulo.Nombre = nombre;
                articulo.Descripcion = descripcion;
                articulo.IdCategoria = idcategoria;
                articulo.Codigo = codigo;
                articulo.PrecioVenta = precioVenta;
                articulo.Stock = stock;
                articulo.Imagen = imagen;
                //Insertamos el Articulo
                return datos.Insertar(articulo);
            }
        }//Fin del metodo insertar

        //Actualizar una categoria
        public static string Actualizar(string nombre, string descripcion, int idcategoria, string codigo, decimal precioVenta, int stock, string imagen, int idarticulo)
        {
            //Creamos un objeto de la clase DArticulo
              DArticulo datos = new DArticulo();

            //La categoria no existe, entonces la vamos a insertar en la base de datos 
            //Primero debemos crear un objeto Articulo
            Articulo articulo = new Articulo();
            //Le pasamos los parametros o argumentos 
            articulo.Nombre = nombre;
            articulo.Descripcion = descripcion;
            articulo.IdCategoria = idcategoria;
            articulo.IdArticulo = idarticulo;
            articulo.Codigo = codigo;
            articulo.PrecioVenta = precioVenta;
            articulo.Stock = stock;
            articulo.Imagen = imagen;
            //Insertamos la categoria
            return datos.Actualizar(articulo);

        }//Fin del metodo Actualizar

        //Eliminar una categoria
        public static string Eliminar(int id)
        {
            //Creamos un objeto de la clase categoria
            DArticulo datos = new DArticulo();
            //Eliminamos la categoria
            return datos.Eliminar(id);

        }//Fin del metodo Eliminar

        //Activar una categria
        public static string Activar(int id)
        {
            //Creamos un objeto de la clase categoria
            DArticulo datos = new DArticulo();
            //Eliminamos la categoria
            return datos.Activar(id);

        }//Fin del metodo Activar

        //Desactivar una categria
        public static string Desactivar(int id)
        {
            //Creamos un objeto de la clase categoria
            DArticulo datos = new DArticulo();
            //Eliminamos la categoria
            return datos.Desactivar(id);

        }//Fin del metodo Desactivar
    }

}

