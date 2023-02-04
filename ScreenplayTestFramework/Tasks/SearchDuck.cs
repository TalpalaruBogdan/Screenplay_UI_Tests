using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using ScreenplayTestFramework.Pages;

namespace ScreenplayTestFramework.Tasks
{
    internal class SearchDuck : ITask
    {
        public string SearchTerm { get; }

        public SearchDuck(string searchTerm)
        {
            SearchTerm = searchTerm;
        }

        public static SearchDuck For(string searhTerm) => new SearchDuck(searhTerm);

        public void PerformAs(IActor actor)
        {
            actor.AttemptsTo(SendKeys.To(DuckSearchPage.SearchInput, SearchTerm));
            actor.AttemptsTo(Click.On(DuckSearchPage.SearchButton));
        }
    }
}
