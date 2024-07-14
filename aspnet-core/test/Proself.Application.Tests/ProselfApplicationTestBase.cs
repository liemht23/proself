using Volo.Abp.Modularity;

namespace Proself;

public abstract class ProselfApplicationTestBase<TStartupModule> : ProselfTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
