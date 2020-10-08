using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using SnowAUT.PageObjects;
using NUnit.Framework.Internal;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SnowAUT.Tests
{
    [TestFixture]
    class ArticleNumberTest
    {

        BrowserInit bi = new BrowserInit();
        IWebDriver driver;
        SnowHome sh;
        GlobeCommunity gc;
        LicenseManager lm;

        [Test, Order(0)]
        public void Init()
        {
           
            driver = bi.LaunchBrowser("chrome", "http://www.snowsoftware.com");

        }

         [Test, Order(1)]public void CheckBrowserTitle()
        {
            String actualTitle = driver.Title;
            Assert.AreEqual("Snow Software – The Technology Intelligence Platform", actualTitle);
        }
       
        [Test, Order(2)] public void VerifySnowGlobeRedirection()
        {
            sh = new SnowHome(driver);
            gc = new GlobeCommunity(driver);
            sh.MoveToSuccessLink();
            sh.ClickSnowGlobeLink();
            Thread.Sleep(10000);
            String pageLabel = gc.GetLabelText();
            Assert.AreEqual("Welcome to Snow Globe", pageLabel);
           
        }
        
        [Test, Order(3)] public void CheckReleasePage()
        {
            gc = new GlobeCommunity(driver);
            gc.SetSearchString();
            Thread.Sleep(10000);
            gc.ClickReleaseLink();
            Thread.Sleep(30000);
            Assert.AreEqual("Release Notes: Snow License Manager 9.7.1", driver.Title);
        }

        [Test, Order(4)] public void CheckLicenseManagerPage()
        {
            Thread.Sleep(10000);
            lm = new LicenseManager(driver);
            lm.GetArticleNumber();

        }

        [Test, Order(4)]
        public void CheckBrowserClose()
        {
            Boolean flag;
            bi.CloseBrowser();

            if (driver is null)
            {
                flag = false;
                
            }
            else {
                flag = true;
                
            }
            Assert.IsTrue(flag);   
        
        }


    }
}
