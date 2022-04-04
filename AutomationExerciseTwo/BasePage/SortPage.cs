using OpenQA.Selenium;

namespace AutomationExerciseTwo.BasePage
{
    public class SortPage:BasePage
    {
        public SortPage(IWebDriver webDriver):base(webDriver)
        {
            
        }

        public IWebElement apparelAndAccessoriesLink => webDriver.FindElement(By.XPath("//*[@id=\"categorymenu\"]/nav/ul/li[2]/a"));
        public IWebElement apparelAndAccessoriesShoesLink => webDriver.FindElement(By.XPath("//*[@id=\"maincontainer\"]/div/div/div/div/ul/li[1]/a"));
        public IWebElement sortDropDownList => webDriver.FindElement(By.Id("sort"));
        public IWebElement sortLowToHighPriceOptionSelectedDropDownList => webDriver.FindElement(By.XPath("//*[@id=\"sort\"]/option[4]"));

    }
}
