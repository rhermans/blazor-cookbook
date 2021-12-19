using Blzr.Shared;
using Fluxor;

namespace Blzr.Client.Store.UserStore
{
    public record UserState
    {
        public bool Initialized { get; init; }

        public bool Loading { get; init; }

        //public User[] Users { get; init; }
        public IEnumerable<User>? Users { get; init; }
    }

  
}