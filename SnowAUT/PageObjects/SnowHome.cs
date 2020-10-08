using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnowAUT.PageObjects
{
    public class SnowHome
    {
        IWebDriver driver;
        IWebElement succLink;
        WebDriverWait wait;
        Actions actions;
        By successLink = By.LinkText("Success");
        By snowGlobeLink = By.LinkText("Snow Globe Community");
        
        public SnowHome(IWebDriver driver)
        {
            this.driver = driver;
            actions = new Actions(driver);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        }
        
        public void MoveToSuccessLink()
        {
            succLink = driver.FindElement(successLink);
            actions.MoveToElement(succLink).Perform();
        }
    
        public void ClickSnowGlobeLink()
        {
            driver.FindElement(snowGlobeLink).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

    }
}
