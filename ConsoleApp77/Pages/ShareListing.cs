using ConsoleApp77.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Controls;
using NUnit.Framework;

namespace ConsoleApp77.Pages
{
    class ShareListing

    {
        //function for adding language

        public ShareListing()
        {
            PageFactory.InitElements(Common.Driver, this);
        }

        //Define iwebelements
        //signin

        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkills { get; set; }



        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Write a title to describe the service you provide.']")]
        private IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")]
        private IWebElement Description { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement Category1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement Category2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement ServiceType { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement LocationType { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Start date')]")]
        private IWebElement StartDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'End date')]")]
        private IWebElement EndDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[3]//div[1]//div[1]//input[1]")]
        private IWebElement ChooseMon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[3]//div[2]//input[1]")]
        private IWebElement StartTimeMon { get; set; }

        [FindsBy(How = How.XPath, Using = "//body//div[3]//div[3]//input[1]")]
        private IWebElement EndTimeMon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[8]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement SkillTrade { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Amount')]")]
        private IWebElement Credit { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[10]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement Active { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@class,'ui teal button')]")]
        private IWebElement Save { get; set; }


        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'Automation Testing')]")]
        private IWebElement ActualResult1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement ManagelistingsMenu { get; set; }

        public void ListingSteps()
        {
            //click add new 
            // IWebElement ShareSkills = Common.Driver.FindElement(By.CssSelector("div.ui:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu div.right.item:nth-child(5) > a.ui.basic.green.button"));
            Thread.Sleep(7000);
            ShareSkills.Click();
            
            Thread.Sleep(8000);
            Title.SendKeys("Automation Testing");
            
            Description.SendKeys("Tools used in testing and methods followed in handling tools");
            
            Category1.SendKeys("Programming & Tech");
            
            Category2.SendKeys("QA");
            
            Tags1.SendKeys("Selenium");
            Tags1.SendKeys(Keys.Enter);
            Console.WriteLine("Enter pressed for tag1");

            
            ServiceType.Click();

            
            LocationType.Click();

            
            StartDate.SendKeys("17/10/2019");

            
            EndDate.SendKeys("17/4/2020");

            
            ChooseMon.Click();
            StartTimeMon.SendKeys("8.30AM");

            
            EndTimeMon.SendKeys("4.30PM");

            
            SkillTrade.Click();

            
            Credit.SendKeys("5");

            
            Active.Click();

            
            Save.Click();
            Thread.Sleep(6000);


            //verification


            ManagelistingsMenu.Click();
            Thread.Sleep(8000);
            try
            {
                Assert.AreEqual("Automation Testing",ActualResult1.Text);
                Console.WriteLine("Test case 1 PASS: record added succesfully");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            } 

        }
    }
}
    
