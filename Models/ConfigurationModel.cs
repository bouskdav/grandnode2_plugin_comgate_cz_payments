using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;

namespace Payments.Comgate.Models
{
    public class ConfigurationModel : BaseModel
    {
        public string StoreScope { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Comgate.Fields.UseSandbox")]
        public bool UseSandbox { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Comgate.Fields.MerchantId")]
        public string MerchantId { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Comgate.Fields.ComgateSecret")]
        public string ComgateSecret { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Comgate.Fields.AdditionalFee")]
        public double AdditionalFee { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Comgate.Fields.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Comgate.Fields.PassProductNamesAndTotals")]
        public bool PassProductNamesAndTotals { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Comgate.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }



    }
}