using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;

namespace Commons_Automation
{
    public  class BrowserType
    {
        public static IWebDriver SelectBrowser(string browser)
        {
            IWebDriver driver;
            switch (browser)
            {
                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("no-sandbox");
                    driver = new ChromeDriver(options);
                    driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(90));
                    break;

                case "edge":
                    EdgeOptions edgeOptions = new EdgeOptions();
                    driver = new EdgeDriver(edgeOptions);
                    driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(90));
                    break;
                default:
                    driver = new ChromeDriver(new ChromeOptions());
                    driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(90));
                    break;
            }
            return driver;
        }
    }
}
