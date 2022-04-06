using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationExerciseTwo.BasePage
{
    public class BasePage
    {
        protected IWebDriver webDriver;
        protected WebDriverWait webDriverWait;

        public IWebElement loginRegisterLink => webDriver.FindElement(By.Id("customer_menu_top"));
        public IWebElement loginNameTextBox => webDriver.FindElement(By.Id("loginFrm_loginname"));
        public IWebElement loginPasswordTextBox => webDriver.FindElement(By.Id("loginFrm_password"));
        public IWebElement loginButton => webDriver.FindElement(By.XPath("//*[@title='Login']"));
        public IWebElement logoutTopNavLink => webDriver.FindElement(By.ClassName("menu_text"));
        public IWebElement logOutLink => webDriver.FindElement(By.XPath("//*[@id='customer_menu_top']//li[contains(.,'Logoff')]"));
        public IWebElement homePageLink => webDriver.FindElement(By.ClassName("logo"));

        public BasePage(IWebDriver webDriver)
        {
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            this.webDriver = webDriver;
        }

    }
}
