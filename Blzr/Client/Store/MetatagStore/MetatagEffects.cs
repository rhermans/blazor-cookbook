using Fluxor;
using Blzr.Shared;
using System.Net.Http.Json;

namespace Blzr.Client.Store.MetatagStore
{
    public class MetatagEffects
    {
        private readonly HttpClient _httpClient;

        public MetatagEffects(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        [EffectMethod(typeof(LoadMetatagsAction))]
        public async Task LoadUsersActionAsync(IDispatcher dispatcher)
        {
            dispatcher.Dispatch((new SetLoadingAction(true)));
            var metatags = await _httpClient.GetFromJsonAsync<IEnumerable<Metatag>>("api/metatags");
            dispatcher.Dispatch(new SetMetatagsLoadedAction(metatags));
            dispatcher.Dispatch(new SetLoadingAction(false));
        }
    }
}
