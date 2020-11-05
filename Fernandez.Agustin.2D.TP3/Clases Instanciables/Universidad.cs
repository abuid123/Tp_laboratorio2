using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Archivos;
using Excepciones;
namespace Clases_Instanciables
{
    
    public class Universidad
    {
        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }

        #region Atributos
        List<Alumno> alumnos;
        List<Jornada> jornada;
        List<Profesor> profesores;
        #endregion

        #region Constructores
        public Universidad() 
        {
            alumnos = new List<Alumno>();
            jornada = new List<Jornada>();
            profesores = new List<Profesor>();
            
        }
        #endregion

        #region Propiedades
        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this.jornada.Count)
                {
                    return this.jornada[i];
                }
                else
                {
                    throw new ArchivosException("Indice invalido");
                }

            }
            set
            {
                if (i >= 0 && i < this.jornada.Count)
                {
                    this.jornada[i] = value;
                }
                else
                {
                    throw new ArchivosException("Indice invalido");
                }
            }
        }

        public List<Alumno> Alumnos
        {
            get {return this.alumnos; }
            set {this.alumnos = value; }
        }

        public List<Jornada> Jornada
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }

        public List<Profesor> Instructores
        {
            get { return this.profesores; }

            set { this.profesores = value; }
        }

        #endregion

        #region Metodos
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> archivoXml = new Xml<Universidad>();

            return archivoXml.Guardar("Universidad.xml",uni);
        }

        public static Universidad Leer()
        {
            Xml<Universidad> archivoXml = new Xml<Universidad>();
            Universidad universidad;
            archivoXml.Leer("Universidad.xml", out universidad);
            return universidad;
        }

        static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA:");

            sb.Append("CLASE DE ");
            foreach (Jornada jornada in uni.Jornada)
            {
                sb.AppendFormat(jornada.ToString());
            }

            sb.AppendLine("Dictada por:  ");
            foreach (Profesor profesor in uni.Instructores)
            {
                sb.AppendFormat(profesor.ToString());
            }
            sb.AppendLine("ALUMNOS: ");
            foreach (Alumno alumno in uni.Alumnos)
            {
                sb.AppendFormat(alumno.ToString());
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }
        #endregion

        #region Operadores
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno item in g.alumnos)
            {
                if (item == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (var item in g.jornada)
            {
                if (item.Instructor == i)
                {
                    return true;
                }
            }

            return false;
        }

        public static Profesor operator !=(Universidad g, EClases clase)
        {
            foreach (Profesor profesor in g.profesores)
            {
                if (profesor != clase)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException();
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor == clase)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException("No hay profesor disponible para esta clase");
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profesor = g == clase;
            Jornada jornada = new Jornada(clase, profesor);
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == clase)
                {
                    jornada += alumno;
                }
            }
            g.Jornada.Add(jornada);
            return g;
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u == a)
            {
                
                throw new AlumnoRepetidoException("El alumno que intenta agregar ya fue cargado antes");
            }
            else
            {
                u.alumnos.Add(a);
            }

            return u;
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.profesores.Add(i);
            }

            return u;
        }
        #endregion
    }
}
