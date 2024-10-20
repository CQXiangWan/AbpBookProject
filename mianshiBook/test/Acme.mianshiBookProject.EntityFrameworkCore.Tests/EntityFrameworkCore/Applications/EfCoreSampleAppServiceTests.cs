using Acme.mianshiBookProject.Samples;
using Xunit;

namespace Acme.mianshiBookProject.EntityFrameworkCore.Applications;

[Collection(mianshiBookProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<mianshiBookProjectEntityFrameworkCoreTestModule>
{

}
