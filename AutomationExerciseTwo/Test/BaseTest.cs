using AutomationExerciseTwo.BasePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationExerciseTwo.Test
{
    public class BaseTest
    {
        private IWebDriver webDriver;

        [SetUp]
        public void Setup()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            AppPages.Init(webDriver);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Login();
        }

        public void Login()
        {
            AppPages.BasePage.loginRegisterLink.Click();
            AppPages.BasePage.loginNameTextBox.SendKeys("Test000");
            AppPages.BasePage.loginPasswordTextBox.SendKeys("Test000");
            AppPages.BasePage.loginButton.Click();
            AppPages.BasePage.homePageLink.Click();
        }

        [TearDown]
        public void CleanUp()
        {
            AppPages.BasePage.logoutTopNavLink.Click();
            AppPages.BasePage.logOutLink.Click();
            webDriver.Dispose();
        }
    }
}
