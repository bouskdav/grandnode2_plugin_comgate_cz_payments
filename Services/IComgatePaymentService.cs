using Grand.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Comgate.Services
{
    public interface IComgatePaymentService
    {
        Task<Order> GetOrderByComgateTransactionId(string transactionId);
    }
}
