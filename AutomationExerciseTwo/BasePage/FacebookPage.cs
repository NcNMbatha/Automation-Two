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

        public IWebElement facebookIconLink => webDriver.FindElement(By.ClassName("facebook"));
        public IWebElement facebookH2Label => webDriver.FindElement(By.ClassName("_8eso"));

    }

    
}
