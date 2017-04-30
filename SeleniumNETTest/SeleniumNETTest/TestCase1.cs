using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace SeleniumNETTest
{
	public class TestCase1
	{
		static void Main(string[] args)
		{
            // Chrome Tests
            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Url = "https://google.com/";
                IWebElement query = driver.FindElement(By.Id("lst-ib"));
                query.SendKeys("Dank memes");
                query.Submit();
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
				wait.Until(d => d.Title.StartsWith("dank memes", StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("Page title is: " + driver.Title);
			}
			
           
		}
	}
}
