using ServiceApp.Interfaces;
using ServiceApp.Models;

namespace ServiceApp.Services
{
    public class MemoryTicketService : ITicketService
    {
        private readonly Dictionary<int, Ticket> _items = new Dictionary<int, Ticket>();
        public int Add(Ticket ticket)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            ticket.Id = id + 1;
            _items.Add(ticket.Id, ticket);
            return ticket.Id;
        }

        public List<Ticket> FindAll()
        {
            return _items.Values.ToList();
        }

        public Ticket? FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
