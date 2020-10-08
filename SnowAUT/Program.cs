/*using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace SnowAUT
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            By successLink = By.LinkText("Success");
            By snowGlobeLink = By.LinkText("Snow Globe Community");
            By welcomeText = By.XPath("//h2[contains(text(),'Welcome to Snow Globe')]");
            By searchTextBox = By.XPath("//input[@placeholder='How can we help?']");
            By dropDown = By.CssSelector("[class='result-container']");
            By releaseLink = By.XPath("//div[contains(@class, 'result-container')]//span[contains(text(), 'Release Notes')]");


            driver.Navigate().GoToUrl("http://www.snowsoftware.com");
           
            driver.Manage().Window.Maximize();
            var succLink= driver.FindElement(successLink);
            Actions actions = new Actions(driver);
            actions.MoveToElement(succLink).Perform();
            driver.FindElement(snowGlobeLink).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(searchTextBox));
            driver.FindElement(searchTextBox).SendKeys("Snow License Manager");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(dropDown));
            driver.FindElement(releaseLink).Click();

            








        }
    }
}

*/