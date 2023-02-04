using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;


namespace ScreenplayTestFramework.Pages
{
    public static class DuckSearchPage
    {
        public const string URL = "https://duckduckgo.com/";

        public static IWebLocator SearchInput => L(
            "Search field",
            By.Id("search_form_input_homepage")
            );

        public static IWebLocator SearchButton => L(
            "Search Button",
            By.Id("search_button_homepage")
            );
    }
}
