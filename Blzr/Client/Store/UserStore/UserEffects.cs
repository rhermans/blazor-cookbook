using Fluxor;
using Blzr.Shared;
using System.Net.Http.Json;

namespace Blzr.Client.Store.UserStore
{
    public class UserEffects
    {
        private readonly HttpClient _httpClient;

        public UserEffects(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        [EffectMethod(typeof(LoadUsersAction))]
        public async Task LoadUsersActionAsync(IDispatcher dispatcher)
        {
            dispatcher.Dispatch((new SetLoadingAction(true)));
            var users = await _httpClient.GetFromJsonAsync<IEnumerable<User>>("api/users");
            dispatcher.Dispatch(new SetUsersAction(users));
            dispatcher.Dispatch(new SetLoadingAction(false));
        }
    }
}