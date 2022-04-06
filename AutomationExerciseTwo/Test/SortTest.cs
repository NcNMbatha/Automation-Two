using AutomationExerciseTwo.BasePage;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace AutomationExerciseTwo.Test
{
    [TestFixture]
    public class SortTest:BaseTest
    {
 
        [Test]
        public void Given_ListOfShoes_When_SortingByPriceAscending_Then_ConfirmConfirmIsSortedAscendingEqualsTrue()
        {
            var dropDownOption = "Price Low > High";

            AppPages.SortPage.apparelAndAccessoriesLink.Click();
            AppPages.SortPage.apparelAndAccessoriesShoesLink.Click();
            AppPages.SortPage.sortDropDownList.Click();
            var selectDropDownElement = new SelectElement(AppPages.SortPage.sortDropDownList);
            selectDropDownElement.SelectByText(dropDownOption);

            List<double> priceList = RemoveCurrencySymbol();
            double currentPrice = priceList[0];
            bool isSortedDescending = true;

            for (int priceIndex = 1; priceIndex < priceList.Count; priceIndex++)
            {
                if (currentPrice > priceList[priceIndex])
                {
                    isSortedDescending = false;
                    break;
                }
            }

            Assert.IsTrue(isSortedDescending);

        }

        [Test]
        public void Given_ListOfShoes_When_SortingByPriceDescending_Then_ConfirmIsSortedDescendingEqualsTrue()
        {
            var dropDownOption = "Price High > Low";

            AppPages.SortPage.apparelAndAccessoriesLink.Click();
            AppPages.SortPage.apparelAndAccessoriesShoesLink.Click();
            AppPages.SortPage.sortDropDownList.Click();
            var selectDropDownElement = new SelectElement(AppPages.SortPage.sortDropDownList);
            selectDropDownElement.SelectByText(dropDownOption);

            List<double> priceList = RemoveCurrencySymbol();
            double currentPrice = priceList[0];
            bool isSortedDescending = true;

            for (int priceIndex = 1; priceIndex < priceList.Count; priceIndex++)
            {
                if (currentPrice < priceList[priceIndex])
                {
                    isSortedDescending = false;
                    break;
                }
            }

            Assert.IsTrue(isSortedDescending);
        }

        public List<Double> RemoveCurrencySymbol()
        {
            string priceText = string.Empty;
            List<Double> priceList = new List<double>();

            for (int priceIndex = 0; priceIndex < AppPages.SortPage.priceList.Count; priceIndex++)
            {
                if (!string.IsNullOrEmpty(AppPages.SortPage.priceList[priceIndex].Text))
                {
                    if (AppPages.SortPage.priceList[priceIndex].Text.Contains('€'))
                    {
                        priceText = AppPages.SortPage.priceList[priceIndex].Text.Replace('€', ' ').Replace('.', ',');
                    }
                    else
                    {
                        priceText = AppPages.SortPage.priceList[priceIndex].Text.Substring(1).Replace('.', ',');
                    }

                    priceList.Add(double.Parse(priceText));
                }
            }

            return priceList;
        }
    }
}
