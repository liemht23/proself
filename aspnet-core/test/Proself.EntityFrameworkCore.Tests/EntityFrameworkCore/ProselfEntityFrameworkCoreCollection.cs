using Xunit;

namespace Proself.EntityFrameworkCore;

[CollectionDefinition(ProselfTestConsts.CollectionDefinitionName)]
public class ProselfEntityFrameworkCoreCollection : ICollectionFixture<ProselfEntityFrameworkCoreFixture>
{

}
