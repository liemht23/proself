using Volo.Abp.Modularity;

namespace Proself;

/* Inherit from this class for your domain layer tests. */
public abstract class ProselfDomainTestBase<TStartupModule> : ProselfTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
