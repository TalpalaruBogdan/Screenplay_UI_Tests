using Boa.Constrictor.Screenplay;

namespace ScreenplayTestFramework.Factories
{
    public class ActorFactory
    {
        public static IActor GetActor(string name, ILogger logger)
        {
            return new Actor(name, logger);
        }
    }
}
