using System;

namespace TSP.NET.L3
{
    public abstract class PaymentModel
    {
        public abstract void BuyTicket(TicketDetails ticket, Action onPayChangeToMobilePhone);
    }
}
