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
    public class NPersona
    {
        //Listar persona

        public static DataTable Listar()
        {
            DPersona datos = new DPersona();
            return datos.Listar();
        }

        //Fin del metodo listar



        //Metodo Listar proveedores

        public static DataTable ListarProveedores()
        {
            DPersona datos = new DPersona();
            return datos.ListarProveedores();
        }


        //Fin del Metodo Listarproveedores


        //Metodo Listar clientes
        public static DataTable ListarClientes()
        {
            DPersona datos = new DPersona();
            return datos.ListarClientes();

        }

        //Fin del Metodo ListarClientes

        //Buscar Persona


        public static DataTable Buscar(string valor)
        {

            DPersona datos = new DPersona();
            return datos.Buscar(valor);
        }
        //Fin Metoddo buscar

        //Buscar proveedores


        public static DataTable BuscarProveedores(string valor)
        {

            DPersona datos = new DPersona();
            return datos.BuscarProveedores(valor);
        }
        //Fin Metoddo buscar Proveedores


        //Buscar cliente


        public static DataTable BuscarClientes(string valor)
        {

            DPersona datos = new DPersona();
            return datos.BuscarClientes(valor);
        }
        //Fin Metoddo buscar cliente

        //Inaertar Persona

        public static string Insertar(string tipoPersona, string nombre, string tipoDocumento, string numDocumento,
            string direccion, string telefono, string email)
        {
            DPersona datos = new DPersona();
            Persona persona = new Persona();

            persona.TipoPersona = tipoPersona;
            persona.Nombre = nombre;
            persona.TipoDocumento = tipoDocumento;
            persona.NumDocumento = numDocumento;
            persona.Direccion = direccion;
            persona.Telefono = telefono;
            persona.Email = email;

            return datos.Insertar(persona);

        }

        //Actualizar una persona

        public static string Actualizar(int idPersona, string tipoPersona, string nombre, string tipoDocumento, string numDocumento,
            string direccion, string telefono, string email)

        {

            DPersona datos = new DPersona();
            Persona persona = new Persona();

            persona.IdPersona = idPersona;
            persona.TipoPersona = tipoPersona;
            persona.Nombre = nombre;
            persona.TipoDocumento = tipoDocumento;
            persona.NumDocumento = numDocumento;
            persona.Direccion = direccion;
            persona.Telefono = telefono;
            persona.Email = email;

            return datos.Actualizar(persona);




        }


        //Eliminar Una persona 

        public static string Eliminar(int idPersona)
        {
            DPersona datos = new DPersona();
            return datos.Eliminar(idPersona);

        }
    }



}
