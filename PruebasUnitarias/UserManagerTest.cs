using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;
using System.Collections.Generic;

namespace PruebasUnitarias
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
            Assert.AreEqual(user.email, "jucles@a2000.es");
        }

        [TestMethod]
        public void getAllTest()
        {
            List<Usuario> users = new List<Usuario>();
            users = UserManager.getAll();
            Assert.AreEqual(users.Count, 1);

        }
    }
}
