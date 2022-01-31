using System;
using OpenQA.Selenium;

namespace ConsoleApp2
{
    class Program
    {
        private IWebDriver driver;


        static void Main()
        {
            
            var driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/Username/Desktop/file.html");
            //1
            IWebElement taskac = driver.FindElement(By.CssSelector("#123"));
            IWebElement taskb = driver.FindElement(By.CssSelector(".arrow"));
            IWebElement taskd = driver.FindElement(By.CssSelector("h1 span"));
            IWebElement taske = driver.FindElement(By.CssSelector("span[value^='12']"));
            //2
            IWebElement taska1 = driver.FindElement(By.XPath("/html/body/div[2]/h1/div/span[text() = 'Test']"));
            IWebElement taskb2 = driver.FindElement(By.CssSelector("//span[@ids=1]"));
            IWebElement taskc3 = driver.FindElement(By.CssSelector("//span[contains(text(), 'Title 2')]"));
            IWebElement taskd4 = driver.FindElement(By.CssSelector("//h1/span[contains(text(),'Title 3')]"));
            IWebElement taske5 = driver.FindElement(By.CssSelector("//div[@class = 'arrow']//span[contains(text(), 'Title 2')]"));
        }
    }
}
