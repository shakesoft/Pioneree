using System.Threading.Tasks;
using Abp.Application.Services;
using PionereeDemo.MultiTenancy.Payments.Dto;
using PionereeDemo.MultiTenancy.Payments.Stripe.Dto;

namespace PionereeDemo.MultiTenancy.Payments.Stripe;

public interface IStripePaymentAppService : IApplicationService
{
    Task ConfirmPayment(StripeConfirmPaymentInput input);

    StripeConfigurationDto GetConfiguration();

    Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
}

