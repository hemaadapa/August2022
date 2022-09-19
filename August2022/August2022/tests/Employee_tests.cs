using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using August2022.pages;
using August2022.utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace August2022.tests
{
    [TestFixture]

    [Parallelizable]

    public class Employee_tests : CommonDriver
    {
        [SetUp]
        public void LoginActions()
        {
            //open chrome browser

            driver = new ChromeDriver();
            //loginpage Object Initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //homepage object initialization
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

        }

        [Test]

        public void CreateEmployee()
        {
            EmployeesPage employeePageObj = new EmployeesPage();
            employeePageObj.CreateEmployee(driver);
            //code
        }


        [Test]
        public void EditEmployee()
        {
            //code

            EmployeesPage employeePageObj = new EmployeesPage();
            employeePageObj.EditEmployee(driver);
        }

        [Test]
        public void DeleteEmployee()
        {
            //code
            EmployeesPage employeePageObj = new EmployeesPage();
            employeePageObj.DeleteEmployee(driver);
        }


        [TearDown]
        public void closeSteps()
        {
            driver.Quit();
            //code
        }
    }
}
