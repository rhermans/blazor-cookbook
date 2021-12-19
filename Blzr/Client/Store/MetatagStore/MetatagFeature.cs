using Blzr.Shared;
using Fluxor;

namespace Blzr.Client.Store.MetatagStore
{
    public class MetatagFeature : Feature<MetatagState>
    {
        public override string GetName() => nameof(MetatagState);

        protected override MetatagState GetInitialState() =>
                  new MetatagState
            {
                Initialized = false,
                Loading = false,
                Updating = false,
                Metatags = Enumerable.Empty<Metatag>()
            };
        }
    }
