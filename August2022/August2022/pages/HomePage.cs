
using August2022.utilities;
using OpenQA.Selenium;

namespace August2022.pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {

            //navigate to time & material page
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/a"));
            administrationTab.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a", 5);
            IWebElement timematOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a"));
            timematOption.Click();
        }

        public void GoToEmployeesPage(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }

        public void GoToEmployeesPage(IWebDriver driver)
        {
        //navigate to Employee page
        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/a"));
        administrationTab.Click();
        WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a", 5);

        IWebElement employeesOPtion = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
        employeesOPtion.Click();
        }

    
}

