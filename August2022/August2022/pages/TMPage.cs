
using NUnit.Framework;
using OpenQA.Selenium;

namespace August2022.pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {

            //click on create new button
            IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnewButton.Click();

            //select time option from Typecode dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDropdown.Click();
            Thread.Sleep(1000);
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
            timeOption.Click();

            //input code 
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("August2022");

            //Input Description 
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("August2022");

            //Input Priceper unit
            IWebElement overLappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            overLappingTag.Click();
            IWebElement ppunitTextbox = driver.FindElement(By.Id("Price"));
            ppunitTextbox.SendKeys("123");

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //chcek if the record created is present in the table
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();
            Thread.Sleep(2000);

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(newCode.Text == "August2022", "actual code and expeced code do Not match");
            Assert.That(newDescription.Text == "August2022", "Actual Description and Expected Description do not match");
            Assert.That(newPrice.Text == "$123.00", "Actual price and Expected privce do not match");
            
        }
        public void EditTM(IWebDriver driver)

        {
            Thread.Sleep(2000);
            IWebElement goToLastPageButtonAgain = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonAgain.Click();
            Thread.Sleep(2000);


            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last]/td[1]"));
            
            if (findRecordCreated.Text == "August2022")
            {
                //click on Edit Button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last]/td[5]/a[1]"));
                editButton.Click();
                Thread.Sleep(2000);
            }

            else
            {
                Assert.Fail("Record to be Edited hasnt been found");
            }


            IWebElement editTypeCodeDropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/label"));
            editTypeCodeDropDown.Click();
            Thread.Sleep(2000);

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            materialOption.Click();

            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("New");

            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("New");

            IWebElement newOverLappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            newOverLappingTag.Click();
            Thread.Sleep(2000);

            IWebElement editPricePerUnitTextbox = driver.FindElement(By.Id("Price"));
            editPricePerUnitTextbox.Clear();
            IWebElement newOverLappingTag1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            newOverLappingTag1.Click();
            Thread.Sleep(1000);
            editPricePerUnitTextbox.SendKeys("789");

            IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();
            Thread.Sleep(3000);

            //check if the edited detailes saved dor not

            IWebElement goToLastPageButtonAgain1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonAgain1.Click();

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last]/td[1]"));
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last]/td[4]"));

            Assert.That(editedCode.Text == "New", "Record Hasn't been edited");
            Assert.That(editedDescription.Text == "New", " Record Hasn't been Edited");
            Assert.That(editedPrice.Text == "$789.00", "Record hasn't been Edited");

            

        }
        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(1000);

            //click on Delete Button
            IWebElement goToLastPageButtonAgain = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonAgain.Click();
            Thread.Sleep(2000);

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last]/td[1]"));
            
            if(findEditedRecord.Text == "New")
            
            {

                IWebElement goToDeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                goToDeleteButton.Click();
                Thread.Sleep(2000);

                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to be Deleted hasnt been Found,Record not Deleted");
            }
            

            //Assertion

            IWebElement goToLastPageButtonAgain1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonAgain1.Click();

            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last]/td[1]"));
            IWebElement deletedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last]/td[3]"));
            IWebElement deletedPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last]/td[4]"));

            Assert.That(deletedCode.Text != "New", "Record Hasnt been deleted");
            Assert.That(deletedDescription.Text != "New", "Record Hasnt been Deleted");
            Assert.That(deletedPrice.Text != "$789.00", "Record Hasnt been Deleted");



            

        }

    }
}
