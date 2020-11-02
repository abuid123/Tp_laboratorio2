using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos
        int legajo;
        #endregion

        #region Constructores
        public Universitario() : base()
        {

        }
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this.GetType(), obj.GetType()))
            {
                return true;
            }
            return false;
        }

        protected abstract string ParticiparEnClase();

        protected virtual string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Legajo numero: {this.legajo}");

            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.Equals(pg2) && (pg1.Dni == pg2.Dni || pg1.legajo == pg2.legajo))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2) 
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
