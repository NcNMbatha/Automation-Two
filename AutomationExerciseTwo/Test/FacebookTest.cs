using AutomationExerciseTwo.BasePage;
using NUnit.Framework;

namespace AutomationExerciseTwo.Test
{
    [TestFixture]
    public class FacebookTest:BaseTest
    {

        [Test]
        public void Given_YouAreInHomePage_When_ClickingFaceBookIcon_Then_ConfirmNewTabOpenEqualsTrue()
        {
            AppPages.FacebookPage.facebookIconLink.Click();
            AppPages.FacebookPage.webDriver.SwitchTo().Window(AppPages.FacebookPage.webDriver.WindowHandles[1]);
            bool newTabOpened = AppPages.FacebookPage.facebookHeaderLabel.Text.Contains("Facebook");
            AppPages.FacebookPage.webDriver.SwitchTo().Window(AppPages.FacebookPage.webDriver.WindowHandles[0]);

            Assert.IsTrue(newTabOpened);
        }
    }
}
