using Clases_Abstractas;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        Queue<Universidad.EClases> claseDelDia;
        static Random random;
        #endregion

        #region Constructores
        static Profesor() 
        {
            random = new Random();
        }

        public Profesor() : base()
        {

        }

        public Profesor(int id, string nombre, string apellido, string dni, Persona.ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion

        #region Metodos

        private void _randomClases() 
        {
            for (int i = 0; i < 2; i++)
            {
                int opcion = random.Next(0,3);
                switch (opcion)
                {
                    case 0:
                        this.claseDelDia.Enqueue(Universidad.EClases.Legislacion);
                        break;
                    case 1:
                        this.claseDelDia.Enqueue(Universidad.EClases.Programacion);
                        break;
                    case 2:
                        this.claseDelDia.Enqueue(Universidad.EClases.SPD);
                        break;
                    case 3:
                        this.claseDelDia.Enqueue(Universidad.EClases.Laboratorio);
                        break;
                }
            }
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASES DEL DIA");
            foreach (Universidad.EClases item in this.claseDelDia)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operador
        public static bool operator ==(Profesor i, Universidad.EClases clase) 
        {
            foreach (Universidad.EClases item in i.claseDelDia)
            {
                if (item == clase)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase) 
        {
            return !(i == clase);
        }
        #endregion
    }
}
