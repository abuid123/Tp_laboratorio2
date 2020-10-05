using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KwikEMart
{
    public static class Inventario
    {
        #region Atributos
        static List<Producto> listaProductos;
        static List<Persona> listaPersona;
        static List<Venta> listaVentas;

        #endregion

        #region Propiedades
        public static List<Producto> ListaProductos 
        {
            get 
            { 
                return listaProductos;
            } 
        }

        public static List<Persona> ListaPersona 
        {
            get 
            {
                return listaPersona;
            }
        }

        public static List<Venta> ListaVenta 
        {
            get { return listaVentas; }
        }
        #endregion

        #region Constructores
        static Inventario()
        {
            listaProductos = new List<Producto>();
            listaPersona = new List<Persona>();
            listaVentas = new List<Venta>();
        }

        #endregion

        #region Metodos
        public static void HarcodeoProductos() 
        {
            listaProductos.Add(new Producto("Gelatina",200,1,1,2111));
            listaProductos.Add(new Producto("Frutillas",299,2,123456,23));
            listaProductos.Add(new Producto("Tomate",1000,3,2,3333));
            listaProductos.Add(new Producto("Helado",200,64,4,2122211));
            listaProductos.Add(new Producto("Hamburguesa",200,5,4,5555));
            listaProductos.Add(new Producto("Pizza",200,6,5,6666));
            listaProductos.Add(new Producto("Maruchan",220,7,6,12));
            listaProductos.Add(new Producto("Panchos",230,8,7,13));
            listaProductos.Add(new Producto("Mermelada",240,9,8,14));
            listaProductos.Add(new Producto("Levadura",250,10,9,15));
            listaProductos.Add(new Producto("Cereales",260,12,10,15));
            listaProductos.Add(new Producto("Te",3129,13,11,2));
            listaProductos.Add(new Producto("Dog chow",22330,14,12,111));
            listaProductos.Add(new Producto("Duraznos",23,15,13,16));
            listaProductos.Add(new Producto("Bife de chorizo",250,64,14,17));
            listaProductos.Add(new Producto("Asado",300,64,15,233));
            listaProductos.Add(new Producto("Pelota",400,64,16,88));
            listaProductos.Add(new Producto("Don satur",499,64,17,87));
            listaProductos.Add(new Producto("Don satur agri",2333,64,18,767));
            listaProductos.Add(new Producto("Fideos moño",2323,64,19,55));
            listaProductos.Add(new Producto("Fideos spaguetti",200,64,20,767));
            listaProductos.Add(new Producto("Sopa instantanea",200,64,21,44));
            listaProductos.Add(new Producto("Dulce de leche",200,64,22,99));
            listaProductos.Add(new Producto("Arroz",200,64,23,998));
            listaProductos.Add(new Producto("Papa",200,64,24,77));
            listaProductos.Add(new Producto("Vinagre",200,64,25,7));
            listaProductos.Add(new Producto("Aceite",200,64,26,88));
            listaProductos.Add(new Producto("Ravioles",23,5,27,88));
            listaProductos.Add(new Producto("Noquis",2222,64,28,88));
            listaProductos.Add(new Producto("Salsa Tomate",22300,64,29,88));
        }

        public static void HarcodeoClientes()
        {
            listaPersona.Add(new Cliente("Bart", "Simpson", 424173321));
            listaPersona.Add(new Cliente("Homero", "Simpson", 23232323));
            listaPersona.Add(new Cliente("Marge", "Simpson", 2323558788));
            listaPersona.Add(new Cliente("Ned", "Flanders", 9999999999));
            listaPersona.Add(new Cliente("Milhouse", "Van Houten", 40888222));
        }

        public static void HarcodeoEmpleados() 
        {
            listaPersona.Add(new Empleado(1,"Lucas123","Lucas","Rodriguez"));
            listaPersona.Add(new Empleado(2, "Eze321", "Ezequiel", "Oggioni"));
            listaPersona.Add(new Empleado(3, "Carlitos1", "Carlos", "Gutierrez"));
            listaPersona.Add(new Empleado(4, "Agusss", "Agustin", "Fernandez"));
        }

        public static List<Venta> VentasEmpleados(int idEmpleado) 
        {
            List<Venta> auxLista = new List<Venta>();

            foreach (Venta item in listaVentas)
            {
                if (item.VendedorId == idEmpleado)
                {
                    auxLista.Add(item);
                }
            }
            return auxLista;
        }

        public static List<Cliente> ObtenerClientes() 
        {
            List<Cliente> auxLista = new List<Cliente>();

            foreach (Persona item in listaPersona)
            {
                if (item is Cliente)
                {
                    auxLista.Add((Cliente)item);
                }
            }
            return auxLista;
        }

        public static List<Empleado> ObtenerEmpleados() 
        {
            List<Empleado> auxLista = new List<Empleado>();

            foreach (Persona item in listaPersona)
            {
                if (item is Empleado) 
                {
                    auxLista.Add((Empleado)item);
                }
            }
            return auxLista;
        }

        public static int StockTodo() 
        {
            int contador = 0;
            for (int i = 0; i < listaProductos.Count; i++)
            {
                contador += listaProductos[i].Stock;
            }
            return contador;
        }

        public static List<Producto> StockDiezUnidades()
        {
            List<Producto> listaAux = new List<Producto>();
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Stock < 10)
                {
                    listaAux.Add(listaProductos[i]);
                }
            }
            return listaAux;
        }

        public static bool ValidarStock(string nombre, int stock) 
        {
            bool retorno = false;
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Nombre == nombre && listaProductos[i].Stock >= stock)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool FamiliaSimpson(Cliente cliente) 
        {
            if (cliente.Apellido == "Simpson")
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
