using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace Pruebas
{
    [TestClass]
    public class UserManagerTest
    {
        [TestMethod]
        public void CrearAdminTest()
        {
            UserManager.CrearAdmin();
            Usuario user = new Usuario();
            user = UserManager.get("admin");
            Assert.IsNotNull(user);
            Assert.Equals(user.email, "jucles@a2000.es");
        }
    }
}
