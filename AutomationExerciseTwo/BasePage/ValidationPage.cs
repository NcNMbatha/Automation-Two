using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AutomationExerciseTwo.BasePage
{
    public class ValidationPage : BasePage
    {
       
        public ValidationPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement apparelAndAccessoriesLink => webDriver.FindElement(By.XPath("//*[@id='categorymenu']//a[contains(.,'Apparel')]"));
        public IWebElement apparelAndAccessoriesShoesLink => webDriver.FindElement(By.XPath("//*[@id='maincontainer']//a[contains(.,'Shoes')]"));
        public IWebElement currencyDropDownMenu => webDriver.FindElement(By.XPath("//a[@class='dropdown-toggle']"));
        public IWebElement currencyDropDownEuroLink => webDriver.FindElement(By.XPath("//a[contains(.,'€ Euro')]"));
        public IWebElement currencyDropDownDollarLink => webDriver.FindElement(By.XPath("//a[contains(.,'$ US Dollar')]"));
        public IWebElement currencyDropDownPoundLink => webDriver.FindElement(By.XPath("//a[contains(.,'£ Pound')]"));
        public IWebElement shoePriceLabel => webDriver.FindElement(By.ClassName("oneprice"));
    }
}