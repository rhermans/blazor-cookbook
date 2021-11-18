using Blzr.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blzr.Client.Services
{
    public class UserService : IUserService
    {


        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<User>>("api/users");
        }

        public Task<User> GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
       
    }
}




