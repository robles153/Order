using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<bool> AuthenticationAsync(UserModel user);
        Task CreateAsync(UserModel user);
        Task UpdateAsync(UserModel user);
        Task DeleteAsync(string userId);
        Task<UserModel> GetByIdAsync(string userId);
        Task<List<UserModel>> ListByFilterAsync(string userId = null, string name = null);     
    }
}
