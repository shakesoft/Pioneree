using System.Threading.Tasks;
using Abp.Application.Services;
using PionereeDemo.MultiTenancy.Payments.PayPal.Dto;

namespace PionereeDemo.MultiTenancy.Payments.PayPal;

public interface IPayPalPaymentAppService : IApplicationService
{
    Task ConfirmPayment(long paymentId, string paypalOrderId);

    PayPalConfigurationDto GetConfiguration();
}

