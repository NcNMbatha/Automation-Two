using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace AutomationExerciseTwo.BasePage
{
    public class ValidationPage : BasePage
    {
       
        public ValidationPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement apparelAndAccessoriesLink => webDriver.FindElement(By.XPath("//*[@id=\"categorymenu\"]/nav/ul/li[2]/a"));
        public IWebElement apparelAndAccessoriesShoesLink => webDriver.FindElement(By.XPath("//*[@id=\"maincontainer\"]/div/div/div/div/ul/li[1]/a"));
        public IWebElement currencyDropDownMenu => webDriver.FindElement(By.XPath("/html/body/div/header/div[2]/div/div[2]/ul/li/a"));
        public IWebElement currencyDropDownEuroLink => webDriver.FindElement(By.XPath("/html/body/div/header/div[2]/div/div[2]/ul/li/ul/li[1]/a"));
        public IWebElement currencyDropDownDollarLink => webDriver.FindElement(By.XPath("/html/body/div/header/div[2]/div/div[2]/ul/li/ul/li[3]/a"));
        public IWebElement currencyDropDownPoundLink => webDriver.FindElement(By.XPath("/html/body/div/header/div[2]/div/div[2]/ul/li/ul/li[2]/a"));
        public IWebElement shoePriceLabel => webDriver.FindElement(By.ClassName("oneprice"));

    }
}