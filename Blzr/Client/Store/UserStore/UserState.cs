using Blzr.Shared;
using Fluxor;

namespace Blzr.Client.Store.UserStore
{
    public record UserState
    {
        public bool Initialized { get; init; }
        public bool Loading { get; init; }
        public User[] Users { get; init; }

    }

    public class UserFeature : Feature<UserState>
    {
        public override string GetName()  => nameof(UserState);


        protected override UserState GetInitialState() =>
            new UserState
            {
                Initialized = false,
                Loading = false,
                Users = Array.Empty<User>()
            };
    }
}
