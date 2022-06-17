using AutomationExerciseTwo.BasePage;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationExerciseTwo.Test
{
    [TestFixture]
    public class ValidationTest : BaseTest
    {
        [Test]
        public void Given_ShoePricesInDollars_When_ChangingCurrency_ThenConfirm_CurrencyChangeCounterEqualsExpectedCount()
        {
            var doller = '$';
            var euro = '€';
            var pound = '£';
            var currencyChangeCounter = 0;
            var expectedCount = 3;

            AppPages.ValidationPage.apparelAndAccessoriesLink.Click();
            AppPages.ValidationPage.apparelAndAccessoriesShoesLink.Click();
            AppPages.ValidationPage.currencyDropDownMenu.Click();
            AppPages.ValidationPage.currencyDropDownEuroLink.Click();

            if (AppPages.ValidationPage.shoePriceLabel.Text.Contains($"{euro}"))
            {
                currencyChangeCounter++;
            }

            AppPages.ValidationPage.currencyDropDownMenu.Click();
            AppPages.ValidationPage.currencyDropDownPoundLink.Click();

            if (AppPages.ValidationPage.shoePriceLabel.Text.Contains($"{pound}"))
            {
                currencyChangeCounter++;
            }

            AppPages.ValidationPage.currencyDropDownMenu.Click();
            AppPages.ValidationPage.currencyDropDownDollarLink.Click();

            if (AppPages.ValidationPage.shoePriceLabel.Text.Contains($"{doller}"))
            {
                currencyChangeCounter++;
            }

            Assert.AreEqual(expectedCount, currencyChangeCounter);
        }
    }
}
