using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.NET.L3.Refactored
{
    interface ICanOperateWithCash
    {
        abstract void ChargeCard(TicketDetails ticket, PaymentDetails payment);
    }
}
