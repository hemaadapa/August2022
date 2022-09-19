using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using August2022.pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.ComponentModel;
using NUnit.Framework;
using August2022.utilities;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace August2022.tests
{
    [TestFixture]

    [Parallelizable]

    public class TM_tests :CommonDriver
    {

        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Test ,Order(1), Description("Check if user is able to Creatr TMtest")]
        public void CreateTMtest(IWebDriver driver)
        {


            //homepage object initialization
           
            homePageObj.GoToTMPage(driver);

            //TMPage object initialization
           
            tmPageObj.CreateTM(driver);

        }
        [Test , Order(2), Description("Check if user is able to Edit Existing Record")]
        public void EditTMtest()
        {
            //edit tm definition
            
            tmPageObj.EditTM(driver);
        }
        [Test, Order(3), Description("check if user is able to Delete existing record")]

        public void DeleteTMtest()
        {
            //Delete TMdefinition
           
            tmPageObj.DeleteTM(driver);

        }
        [TearDown]
        public void CloseRuntest()
        {
            driver.Quit();
        }
        
        


      

    }
}
