using Blzr.Shared;

namespace Blzr.Client.Store.UserStore
{
    public class LoadUsersAction { }

    public class SetInitializedAction { }

    public class SetLoadingAction {
        public bool _loading { get; }

        public SetLoadingAction(bool loading)
        {
            _loading = loading;
        }
    }

    public class SetUsersAction
    {
        public IEnumerable<User> _users { get; }

        public SetUsersAction(IEnumerable<User> users)
        {
            _users = users;
        }
    }

}
