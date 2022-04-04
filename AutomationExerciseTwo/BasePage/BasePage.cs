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
        public IWebElement loginButton => webDriver.FindElement(By.XPath("//*[@id=\"loginFrm\"]/fieldset/button/i"));
        public IWebElement logoutTopNavLink => webDriver.FindElement(By.XPath("//*[@id=\"main_menu_top\"]/li[2]/a/span"));
        public IWebElement logOutLink => webDriver.FindElement(By.XPath("//*[@id=\"maincontainer\"]/div/div[2]/div[1]/div/ul/li[10]/a"));
        public IWebElement homePageLink => webDriver.FindElement(By.XPath("/html/body/div/header/div[1]/div/div[1]/a/img"));

        public BasePage(IWebDriver webDriver)
        {
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            this.webDriver = webDriver;
        }

    }
}
