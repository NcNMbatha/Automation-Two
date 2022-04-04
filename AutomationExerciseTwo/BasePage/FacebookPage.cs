using OpenQA.Selenium;

namespace AutomationExerciseTwo.BasePage
{
    public class FacebookPage:BasePage
    {
        public IWebDriver webDriver;
        public FacebookPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement facebookIconLink => webDriver.FindElement(By.XPath("/html/body/div/header/div[2]/div/div[4]/div/div/a[1]"));

    }

    
}
