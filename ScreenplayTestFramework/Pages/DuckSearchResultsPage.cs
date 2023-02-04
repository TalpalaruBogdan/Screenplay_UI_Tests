using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;


namespace ScreenplayTestFramework.Pages
{
    public class DuckSearchResultsPage
    {
        public static IWebLocator ResultsLink => L(
            "Results link",
            By.ClassName("result__a")
            );
    }
}
