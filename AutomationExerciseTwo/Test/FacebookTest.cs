using AutomationExerciseTwo.BasePage;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationExerciseTwo.Test
{
    [TestFixture]
    public class FacebookTest:BaseTest
    {

        [Test]
        public void Given_YouAreInHomePage_When_ClickingFaceBookIcon_Then_ConfirmNewTabOpenEqualTrue()
        {
            bool newTabOpened = false;

            AppPages.FacebookPage.facebookIconLink.Click();
            AppPages.FacebookPage.webDriver.SwitchTo().Window(AppPages.FacebookPage.webDriver.WindowHandles[1]);

            if (AppPages.FacebookPage.webDriver.CurrentWindowHandle.Equals(AppPages.FacebookPage.webDriver.WindowHandles[1]))
            {
                newTabOpened = true;
                AppPages.FacebookPage.webDriver.SwitchTo().Window(AppPages.FacebookPage.webDriver.WindowHandles[0]);

                if (!AppPages.FacebookPage.webDriver.CurrentWindowHandle.Equals(AppPages.FacebookPage.webDriver.WindowHandles[0]))
                {
                    newTabOpened = false;
                }
            }

            Assert.IsTrue(newTabOpened);
        }
    }
}
