using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{

    public enum TicketType { RegisteredTicket=1, UnregisteredTicket };
    [Serializable]
    public class Ticket
    {
        public string Seat { get; set; }

        private double price;
        public double Price { get => Discount == 0 ? price : price - (price * Discount); set => price = value; }
        public string Cinema { get ; set ; }
        public DateTime Session { get; set; }
        public double Discount { get; set; } = 0;
        public Ticket(double price, string cinema, DateTime session) { Price = price; Cinema = cinema; Session = session;  }
        public override string ToString() => $"cinema '{Cinema}'\nsession {Session}\n{Seat} price: {Price:F2} uah";

    }
    [Serializable]
    public class RegisteredTicket : Ticket
    {
        public string Owner { get; set; }

        public RegisteredTicket(Ticket ticket, string owner) : base(ticket.Price, ticket.Cinema, ticket.Session) { Owner = owner; Seat = ticket.Seat; }

        public override string ToString() => $"owner {Owner}\n" + base.ToString();
    }


}
