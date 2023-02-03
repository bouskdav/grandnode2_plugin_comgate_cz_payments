using Grand.Domain.Data;
using Grand.Domain.Orders;

namespace Payments.Comgate.Services
{
    public class ComgatePaymentService : IComgatePaymentService
    {
        private readonly IRepository<Order> _orderRepository;

        public ComgatePaymentService(
            IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task<Order> GetOrderByComgateTransactionId(string transactionId)
        {
            var order = _orderRepository.Table.FirstOrDefault(i => i.UserFields.Any(f => f.Key == ComgateHelper.TRANSACTION_NUMBER && f.Value == transactionId));

            return Task.FromResult(order);
        }
    }
}
