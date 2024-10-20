using Acme.mianshiBookProject.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Acme.mianshiBookProject.EntityFrameworkCore.Applications.Authors
{
    [Collection(mianshiBookProjectTestConsts.CollectionDefinitionName)]
    public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<mianshiBookProjectEntityFrameworkCoreTestModule>
    {

    }
}
