using Microsoft.EntityFrameworkCore;
using MovieTickets.DataAccess.Repository.Contracts;
using MovieTickets.DataAccess.Repository;
using MovieTickets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTickets.DataAccess;

namespace HotelBooking.DataAccess.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(MovieTicketsDbContext movieTicketsDbContext) : base(movieTicketsDbContext)
        {

        }

        public async Task<int> Create(User user)
        {
            _movieTicketsDbContext.Users.Add(user);
            await _movieTicketsDbContext.SaveChangesAsync();

            return user.Id;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _movieTicketsDbContext.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _movieTicketsDbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(User user)
        {
            _movieTicketsDbContext.Users.Update(user);
            await _movieTicketsDbContext.SaveChangesAsync();
        }

        public async Task Delete(User user)
        {
            _movieTicketsDbContext.Users.Remove(user);
            await _movieTicketsDbContext.SaveChangesAsync();
        }


    }
}