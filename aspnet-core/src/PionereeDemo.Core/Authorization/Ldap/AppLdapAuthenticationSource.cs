using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using PionereeDemo.Authorization.Users;
using PionereeDemo.MultiTenancy;

namespace PionereeDemo.Authorization.Ldap;

public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
{
    public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
        : base(settings, ldapModuleConfig)
    {
    }
}

