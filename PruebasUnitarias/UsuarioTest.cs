using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace PruebasUnitarias
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void ValidadTest()
        {
            Usuario user = new Usuario();
            user.passwd = "15827d1b83c6be8de449fa4535737d48";
            bool correct = user.validar("aaa111...");
            Assert.AreEqual(correct, true);
        }
    }
}
