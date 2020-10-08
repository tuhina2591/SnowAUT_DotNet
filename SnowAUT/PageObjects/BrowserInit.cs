using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnowAUT.PageObjects
{
    public class BrowserInit
    {
        IWebDriver webDriver;
        public IWebDriver LaunchBrowser(String browser, String url)
        {
            if (browser.Equals("chrome", StringComparison.OrdinalIgnoreCase))
            {
                webDriver = new ChromeDriver();             
                webDriver.Navigate().GoToUrl(url);
                webDriver.Manage().Window.Maximize();

            }
            if (browser.Equals("firefox", StringComparison.OrdinalIgnoreCase))
            {
                webDriver = new FirefoxDriver();
                webDriver.Navigate().GoToUrl(url);
                webDriver.Manage().Window.Maximize();
            }

            if (browser.Equals("IE", StringComparison.OrdinalIgnoreCase))
            {
                webDriver = new InternetExplorerDriver();
                webDriver.Navigate().GoToUrl(url);
                webDriver.Manage().Window.Maximize();
            }

            return webDriver;
        }
        
         public void CloseBrowser()
        {
            webDriver.Quit();
        }
    
    
    }

    

}
