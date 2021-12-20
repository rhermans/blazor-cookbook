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

        public async Task<HttpResponseMessage> AddMetatag(Metatag metatag)
        {
            return await _httpClient.PostAsJsonAsync<Metatag>($"api/metatags", metatag);
          

        }

        public async Task<HttpResponseMessage> DeleteMetatag(int Id)
        {
            //delete
            return await _httpClient.DeleteAsync($"api/metatags/{Id}");      
        }

        public Task<User> GetMetatag(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Metatag>> GetMetatags()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Metatag>>("api/metatags");
        }

        public Task<Metatag> UpdateMetatag(Metatag metatag)
        {
            //put -> returns HttpResponseMessage
            throw new NotImplementedException();
        }
    }
}
