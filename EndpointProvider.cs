using Grand.Infrastructure.Endpoints;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Payments.Comgate
{
    public partial class EndpointProvider : IEndpointProvider
    {
        public void RegisterEndpoint(IEndpointRouteBuilder endpointRouteBuilder)
        {
            //PaymentInfo
            endpointRouteBuilder.MapControllerRoute("Plugin.Comgate",
                 "Plugins/PaymentComgate/PaymentInfo",
                 new { controller = "PaymentComgate", action = "PaymentInfo", area = "" }
            );

            // Comgate callback
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.Comgate.InternalCallback",
                 "Plugins/PaymentComgate/InternalCallback",
                 new { controller = "PaymentComgate", action = "InternalCallback" }
            );

            // Comgate payment status
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.Comgate.PaymentCallback",
                 "Plugins/PaymentComgate/PaymentCallback",
                 new { controller = "PaymentComgate", action = "PaymentCallback" }
            );

            //Cancel
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.Comgate.CancelOrder",
                 "Plugins/PaymentComgate/CancelOrder",
                 new { controller = "PaymentComgate", action = "CancelOrder" }
            );
        }
        public int Priority => 0;

    }
}
