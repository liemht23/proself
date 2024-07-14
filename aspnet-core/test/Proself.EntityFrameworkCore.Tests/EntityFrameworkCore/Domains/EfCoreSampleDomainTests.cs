using Proself.Samples;
using Xunit;

namespace Proself.EntityFrameworkCore.Domains;

[Collection(ProselfTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ProselfEntityFrameworkCoreTestModule>
{

}
