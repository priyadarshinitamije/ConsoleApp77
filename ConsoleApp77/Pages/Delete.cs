using ConsoleApp77.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp77.Pages
{
    class Delete
    {

        //function for edit language

        public Delete()
        {
            PageFactory.InitElements(Common.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement ManageListing { get; set; }


        [FindsBy(How = How.XPath, Using = "//tr[1]//td[8]//i[3]")]
        private IWebElement DeleteIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='ui icon positive right labeled button']")]
        private IWebElement ConfirmYes { get; set; }


        public void DeleteData()
        {
            Thread.Sleep(7000);
            ManageListing.Click();

            Thread.Sleep(7000);
            DeleteIcon.Click();

            ConfirmYes.Click();

        }
    }
}
