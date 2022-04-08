using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

public class TicketServiceTests
{
    [Fact]
    public void GetTicketPriceMustReturnNotNullatleTicket()
    {
        var ticketService = new TicketService();
        Assert.NotNull(ticketService.GetTicketPrice(1));
    }

    [Fact]
    public void GeTicketPriceMustThrowException()
    {
       
        
        var ticketServiceTest = new TicketService();
       
        Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
    }


    [Fact]
    public void SaveAndDeleteTicketinBase()
    {
        var ticketSerivce = new TicketService();
        var newTicket = new Ticket(300, "Тикет", 300);

        ticketSerivce.SaveTicket(newTicket);

        var allTicketNow = ticketSerivce.GetAllTicket();
        Assert.Contains<Ticket>(allTicketNow, x=> x == newTicket);


    }

    
}

