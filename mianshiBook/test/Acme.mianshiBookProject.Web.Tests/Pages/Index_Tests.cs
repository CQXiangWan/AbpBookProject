using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.mianshiBookProject.Pages;

public class Index_Tests : mianshiBookProjectWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
