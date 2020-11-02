using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
namespace Clases_Instanciables
{
    
    public class Alumno : Universitario
    {

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado,
        }
        #region Atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region Constructores
        public Alumno()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion
        #region Metodos
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            string estado = null;

            sb.AppendFormat("{0}\n", base.MostrarDatos());

            switch (this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    estado = "Cuota al día";
                    break;
                case EEstadoCuenta.Becado:
                    estado = "Becado";
                    break;
                case EEstadoCuenta.Deudor:
                    estado = "Debe cuotas";
                    break;
            }
            sb.AppendFormat("ESTADO DE CUENTA: {0}\n", estado);
            sb.AppendFormat("{0}", this.ParticiparEnClase());

            return sb.ToString();
        }
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("TOMA CLASES DE: {0}\n", this.claseQueToma.ToString());

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operadores

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a.claseQueToma == clase);
        }

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor;
        }
        #endregion
    }
}
