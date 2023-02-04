using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using ScreenplayTestFramework.Tasks;
using ScreenplayTestFramework.Pages;
using ScreenplayTestFramework.Fixtures;

namespace ScreenplayTestFramework.Tests
{
    public class DuckSearchTests : IClassFixture<ActorSarahFixture>
    {
        private readonly ActorSarahFixture _actorFixture;

        public DuckSearchTests(ActorSarahFixture actorFixture)
        {
            _actorFixture = actorFixture;
        }        

        [Theory]
        [InlineData("eevee")]
        [InlineData("music")]
        public void Actor_Searches_Duck_Page_For_(string searchTerm)
        {
            _actorFixture.Sarah.AttemptsTo(Navigate.ToUrl(DuckSearchPage.URL));

            _actorFixture.Sarah.AttemptsTo(SearchDuck.For(searchTerm));

            _actorFixture.Sarah.WaitsUntil(Appearance.Of(DuckSearchResultsPage.ResultsLink), IsEqualTo.True());
        }
    }
}