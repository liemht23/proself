using Proself.Samples;
using Xunit;

namespace Proself.EntityFrameworkCore.Applications;

[Collection(ProselfTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ProselfEntityFrameworkCoreTestModule>
{

}
