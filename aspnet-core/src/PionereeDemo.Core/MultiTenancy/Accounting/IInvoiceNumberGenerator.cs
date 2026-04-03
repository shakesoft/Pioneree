using System.Threading.Tasks;
using Abp.Dependency;

namespace PionereeDemo.MultiTenancy.Accounting;

public interface IInvoiceNumberGenerator : ITransientDependency
{
    Task<string> GetNewInvoiceNumber();
}

