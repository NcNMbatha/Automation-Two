using OpenQA.Selenium;
using System;
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

        public List<Double> RemoveCurrencySymbol()
        {
            string priceText = string.Empty;
            List<Double> listOfPrices = new List<double>();

            for (int priceIndex = 0; priceIndex < priceList.Count; priceIndex++)
            {
                if (!string.IsNullOrEmpty(priceList[priceIndex].Text))
                {
                    if (priceList[priceIndex].Text.Contains('€'))
                    {
                        priceText = priceList[priceIndex].Text.Replace('€', ' ').Replace('.', ',');
                    }
                    else
                    {
                        priceText = priceList[priceIndex].Text.Substring(1).Replace('.', ',');
                    }

                    listOfPrices.Add(double.Parse(priceText));
                }
            }

            return listOfPrices;
        }

    }
}
