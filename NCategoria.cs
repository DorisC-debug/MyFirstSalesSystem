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
    public class NCategoria
    {
        //Listar las categorias
        public static DataTable Listar()
        {
            //Crear un objeto de la clase DCategoria
            DCategoria datos = new DCategoria();
            return datos.Listar(); //Esta linea llama al metodo Listar() de la clase DCategoria
        }//Fin del metodo Listar()

        //Buscar Categorias
        public static DataTable Buscar(string valor) 
        {
            //creamos un objeto de la clase DCategoria
            DCategoria datos = new DCategoria();
            return datos.Buscar(valor); //Aqui llamamos al metodo listar de la clase DCategoria
        }//Fin del metodo buscar

        //Insertar una categoria
        public static string Insertar(string nombre, string descripcion)
        {
            //Creamos un objeto de la clase categoria
            DCategoria datos = new DCategoria();

            //antes de insertar la categoria, investigamos si existe 
            string existe = datos.Existe(nombre);
            if(existe == "1")
            {
                return "La categoria existe";

            }
            else
            {
                //La categoria no existe, entonces la vamos a insertar en la base de datos 
                //Primero debemos crear un objeto Categoria
                Categoria categoria = new Categoria();
                //Le pasamos los parametros o argumentos 
                categoria.Nombre = nombre;
                categoria.Descripcion = descripcion;
                //Insertamos la categoria
                return datos.Insertar(categoria);
            }
        }//Fin del metodo insertar

        //Actualizar una categoria
        public static string Actualizar(int id, string nombre, string descripcion)
        {
            //Creamos un objeto de la clase categoria
            DCategoria datos = new DCategoria();

                //La categoria no existe, entonces la vamos a insertar en la base de datos 
                //Primero debemos crear un objeto Categoria
                Categoria categoria = new Categoria();
                //Le pasamos los parametros o argumentos 
                categoria.IdCategoria = id;
                categoria.Nombre = nombre;
                categoria.Descripcion = descripcion;
                //Insertamos la categoria
                return datos.Actualizar(categoria);
          
        }//Fin del metodo Actualizar

        //Eliminar una categoria
        public static string Eliminar(int id)
        {
            //Creamos un objeto de la clase categoria
            DCategoria datos = new DCategoria();
            //Eliminamos la categoria
            return datos.Eliminar(id);

        }//Fin del metodo Eliminar

        //Activar una categria
        public static string Activar(int id)
        {
            //Creamos un objeto de la clase categoria
            DCategoria datos = new DCategoria();
            //Eliminamos la categoria
            return datos.Activar(id);

        }//Fin del metodo Activar

        //Desactivar una categria
        public static string Desactivar(int id)
        {
            //Creamos un objeto de la clase categoria
            DCategoria datos = new DCategoria();
            //Eliminamos la categoria
            return datos.Desactivar(id);

        }//Fin del metodo Desactivar
    }

}
