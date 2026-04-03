using Abp.Mapperly;
using PionereeDemo.ApiClient.Models;
using PionereeDemo.Maui.Models.Common;
using Riok.Mapperly.Abstractions;

namespace PionereeDemo.Maui.Mappers;

[Mapper]
public partial class AbpAuthenticateResultModelToAuthenticateResultPersistanceModelMapper : MapperBase<AbpAuthenticateResultModel, AuthenticateResultPersistanceModel>
{
    [MapperIgnoreSource(nameof(AbpAuthenticateResultModel.PasswordResetCode))]
    [MapperIgnoreSource(nameof(AbpAuthenticateResultModel.TwoFactorRememberClientToken))]
    [MapperIgnoreSource(nameof(AbpAuthenticateResultModel.ReturnUrl))]
    public override partial AuthenticateResultPersistanceModel Map(AbpAuthenticateResultModel source);

    [MapperIgnoreSource(nameof(AbpAuthenticateResultModel.PasswordResetCode))]
    [MapperIgnoreSource(nameof(AbpAuthenticateResultModel.TwoFactorRememberClientToken))]
    [MapperIgnoreSource(nameof(AbpAuthenticateResultModel.ReturnUrl))]
    public override partial void Map(AbpAuthenticateResultModel source, AuthenticateResultPersistanceModel destination);
}

[Mapper]
public partial class AuthenticateResultPersistanceModelToAbpAuthenticateResultModelMapper : MapperBase<AuthenticateResultPersistanceModel, AbpAuthenticateResultModel>
{
    [MapperIgnoreTarget(nameof(AbpAuthenticateResultModel.PasswordResetCode))]
    [MapperIgnoreTarget(nameof(AbpAuthenticateResultModel.TwoFactorRememberClientToken))]
    [MapperIgnoreTarget(nameof(AbpAuthenticateResultModel.ReturnUrl))]
    public override partial AbpAuthenticateResultModel Map(AuthenticateResultPersistanceModel source);

    [MapperIgnoreTarget(nameof(AbpAuthenticateResultModel.PasswordResetCode))]
    [MapperIgnoreTarget(nameof(AbpAuthenticateResultModel.TwoFactorRememberClientToken))]
    [MapperIgnoreTarget(nameof(AbpAuthenticateResultModel.ReturnUrl))]
    public override partial void Map(AuthenticateResultPersistanceModel source, AbpAuthenticateResultModel destination);
}
