namespace Blzr.Client.Store.UserStore {
    public class UserStore_SetLoadingAction
    {
        public bool _loading { get; }

        public  UserStore_SetLoadingAction(bool loading)
        {
            _loading = loading;
        }
    }
}
