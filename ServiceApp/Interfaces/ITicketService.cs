using ServiceApp.Models;

namespace ServiceApp.Interfaces
{
    public interface ITicketService
    {
        int Add(Ticket ticket);
        void Update(Ticket ticket);
        List<Ticket> FindAll();
        Ticket? FindById(int id);
    }
}
