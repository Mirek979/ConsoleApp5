// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var driver = new ChromeDriver();

driver.Navigate().GoToUrl("https://wikipedia.org");
Thread.Sleep(1000);

var element = driver.FindElement(By.Id("searchInput"));
Thread.Sleep(1000);
element.SendKeys("java");
element.SendKeys(Keys.Enter);


///

double Secti(double a, double b)
{
    return a + b;
}

