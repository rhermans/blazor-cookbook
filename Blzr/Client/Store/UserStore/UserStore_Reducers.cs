using Fluxor;

namespace Blzr.Client.Store.UserStore
{
    public static class UserStore_Reducers
    {

        [ReducerMethod]
        public static UserState OnSetUsers(UserState state, UserStore_SetUsersAction action)
        {
            return state with
            {
                Users = action._users
            };
        }

        [ReducerMethod]
        public static UserState OnSetLoading(UserState state, UserStore_SetLoadingAction action)
        {
            return state with
            {
                Loading = action._loading 
            };
        }

        [ReducerMethod(typeof(UserStore_SetInitializedAction))]
        public static UserState OnSetInitialized(UserState state)
        {
            return state with
            {
                Initialized = true
            };
        }













    }
}
