using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.Entities;

namespace MovieTickets.DataAccess.Repository.Contracts
{
    public interface IUserRepository
    {
        Task<User> GetById(int id);
        Task<List<User>> GetUsers();
        Task<int> Create(User user);
        Task Update(User user);
        Task Delete(User user);

    }
}
