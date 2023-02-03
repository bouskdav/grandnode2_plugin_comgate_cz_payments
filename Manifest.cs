using Grand.Infrastructure;
using Grand.Infrastructure.Plugins;
using Payments.Comgate;

[assembly: PluginInfo(
    FriendlyName = "Comgate Czech",
    Group = "Payment methods",
    SystemName = ComgatePaymentDefaults.ProviderSystemName,
    SupportedVersion = GrandVersion.SupportedPluginVersion,
    Author = "Laguna Solutions",
    Version = "1.00"
)]