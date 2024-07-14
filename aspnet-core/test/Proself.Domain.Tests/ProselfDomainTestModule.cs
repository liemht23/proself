using Volo.Abp.Modularity;

namespace Proself;

[DependsOn(
    typeof(ProselfDomainModule),
    typeof(ProselfTestBaseModule)
)]
public class ProselfDomainTestModule : AbpModule
{

}
