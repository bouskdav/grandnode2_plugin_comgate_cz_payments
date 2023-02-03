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

            //PDT
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.Comgate.PDTHandler",
                 "Plugins/PaymentComgate/PDTHandler",
                 new { controller = "PaymentComgate", action = "PDTHandler" }
            );
            //IPN
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.Comgate.IPNHandler",
                 "Plugins/PaymentComgate/IPNHandler",
                 new { controller = "PaymentComgate", action = "IPNHandler" }
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
