using Blzr.Client.Services;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Blzr.Shared;
using System.Net.Http.Json;

namespace Blzr.Client.Store.UserStore
{
    public class UserStore_Effects
    {
        //[Inject]
        //public IUserService UserService { get; set; }

        private readonly HttpClient _httpClient;
        public UserStore_Effects(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        [EffectMethod(typeof(UserStore_LoadUsersAction))]
        public async Task UserStore_LoadUsersActionAsync(IDispatcher dispatcher)
        {
            dispatcher.Dispatch((new UserStore_SetLoadingAction(true)));
            //var users = await UserService.GetUsers();
            
            var users = await _httpClient.GetFromJsonAsync<IEnumerable<User>>("api/users");
            dispatcher.Dispatch(new UserStore_SetUsersAction(users));
            dispatcher.Dispatch(new UserStore_SetLoadingAction(false));
        }





    }
}
