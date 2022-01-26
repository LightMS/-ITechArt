using System.Threading;
using OpenQA.Selenium;

namespace ConsoleApp2
{
    class Program
    {
        private IWebDriver driver;


        static void Main()
        {
            var driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calc.ru/kalkulyator-kalorii.html");
            Thread.Sleep(7500);
            IWebElement first = driver.FindElement(By.Id("age"));
            first.SendKeys("35");
            first = driver.FindElement(By.Id("weight"));
            first.SendKeys("85");
            first = driver.FindElement(By.Id("cm"));
            first.SendKeys("135");
            IWebElement second = driver.FindElement(By.Id("activity"));
            OpenQA.Selenium.Support.UI.SelectElement select = new OpenQA.Selenium.Support.UI.SelectElement(second);
            select.SelectByValue("1.4625");
            first = driver.FindElement(By.Id("submit"));
            first.Click();
        }
    }
}
