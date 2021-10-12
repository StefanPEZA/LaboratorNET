using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.NET.L3.Refactored
{
    class CashPayment : PaymentModel, ICanOperateWithCash
    {

        private decimal _cashAccepted;
        public override void BuyTicket(TicketDetails ticket, Action onPayChangeToMobilePhone)
        {
            AcceptCash(ticket);
            DispenseChange(ticket, onPayChangeToMobilePhone);
        }

        public void AcceptCash(TicketDetails ticket)
        {
            var r = new Random();
            _cashAccepted = r.Next((int)ticket.Price, (int)ticket.Price + 1000);
        }

        private void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone)
        {
            if (_cashAccepted > ticket.Price &&
                !TryToDispense(_cashAccepted - ticket.Price))
                onPayChangeToMobilePhone?.Invoke();
        }

        private bool TryToDispense(decimal changeAmount)
        {
            return false; //or true :)
        }
    }
}
