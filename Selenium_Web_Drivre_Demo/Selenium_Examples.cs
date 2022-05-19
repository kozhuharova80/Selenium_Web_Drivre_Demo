
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var driver = new ChromeDriver();

driver.Url = "https://wikipedia.org";

Console.WriteLine("Current title:" + driver.Title);
var searchField = driver.FindElement(By.Id("searchInput"));
searchField.Click();
searchField.SendKeys("QA");
searchField.SendKeys(Keys.Enter);
Console.WriteLine("New title:" + driver.Title);

driver.Quit();