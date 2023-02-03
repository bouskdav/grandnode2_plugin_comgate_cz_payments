using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;

namespace Payments.Comgate.Models
{
    public class ConfigurationModel : BaseModel
    {
        public string StoreScope { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Comgate.Fields.UseSandbox")]
        public bool UseSandbox { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Comgate.Fields.BusinessEmail")]
        public string BusinessEmail { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Comgate.Fields.PDTToken")]
        public string PdtToken { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Comgate.Fields.PDTValidateOrderTotal")]
        public bool PdtValidateOrderTotal { get; set; }

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