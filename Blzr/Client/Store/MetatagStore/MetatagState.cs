using Blzr.Shared;
using Fluxor;

namespace Blzr.Client.Store.MetatagStore
{
    public record MetatagState
    {
        public bool Initialized { get;init;}
        public bool Loading { get; init; }
        public bool Updating { get; init; }
        public IEnumerable<Metatag>? Metatags { get; init; }
    }
}
