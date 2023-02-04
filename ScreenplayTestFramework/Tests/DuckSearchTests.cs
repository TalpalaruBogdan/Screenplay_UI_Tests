using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using ScreenplayTestFramework.Tasks;
using ScreenplayTestFramework.Pages;
using ScreenplayTestFramework.Fixtures;

namespace ScreenplayTestFramework.Tests
{
    public class DuckSearchTests : IClassFixture<ActorFixture>
    {
        private readonly ActorFixture _actorFixture;

        public DuckSearchTests(ActorFixture actorFixture)
        {
            _actorFixture = actorFixture;
        }        

        [Theory]
        [InlineData("eevee")]
        [InlineData("music")]
        public void Actor_Searches_Duck_Page_For_(string searchTerm)
        {
            _actorFixture.Actor.AttemptsTo(Navigate.ToUrl(DuckSearchPage.URL));

            _actorFixture.Actor.AttemptsTo(SearchDuck.For(searchTerm));

            _actorFixture.Actor.WaitsUntil(Appearance.Of(DuckSearchResultsPage.ResultsLink), IsEqualTo.True());
        }
    }
}