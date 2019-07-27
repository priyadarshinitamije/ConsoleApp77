using ConsoleApp77.Helpers;
using ConsoleApp77.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    [TestFixture]
    class Program
    {

        [SetUp]
        public void Login()
        {
            Common.Driver = new ChromeDriver();

            LoginPage obj1 = new LoginPage();
            obj1.LoginSteps();

        }

        [Test]
        public void AddShareSkill()
        {

            ShareListing obj2 = new ShareListing();
            obj2.ListingSteps();

        }
        [Test]
        public void EditSkill()
        {
            Edit obj3 = new Edit();
            obj3.EditData();
        }


        [Test]
        public void DelSkill()
        {
            Delete obj4 = new Delete();
            obj4.DeleteData();
        }

        [TearDown]
        public void Close()
        {
            Common.Driver.Close();
        }
        static void Main(string[] args)
        {


        }
    }
}
