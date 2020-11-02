using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Abstractas;
using Clases_Instanciables;
namespace TestExcepcioness
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestAlumnoRepetidoException()
        {
            Universidad u = new Universidad();
            Alumno a = new Alumno(1203, "Agustin", "Fernandez", "42417332", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

            u += a;
            u += a;
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void Test_NacionalidadInvalidaException()
        {
            Alumno a = new Alumno(1203, "Agustin", "Fernandez", "90000000", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

        }
    }
}
