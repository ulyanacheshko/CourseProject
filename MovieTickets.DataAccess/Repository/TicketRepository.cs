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
    public class TicketRepository : BaseRepository, ITicketRepository
    {
        public TicketRepository(MovieTicketsDbContext movieTicketsDbContext) : base(movieTicketsDbContext)
        {

        }

        public async Task<int> Create(Ticket ticket)
        {
            _movieTicketsDbContext.Tickets.Add(ticket);
            await _movieTicketsDbContext.SaveChangesAsync();

            return ticket.Id;
        }

        public async Task<List<Ticket>> GetTickets()
        {
            return await _movieTicketsDbContext.Tickets.ToListAsync();
        }

        public async Task<Ticket> GetById(int id)
        {
            return await _movieTicketsDbContext.Tickets.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(Ticket ticket)
        {
            _movieTicketsDbContext.Tickets.Update(ticket);
            await _movieTicketsDbContext.SaveChangesAsync();
        }

        public async Task Delete(Ticket ticket)
        {
            _movieTicketsDbContext.Tickets.Remove(ticket);
            await _movieTicketsDbContext.SaveChangesAsync();
        }


    }
}