using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
namespace Clases_Instanciables
{
    public class Jornada
    {
        #region Atributos
        List<Alumno> alumnos;
        Universidad.EClases clase;
        Profesor instructor;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set {alumnos = value; }
        }

        public Universidad.EClases Clase 
        {
            get { return clase; }
            set {clase = value; }
        }

        public Profesor Instructor 
        {
            get {return instructor; }
            set {instructor = value; }
        }
        #endregion

        #region Constructores
        public Jornada() 
        {
            alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor) :this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }
        #endregion
        #region Metodos
        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();
            bool sePudoGuardar = texto.Guardar("Jornada.txt", jornada.ToString());
            return sePudoGuardar;
        }

        public static string Leer()
        {
            string datosJornada = string.Empty;
            Texto texto = new Texto();
            texto.Leer("Jornada.txt", out datosJornada);
            return datosJornada;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Clase de: {0}\n", this.clase);
            sb.AppendFormat("Profesor: {0}\n", this.instructor);

            foreach (Alumno alumno in alumnos)
            {
                sb.AppendFormat("\n", alumno.ToString());
            }
            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            return j.alumnos.Contains(a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }
            return j;
        }
        #endregion
    }
}
