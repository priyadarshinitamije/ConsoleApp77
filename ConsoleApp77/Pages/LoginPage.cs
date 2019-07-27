using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp77.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ConsoleApp77.Pages
{
    class LoginPage
    {
        public LoginPage()
            {
            PageFactory.InitElements(Common.Driver, this);
            }

        //Define iwebelements
        //signin
        [FindsBy(How = How.XPath,Using = "//A[@class='item'][text()='Sign In']")]
        private IWebElement SignIn { get; set; }

        //email addr
        [FindsBy(How = How.XPath, Using = "(//INPUT[@type='text'])[2]")]
        private IWebElement EmailAddress { get; set; }

        //passwd
        [FindsBy(How = How.XPath, Using = "//INPUT[@type='password']")]
        private IWebElement Password { get; set; }

        //login
        [FindsBy(How = How.XPath, Using = "//button[@class='fluid ui teal button']")]
        private IWebElement LoginButton { get; set; }

        public void LoginSteps()
        { 
        ////launch chrome web browser
        //IWebDriver driver = new ChromeDriver();

        //enter the URL
        Common.Driver.Navigate().GoToUrl("http://www.skillswap.pro/");

        //maximise the window
        Common.Driver.Manage().Window.Maximize();

            Thread.Sleep(1000);

            //click the sign in button
            //IWebElement SigninButton = Common.Driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
         SignIn.Click();

            //enter email address
          //  IWebElement EmailAddress = Common.Driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        EmailAddress.SendKeys("priyamishti290@gmail.com");

            //enter password
            //IWebElement Password = Common.Driver.FindElement(By.XPath("//INPUT[@type='password']"));
        Password.SendKeys("123456");
            Thread.Sleep(1000);

            //click login 
          //  IWebElement LoginButton = Common.Driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
            LoginButton.Click();

            Console.WriteLine("Login Button clicked");

            
        }
    }
}
