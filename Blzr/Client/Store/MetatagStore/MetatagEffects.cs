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
        public async Task LoadMetatagsActionAsync(IDispatcher dispatcher)
        {
            dispatcher.Dispatch((new SetLoadingAction(true)));
            var metatags = await _httpClient.GetFromJsonAsync<IEnumerable<Metatag>>("api/metatags");
            dispatcher.Dispatch(new SetMetatagsLoadedAction(metatags));
            dispatcher.Dispatch(new SetLoadingAction(false));
        }

        [EffectMethod]
        public async Task SaveMetatagAsync( SaveMetatagAction action, IDispatcher dispatcher)
        {
            dispatcher.Dispatch((new SetLoadingAction(true)));
            var res = await _httpClient.PutAsJsonAsync<Metatag>($"api/metatags/{action.metatag.Id}",action.metatag);
            if (res.IsSuccessStatusCode)
            {
                dispatcher.Dispatch(new SaveMetatagSuccesAction(action.metatag));
            }
            else
            {
               
            }

            dispatcher.Dispatch(new SetLoadingAction(false));

        }



    }
}
