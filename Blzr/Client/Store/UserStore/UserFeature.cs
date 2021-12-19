using Blzr.Shared;
using Fluxor;

namespace Blzr.Client.Store.UserStore
{
    public class UserFeature : Feature<UserState>
    {
        public override string GetName() => nameof(UserState);


        protected override UserState GetInitialState() =>
            new UserState
            {
                Initialized = false,
                Loading = false,
                Users = Enumerable.Empty<User>()
            };
    }
}
