using System;

namespace TSP.NET.L3
{

    public class PaymentMode
    {
        private decimal _cashAccepted;

        public void BuyTicket(TicketDetails ticket,
                              PaymentDetails payment, Action onPayChangeToMobilePhone)
        {
            if (payment.Method == PaymentMethod.CreditCard)
            {
                ChargeCard(ticket, payment);
            }
            else
            {
                AcceptCash(ticket);
                DispenseChange(ticket, onPayChangeToMobilePhone);
            }
        }

        private void ChargeCard(TicketDetails ticket, PaymentDetails payment)
        {
            var gateway = new ProcessingCenterGateway1();
            gateway.Charge(ticket.Price, payment);
        }

        private void AcceptCash(TicketDetails ticket)
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

    internal class ProcessingCenterGateway1
    {
        public void Charge(decimal ticketPrice, PaymentDetails paymentDetails)
        {
            //charging process
        }
    }
}
