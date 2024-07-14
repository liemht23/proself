using Volo.Abp.Modularity;

namespace Proself;

[DependsOn(
    typeof(ProselfApplicationModule),
    typeof(ProselfDomainTestModule)
)]
public class ProselfApplicationTestModule : AbpModule
{

}
