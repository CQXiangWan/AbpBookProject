using Acme.mianshiBookProject.Samples;
using Xunit;

namespace Acme.mianshiBookProject.EntityFrameworkCore.Domains;

[Collection(mianshiBookProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<mianshiBookProjectEntityFrameworkCoreTestModule>
{

}
