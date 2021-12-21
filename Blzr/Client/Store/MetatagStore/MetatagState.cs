using Blzr.Shared;
using Fluxor;

namespace Blzr.Client.Store.MetatagStore
{
    public record MetatagState
    {
        public bool Initialized { get;init;}
        public bool Loading { get; init; }
        public bool Updating { get; init; }
        //IEnumerator infrastructure in .NET is inherently mutable
        public IEnumerable<Metatag>? Metatags { get; init;  }
    }
}
