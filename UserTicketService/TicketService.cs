using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TicketService
{
    public int GetTicketPrice(int ticketId)
    {
        var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
        return (ticket is null) ?
           throw new TicketNotFoundException() : ticket.Price;
    }

    public int GetTicket(int ticketId)
    {
        var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
        return (ticket is null) ?
           throw new TicketNotFoundException() : ticket.Id;
    }

    public void SaveTicket(Ticket ticket)
    {
        FakeBaseData.Add(ticket);
    }

    public void RemoveTicket(Ticket ticket)
    {
        FakeBaseData.Remove(ticket);
    }

    public IEnumerable<Ticket> GetAllTicket()
    {
        return FakeBaseData;
    }

    private List<Ticket> FakeBaseData = new List<Ticket>
    {
            new Ticket(1, "Москва - Санкт-Петербург", 3500),
            new Ticket(2, "Челябинск - Магадан", 3500),
            new Ticket(3, "Норильск - Уфа", 3500)
    };


};

