using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.NET.L3.Refactored
{
    public class CardPayment : PaymentModel, ICanPayViaCreditCard
    {
        public override void BuyTicket(TicketDetails ticket, Action onPayChangeToMobilePhone)
        {
            ChargeCard(ticket);
        }

        public void ChargeCard(TicketDetails ticket)
        {
            var gateway = new BankGateway();
            gateway.Charge(ticket.Price);
        }
    }
}
