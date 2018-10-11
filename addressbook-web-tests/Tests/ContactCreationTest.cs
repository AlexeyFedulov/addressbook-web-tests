using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Groups.TimeoutSec50();
            app.Navigator.AddNew();
            ContactData group = new ContactData("ivanov");
            group.Middlename = "iv";
            group.Lastname = "ivanov123";
            group.Nickname = "1234";
            group.Title = "test";
            group.Company = "test1";
            group.Address = "varshavka";
            group.Home = "4996108980";
            group.Mobile = "9032687110";
            group.Email = "nouvaeux@mail.ru";
            group.Byear = "2000";
            group.Ayear = "2001";
            group.Address2 = "varsha";
            group.Phone2 = "sdgs";
            group.Notes = "sfg";
            app.Groups.FillGroupForm(group);
            // ERROR: Caught exception [Error: Dom locators are not implemented yet!]
            app.Groups.Logout();
        }
    }
}
