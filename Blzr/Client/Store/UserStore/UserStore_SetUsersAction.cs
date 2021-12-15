using Blzr.Shared;

namespace Blzr.Client.Store.UserStore
{
    public class UserStore_SetUsersAction
    {
        public User[] _users { get; }

        public UserStore_SetUsersAction(User[] users)
        {
            _users = users;
        }
    }
}
