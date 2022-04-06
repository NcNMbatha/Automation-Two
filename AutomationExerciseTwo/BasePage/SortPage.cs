using OpenQA.Selenium;
using System.Collections.Generic;

namespace AutomationExerciseTwo.BasePage
{
    public class SortPage:BasePage
    {
        public SortPage(IWebDriver webDriver):base(webDriver)
        {
            
        }

        public IWebElement apparelAndAccessoriesLink => webDriver.FindElement(By.XPath("//*[@id='categorymenu']//a[contains(.,'Apparel')]"));
        public IWebElement apparelAndAccessoriesShoesLink => webDriver.FindElement(By.XPath("//*[@id='maincontainer']//a[contains(.,'Shoes')]"));
        public IWebElement sortDropDownList => webDriver.FindElement(By.Id("sort"));
        public IList<IWebElement> priceList => webDriver.FindElements(By.ClassName("oneprice"));

    }
}
