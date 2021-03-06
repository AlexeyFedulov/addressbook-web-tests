﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]

    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            //prepare-подготовка
            app.Auth.Logout();

            //action-действия
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);

            //verification-проверка
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            //prepare-подготовка
            app.Auth.Logout();

            //action-действия
            AccountData account = new AccountData("admin", "123456");
            app.Auth.Login(account);

            //verification-проверка
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }
    }
}
