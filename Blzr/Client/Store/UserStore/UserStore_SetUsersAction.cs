using Blzr.Shared;

namespace Blzr.Client.Store.UserStore
{
    public class UserStore_SetUsersAction
    {
        public IEnumerable<User> _users { get; }

        public UserStore_SetUsersAction(IEnumerable<User> users)
        {
            _users = users;
        }
    }
}
