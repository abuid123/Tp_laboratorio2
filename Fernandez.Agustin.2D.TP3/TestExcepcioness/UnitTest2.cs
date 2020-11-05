using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;
namespace TestExcepcioness
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestListaAlumnos()
        {
            Universidad univ = new Universidad();

            Assert.IsNotNull(univ.Alumnos);
        }
    }
}
