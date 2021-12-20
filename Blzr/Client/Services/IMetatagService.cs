using Blzr.Shared;

namespace Blzr.Client.Services
{
    public interface IMetatagService
    {
        //Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        Task<IEnumerable<Metatag>> GetMetatags();
        Task<User> GetMetatag(int Id);
      
        Task<Metatag> AddMetatag(Metatag metatag);
        Task<Metatag> UpdateMetatag(Metatag metatag);
        Task<HttpResponseMessage> DeleteMetatag(int Id);
    }
}
