using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ticket
{
    public int Id { get; }
    public string Description { get; }
    public int Price { get; }

    public Ticket(int id, string descriptiom, int price)
    {
        Id = id;
        Description = descriptiom;
        Price = price;
    }
}

