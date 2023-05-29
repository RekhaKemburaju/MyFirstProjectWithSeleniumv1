using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MyFirstProjectWithSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com/");
            driver.FindElement(By.Name("q")).SendKeys("Automation Traning");
           // driver.Quit();
        }
    }
}
