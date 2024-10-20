using Xunit;

namespace Acme.mianshiBookProject.EntityFrameworkCore;

[CollectionDefinition(mianshiBookProjectTestConsts.CollectionDefinitionName)]
public class mianshiBookProjectEntityFrameworkCoreCollection : ICollectionFixture<mianshiBookProjectEntityFrameworkCoreFixture>
{

}
