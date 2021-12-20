using Blzr.Shared;
using System.Net.Http.Json;

namespace Blzr.Client.Services
{
    public class MetatagService : IMetatagService
    {

        private readonly HttpClient _httpClient;

        public MetatagService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<Metatag> AddMetatag(Metatag metatag)
        {
            //throw new NotImplementedException();
            var res =  await _httpClient.PostAsJsonAsync<Metatag>($"api/metatags", metatag);
            metatag = await res.Content.ReadFromJsonAsync<Metatag>();
            return metatag;

        }

        public async Task<HttpResponseMessage> DeleteMetatag(int Id)
        {
            //delete
            return await _httpClient.DeleteAsync($"api/metatags/{Id}");      
        }

        public async Task<Metatag> GetMetatag(int Id)
        {
            return await _httpClient.GetFromJsonAsync<Metatag>($"api/metatags/{Id}");
        }

        public async Task<IEnumerable<Metatag>> GetMetatags()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Metatag>>("api/metatags");
        }

        public async Task<HttpResponseMessage> UpdateMetatag(Metatag metatag)
        {
            //put -> returns HttpResponseMessage
            var res = await _httpClient.PutAsJsonAsync<Metatag>($"api/metatags", metatag);
            
            return res;
        }
    }
}
