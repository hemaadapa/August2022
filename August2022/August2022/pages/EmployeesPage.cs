using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace August2022.pages
{
    public class EmployeesPage

    {


        public void CreateEmployees(IWebDriver driver)
        {
            //code
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();
            Thread.Sleep(1000);

            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("Eglah");

            IWebElement usernameTextBox = driver.FindElement(By.Id("Username"));
            usernameTextBox.SendKeys("August2022");

            IWebElement contactTextBox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextBox.SendKeys("12345");

            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("Emp@2022");

            IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextBox.SendKeys("Emp@2022");

            IWebElement adminTextBox = driver.FindElement(By.Id("IsAdmin"));
            adminTextBox.Click();

            IWebElement vehicleTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleTextBox.SendKeys("Car");

            IWebElement groupsDropDown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/label"));
            groupsDropdown.Click();
            Thread.Sleep(1000);
            IWebElement nzTestOption = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[13]"));
            nzTestOption.Click();


            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();






        }

        public void EditEmployees(IWebDriver driver)
        {
            //code

            Thread.Sleep(2000);
            IWebElement goToLastPageButtonAgain = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonAgain.Click();
            Thread.Sleep(2000);


            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[4]/td[1]"));

            if (findRecordCreated.Text == "Eglah")
            {
                //click on Edit Button
                IWebElement editButton = driver.FindElement(By.XPath("///*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[4]/td[3]/a[1]"));
                editButton.Click();
                Thread.Sleep(2000);
            }

            else
            {
                Assert.Fail("Record to be Edited hasnt been found");
            }


            IWebElement editNameTextBox = driver.FindElement(By.Id("Name"));
            editNameTextbox.Clear();
            editNameTextBox.SendKeys("Adapa");

            IWebElement editUsernameTextBox = driver.FindElement(By.Id("Username"));
            editUsernameTextBox.Clear();
            editUsernameTextBox.SendKeys("Aug2022");

            IWebElement editContactTextBox = driver.FindElement(By.Id("ContactDisplay"));
            editContactTextBox.Clear();
            editContactTextBox.SendKeys("12345");

            IWebElement editPasswordTextBox = driver.FindElement(By.Id("Password"));
            editPasswordTextBox.Clear();
            editPasswordTextBox.SendKeys("Emp@2022");

            IWebElement editRetypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            editRetypePasswordTextbox.Clear();
            editRetypePasswordTextBox.SendKeys("Emp@2022");

            IWebElement editAdminTextBox = driver.FindElement(By.Id("IsAdmin"));
            editAdminTextBox.Clear();

            IWebElement editVehicleTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            editVehicleTextBox.Clear();
            editVehicleTextBox.SendKeys("Bike");


            IWebElement editGroupsDropDown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/label"));
            editGroupsDropdown.Click();

            Thread.Sleep(1000);
            editGroupsDropDown.Clear();

            IWebElement aussieGroupOption = driver.FindElement(By.XPath("//*[@id=\"groupList_taglist\"]/li/span[1]"));
            aussieGroupOption.Click();

            IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();
            Thread.Sleep(2000);


            IWebElement goToLastPageButtonAgain1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonAgain1.Click();

            IWebElement editedName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[4]/td[1]"));
            IWebElement editedUserName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[4]/td[2]"));


            Assert.That(editedName.Text == "Adapa", "Record Hasn't been edited");
            Assert.That(editedUserName.Text == "Aug2022", " Record Hasn't been Edited");



        }


        public void DeleteEmployees(IWebDriver driver)
        {
            //code
            Thread.Sleep(1000);

            //click on Delete Button

            IWebElement goToLastPageButtonAgain = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonAgain.Click();
            Thread.Sleep(2000);


            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[4]/td[1]"));

            if (findEditedRecord.Text == "Adapa")

            {

                IWebElement goToDeleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[4]/td[3]/a[2]"));
                goToDeleteButton.Click();
                Thread.Sleep(2000);

                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to be Deleted hasnt been Found,Record not Deleted");
            }


            IWebElement goToLastPageButtonAgain1 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonAgain1.Click();

            IWebElement deletedName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[3]/td[1]"));
            IWebElement deletedUserName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[3]/td[2]"));

            Assert.That(deletedName.Text != "Adapa", "Record hasnt been Deleted");
            Assert.That(deletedUserName.Text != "Aug2022", "Record Hasn't been deleted");
        }
    }

    


}
