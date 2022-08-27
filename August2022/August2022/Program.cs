using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open chrome browser

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//enter url launch turn up portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1000);

//identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
     
//identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();
//check if user has logged in successfully
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\'logoutForm\']/ul/li/a"));
if (hellohari.Text == "HelloHari")
{ Console.WriteLine("loggedin Successfully");
}
else
{ Console.WriteLine("login failed,test failed");
}


//create new material record

//navigate to time & material page
IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/a"));
administrationTab.Click();
IWebElement timematOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a"));
timematOption.Click();


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

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (newCode.Text == "August2022")
{
    Console.WriteLine("Time Record created Successfully.");
}
else
{
    Console.WriteLine("Time Recrd Hasnt been Created.");
}




