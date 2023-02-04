using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using ScreenplayTestFramework.Factories;

namespace ScreenplayTestFramework.Fixtures
{
    public class ActorSarahFixture : IAsyncLifetime
    {
        public IActor Sarah { get; private set; }
        public IWebDriver Chrome { get; private set; }

        public Task InitializeAsync()
        {
            Sarah = ActorFactory.GetActor("Sarah", new ConsoleLogger());
            Chrome = DriverFactory.GetDriver("Chrome");

            Sarah.Can(BrowseTheWeb.With(Chrome));

            return Task.CompletedTask;
        }

        public Task DisposeAsync()
        {
            Sarah.AttemptsTo(QuitWebDriver.ForBrowser());
            return Task.CompletedTask;
        }
    }
}
