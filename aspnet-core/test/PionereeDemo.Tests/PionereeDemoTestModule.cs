using Abp.Modules;
using PionereeDemo.Test.Base;

namespace PionereeDemo.Tests;

[DependsOn(typeof(PionereeDemoTestBaseModule))]
public class PionereeDemoTestModule : AbpModule
{

}
