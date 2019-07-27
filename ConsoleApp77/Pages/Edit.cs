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
    class Edit
    {

        //function for edit language

        public Edit()
        {
            PageFactory.InitElements(Common.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement ManageListing { get; set; }


        [FindsBy(How = How.XPath, Using = "//tr[1]//td[8]//i[2]")]
        private IWebElement EditIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement Service { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
        private IWebElement Save { get; set; }

        public void EditData()
        {
            Thread.Sleep(7000);
            ManageListing.Click();

            Thread.Sleep(7000);
            EditIcon.Click();

            Thread.Sleep(7000);
            Service.Click();

            Thread.Sleep(6000);
            Save.Click();
        }


    }
}
