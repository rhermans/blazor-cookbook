using Blzr.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blzr.Client.Services
{
    public interface IUserService
    {
        //Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int userId);
        Task<User> GetUserByEmail(string email);
        //Task<Employee> AddEmployee(Employee employee);
        //Task<Employee> UpdateEmployee(Employee employee);
        //Task DeleteEmployee(int employeeId);
    }
}