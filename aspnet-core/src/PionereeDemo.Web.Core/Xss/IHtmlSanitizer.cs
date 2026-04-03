using Abp.Dependency;

namespace PionereeDemo.Web.Xss;

public interface IHtmlSanitizer : ITransientDependency
{
    string Sanitize(string html);
}

