using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excepciones;
namespace Clases_Abstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }
        #region Atributos
        string nombre;
        string apellido;
        int dni;
        ENacionalidad nacionalidad;
        #endregion

        #region Propiedades
        public string Nombre 
        {
            get{ return this.nombre; }
            set {this.nombre = ValidarNombreApellido(value);}
        }

        public string Apellido 
        {
            get {return this.apellido; }
            set {this.apellido = ValidarNombreApellido(value);}
        }

        public int Dni 
        {
            get { return this.dni; }
            set {this.dni = ValidarDni(this.nacionalidad, value); }
        }

        public ENacionalidad Nacionalidad
        {
            get {return this.nacionalidad; }
            set { this.nacionalidad = value; ; }
        }

        public string DniString 
        {
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }
        #endregion

        #region Metodos

        public Persona() 
        {
            this.nombre = "";
            this.apellido = "";
            this.dni = -1;
        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) :this(nombre,apellido,nacionalidad)
        {
            this.Dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        {
            this.DniString = dni;
        }
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato >= 1 && dato <= 89999999)
                    {
                        return dato;
                    }
                    break;
                case ENacionalidad.Extranjero:
                    if (dato >= 90000000 && dato <= 99999999)
                    {
                        return dato;
                    }
                    break;
            }

            throw new NacionalidadInvalidaException();
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            if (!int.TryParse(dato, out dni))
            {
                throw new DniInvalidoException();
            }

            return ValidarDni(nacionalidad, dni);
        }


        private string ValidarNombreApellido(string dato) 
        {
            if (!String.IsNullOrEmpty(dato) && dato.Length > 3)
            {
                return dato;
            }
            return "Nombre Invalido";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre y apellido: {this.Nombre} {this.Apellido}");
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Nacionalidad: {this.Nacionalidad}");

            return sb.ToString();
        }
        #endregion
    }
}
