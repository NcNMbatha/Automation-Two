using AutomationExerciseTwo.BasePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationExerciseTwo.Test
{
    [TestFixture]
    public class SortTest:BaseTest
    {
 
        [Test]
        public void Given_ListOfShoes_When_SortingByPriceAscending_Then_ConfirmSelectedDropDownOptionIsPriceLowToHigh()
        {
            var dropDownOption = "Price Low > High";

            AppPages.SortPage.apparelAndAccessoriesLink.Click();
            AppPages.SortPage.apparelAndAccessoriesShoesLink.Click();
            AppPages.SortPage.sortDropDownList.Click();
            var selectDropDownElement = new SelectElement(AppPages.SortPage.sortDropDownList);
            selectDropDownElement.SelectByText(dropDownOption);

            Assert.IsTrue(AppPages.SortPage.sortLowToHighPriceOptionSelectedDropDownList.Selected);

        }

        [Test]
        public void Given_ListOfShoes_When_SortingByPriceDescending_Then_ConfirmSelectedDropDownOptionIsPriceHighToLow()
        {
            var dropDownOption = "Price High > Low";

            AppPages.SortPage.apparelAndAccessoriesLink.Click();
            AppPages.SortPage.apparelAndAccessoriesShoesLink.Click();
            AppPages.SortPage.sortDropDownList.Click();
            var selectDropDownElement = new SelectElement(AppPages.SortPage.sortDropDownList);
            selectDropDownElement.SelectByText(dropDownOption);


        }
    }
}
