using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Globalization;
using WebDriverManager.DriverConfigs.Impl;

namespace ScreenplayTestFramework.Factories
{
    internal class DriverFactory
    {
        public static IWebDriver GetDriver(string type = "")
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }
    }
}
