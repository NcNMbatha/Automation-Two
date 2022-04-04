using OpenQA.Selenium;

namespace AutomationExerciseTwo.BasePage
{
    public static class AppPages
    {
        public static ValidationPage ValidationPage;
        public static SortPage SortPage;
        public static FacebookPage FacebookPage;
        public static BasePage BasePage;

        public static void Init(IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl("https://automationteststore.com/");
            ValidationPage = new ValidationPage(webDriver);
            SortPage = new SortPage(webDriver);
            FacebookPage = new FacebookPage(webDriver);
            BasePage = new BasePage(webDriver);
        }
    }
}
