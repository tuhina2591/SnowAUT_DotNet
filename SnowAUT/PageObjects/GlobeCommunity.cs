using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SnowAUT.PageObjects
{
    public class GlobeCommunity
    {
        IWebDriver driver;
        WebDriverWait wait;
        By labelText = By.XPath("//h2[contains(text(),'Welcome to Snow Globe')]");
        By searchTextBox = By.XPath("//input[@placeholder='How can we help?']");
        By dropDown = By.CssSelector("[class='result-container']");
        By releaseLink = By.XPath("//div[contains(@class, 'result-container')]//span[contains(text(), 'Release Notes')]");

        public GlobeCommunity(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        }
        public String GetLabelText()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(searchTextBox));
            String label = driver.FindElement(labelText).Text;
            return label;


        }
        public void SetSearchString()
        {
            driver.FindElement(searchTextBox).SendKeys("Snow License Manager");
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(dropDown));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(releaseLink));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeSelected(releaseLink));
                       

        }
    
        public void ClickReleaseLink()
        {
            driver.FindElement(releaseLink).Click();
            //Thread.Sleep(40000);
        }
    }
}
