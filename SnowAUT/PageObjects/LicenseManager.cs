using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnowAUT.PageObjects
{
    public class LicenseManager
    {
        IWebDriver driver;
        WebDriverWait wait;

        By articleBlock = By.XPath("//div[contains(@class,'slds-page-header')]//span[contains(text(),'Article Number')]");
        By articleNumber = By.XPath("//div[contains(@class,'slds-page-header')]//span[contains(text(),'Article Number')]/..//span[@class='uiOutputText']");
        public LicenseManager(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
    
        public String GetArticleNumber()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(articleBlock));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(articleNumber));
            String articleNum= driver.FindElement(articleNumber).Text;
            return articleNum;
        }
    
    
    
    }
}
