using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using August2022.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace August2022.utilities
{
    public class CommonDriver
    {
        public  IWebDriver driver;

        [SetUp]
        public void LoginActions()
        {
            //open chrome browser

            driver = new ChromeDriver();
            //loginpage Object Initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            
        }  
    }
}
