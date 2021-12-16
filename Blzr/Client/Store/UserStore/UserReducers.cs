using Fluxor;

namespace Blzr.Client.Store.UserStore
{
    public static class UserReducers
    {
        //SetUsersAction
        [ReducerMethod]
        public static UserState OnSetUsers(UserState state, SetUsersAction action)
        {
            return state with
            {
                Users = action._users
            };
        }
        //SetLoadingAction
        [ReducerMethod]
        public static UserState OnSetLoading(UserState state, SetLoadingAction action)
        {
            return state with
            {
                Loading = action._loading 
            };
        }

        //SetInitializedAction
        [ReducerMethod(typeof(SetInitializedAction))]
        public static UserState OnSetInitialized(UserState state)
        {
            return state with
            {
                Initialized = true
            };
        }













    }
}
